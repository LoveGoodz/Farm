namespace Farm
{
    public partial class Form1 : Form
    {
        private List<Animal> animals = new List<Animal>();
        private double balance = 140;
        public Form1()
        {
            InitializeComponent();
            LoadAnimalTypes();
            UpdateBalanceLabel();

            dgvAnimals.CellPainting += dgvAnimals_CellPainting;
            dgvAnimals.CellClick += dgvAnimals_CellClick;
        }

        private void animalTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                Animal animal = CreateAnimal(cmbAnimalType.SelectedItem.ToString(), name, age);
                if (animal != null)
                {
                    animals.Add(animal);
                    UpdateAnimalGrid();
                    txtAge.Clear();
                }
                else
                {
                    MessageBox.Show("Invalid animal type selected.");
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
                // �kon, ya� ve �r�n �retim bilgilerini i�eren sat�rlar� ekleyin.
            }
            UpdateBalanceLabel();
        }
        private void UpdateBalanceLabel()
        {
            lblBalance.Text = $"Balance: {balance}";
        }

        private void dgvAnimals_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == dgvAnimals.Columns["ProductProgress"].Index || e.ColumnIndex == dgvAnimals.Columns["LifeSpanProgress"].Index))
            {
                // �nce h�crenin arka plan�n� temizle
                e.PaintBackground(e.ClipBounds, true);

                // �lerlemenin ne kadar oldu�unu hesapla
                int progress = (int)(e.Value ?? 0);
                var rect = e.CellBounds;
                rect.Width = (int)(rect.Width * (progress / 100.0)); // �lerleme �ubu�unun geni�li�ini ayarla

                // �lerleme �ubu�unu ye�il renkte doldur
                using (var brush = new SolidBrush(Color.Green))
                {
                    e.Graphics.FillRectangle(brush, rect);
                }

                // H�crenin i�eri�ini �izmeyi tamamla
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
                    if (animal is Cow || animal is Goat || animal is Sheep)
                    {
                        if (animal.ProducedProduct >= 80)
                        {
                            balance += (animal.ProducedProduct / 80) * 15;
                            animal.ProducedProduct %= 80;
                            UpdateAnimalGrid();
                        }
                    }
                    else if (animal is Chicken)
                    {
                        if (animal.ProducedProduct >= 20)
                        {
                            balance += (animal.ProducedProduct / 20) * 5;
                            animal.ProducedProduct %= 20;
                            UpdateAnimalGrid();
                        }
                    }
                }

                UpdateBalanceLabel();
            }
        }
    }


}




