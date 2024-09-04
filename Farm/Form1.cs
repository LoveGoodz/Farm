namespace Farm
{
    public partial class Form1 : Form
    {
        private List<Animal> animals = new List<Animal>();
        private double balance = 140;
        private int totalDaysPassed = 0;
        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadAnimalTypes();
            UpdateBalanceLabel();

            dgvAnimals.CellPainting += dgvAnimals_CellPainting;
            dgvAnimals.CellClick += dgvAnimals_CellClick;

            timer1.Interval = 10000; // Her 10 saniyede bir gün geçmesi için interval 10,000 ms
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void animalTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void InitializeDataGridView()
        {
            // Hayvan türü için sütun ekleyin
            var typeColumn = new DataGridViewTextBoxColumn();
            typeColumn.Name = "Type";
            typeColumn.HeaderText = "Animal Type";
            typeColumn.Width = 100; // Sütun geniþliðini ayarlayýn
            dgvAnimals.Columns.Add(typeColumn);

            // Ýkon sütununu ekleyin ve geniþliðini ayarlayýn
            var iconColumn = new DataGridViewImageColumn();
            iconColumn.Name = "Icon";
            iconColumn.HeaderText = "Icon";
            iconColumn.Width = 60; // Ýkon sütun geniþliði
            iconColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Ýkonun sýðmasý için Zoom yapýn
            dgvAnimals.Columns.Add(iconColumn);

            // Yaþ ilerleme sütunu
            var ageProgressColumn = new DataGridViewTextBoxColumn();
            ageProgressColumn.Name = "LifeSpanProgress";
            ageProgressColumn.HeaderText = "Age Progress";
            ageProgressColumn.Width = 100; // Sütun geniþliði
            dgvAnimals.Columns.Add(ageProgressColumn);

            // Ürün ilerleme sütunu
            var productProgressColumn = new DataGridViewTextBoxColumn();
            productProgressColumn.Name = "ProductProgress";
            productProgressColumn.HeaderText = "Product Progress";
            productProgressColumn.Width = 100; // Sütun geniþliði
            dgvAnimals.Columns.Add(productProgressColumn);

            // Satýþ butonu sütunu
            var sellButtonColumn = new DataGridViewButtonColumn();
            sellButtonColumn.Name = "Sell";
            sellButtonColumn.HeaderText = "Sell Product";
            sellButtonColumn.Text = "Sell";
            sellButtonColumn.UseColumnTextForButtonValue = true;
            sellButtonColumn.Width = 80; // Sütun geniþliði
            dgvAnimals.Columns.Add(sellButtonColumn);
        }
        private void LoadAnimalTypes()
        {
            cmbAnimalType.Items.Add("Cow");
            cmbAnimalType.Items.Add("Goat");
            cmbAnimalType.Items.Add("Sheep");
            cmbAnimalType.Items.Add("Chicken");
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = "Animal" + (dgvAnimals.Rows.Count + 1);
            int age;
            if (int.TryParse(txtAge.Text, out age))
            {
                double animalCost = 0;
                string animalType = cmbAnimalType.SelectedItem.ToString();

                switch (animalType)
                {
                    case "Cow": animalCost = 50; break;
                    case "Goat": animalCost = 40; break;
                    case "Sheep": animalCost = 30; break;
                    case "Chicken": animalCost = 20; break;
                }

                if (balance >= animalCost)
                {
                    Animal animal = CreateAnimal(animalType, name, age);
                    if (animal != null)
                    {
                        balance -= animalCost; // Hayvanýn ücretini bakiyeden düþ
                        animals.Add(animal);
                        UpdateAnimalGrid();
                        UpdateBalanceLabel();
                        txtAge.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Invalid animal type selected.");
                    }
                }
                else
                {
                    MessageBox.Show("Insufficient balance to buy this animal.");
                }
            }
            else
            {
                MessageBox.Show("Invalid age entered.");
            }
        }
        private Animal CreateAnimal(string type, string name, int age)
        {
            switch (type)
            {
                case "Cow": return new Cow(name, age);
                case "Goat": return new Goat(name, age);
                case "Sheep": return new Sheep(name, age);
                case "Chicken": return new Chicken(name, age);
                default: return null;
            }
        }

        private void UpdateAnimalGrid()
        {
            dgvAnimals.Rows.Clear();
            foreach (var animal in animals)
            {
                int rowIndex = dgvAnimals.Rows.Add();
                var row = dgvAnimals.Rows[rowIndex];

                row.Cells["Type"].Value = animal.GetType().Name; // Hayvan türünü ekleyin
                row.Cells["Icon"].Value = GetAnimalIcon(animal);
                row.Cells["LifeSpanProgress"].Value = (int)((double)animal.Age / animal.Lifespan * 100);
                row.Cells["ProductProgress"].Value = (int)((double)animal.ProducedProduct / animal.MaxProduct * 100);
            }
            UpdateBalanceLabel();
        }
        private void UpdateBalanceLabel()
        {
            lblBalance.Text = $"Balance: {balance}";
        }

        private Image GetAnimalIcon(Animal animal)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory + "Properties\\";

            // Hayvan türüne göre uygun ikon dosyasýný yükleyin
            switch (animal)
            {
                case Cow _: return Image.FromFile(basePath + "cow.png");
                case Goat _: return Image.FromFile(basePath + "goat.png");
                case Sheep _: return Image.FromFile(basePath + "sheep.png");
                case Chicken _: return Image.FromFile(basePath + "chicken.png");
                default: return null;
            }
        }


        private void dgvAnimals_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == dgvAnimals.Columns["ProductProgress"].Index || e.ColumnIndex == dgvAnimals.Columns["LifeSpanProgress"].Index))
            {
                // Önce hücrenin arka planýný temizle
                e.PaintBackground(e.ClipBounds, true);

                // Ýlerlemenin ne kadar olduðunu hesapla
                int progress = (int)(e.Value ?? 0);
                var rect = e.CellBounds;
                rect.Width = (int)(rect.Width * (progress / 100.0)); // Ýlerleme çubuðunun geniþliðini ayarla

                // Ýlerleme çubuðunu yeþil renkte doldur
                using (var brush = new SolidBrush(Color.Green))
                {
                    e.Graphics.FillRectangle(brush, rect);
                }

                // Hücrenin içeriðini çizmeyi tamamla
                e.PaintContent(e.ClipBounds);
                e.Handled = true;
            }
        }

        private void dgvAnimals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvAnimals.Columns["Sell"].Index)
            {
                var row = dgvAnimals.Rows[e.RowIndex];
                string animalType = row.Cells["Type"].Value.ToString();
                var animal = animals.FirstOrDefault(a => a.GetType().Name == animalType);

                if (animal != null)
                {
                    double sellThreshold = 0;
                    double productPrice = 0;

                    if (animal is Cow || animal is Goat || animal is Sheep)
                    {
                        sellThreshold = 100; // 100 litre süt için satýþ yapýlacak
                        productPrice = (animal.ProducedProduct / 100) * 10; // 1 litre süt 0.5 para birimi
                    }
                    else if (animal is Chicken)
                    {
                        sellThreshold = 25; // 25 yumurta için satýþ yapýlacak
                        productPrice = (animal.ProducedProduct / 25) * 5; // 1 yumurta 0.25 para birimi
                    }

                    // Ürün miktarý satýþ eþiðine ulaþtýðýnda satýþ yap
                    if (animal.ProducedProduct >= sellThreshold)
                    {
                        balance += productPrice; // Satýþ fiyatýný ekle
                        animal.ProducedProduct -= sellThreshold; // Ürün miktarýný azalt
                        UpdateAnimalGrid();
                        UpdateBalanceLabel();
                    }
                    else
                    {
                        MessageBox.Show("Not enough product to sell.");
                    }
                }
                else
                {
                    MessageBox.Show("Animal not found or null.");
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            totalDaysPassed += 1; // Her 10 saniyede bir gün simüle ediliyor

            // Süt ve yumurta üretimi her gün (10 saniyede bir) yapýlacak
            foreach (var animal in animals.ToList())
            {
                animal.ProduceProduct(); // Günlük üretim sürecini güncelle

                // Eðer 10 gün (100 saniye) geçtiyse, yaþlarý artýr
                if (totalDaysPassed % 10 == 0)
                {
                    animal.Age += 1; // Her 10 günde bir yaþ ekleniyor (her 100 saniye)

                    // Yaþam süresi dolan hayvanlarý kaldýr
                    if (animal.Age >= animal.Lifespan)
                    {
                        animals.Remove(animal);
                        Console.WriteLine($"{animal.Name} removed (Age: {animal.Age})");
                    }
                }
            }

            UpdateAnimalGrid();
            UpdateBalanceLabel();

            // 5 dakikalýk simülasyon (300 saniye) tamamlandýðýnda durdur
            if (totalDaysPassed >= 300) // 300 saniye = 30 gün = 1 ay simülasyonu
            {
                timer1.Stop();
                Console.WriteLine("Simulation complete: 5 minutes passed.");
            }
        }
    }


}




