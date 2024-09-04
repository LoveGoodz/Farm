namespace Farm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void animalTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbAnimalType.Items.Add("Cow");
            cmbAnimalType.Items.Add("Goat");
            cmbAnimalType.Items.Add("Sheep");
            cmbAnimalType.Items.Add("Chicken");
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string animalType = cmbAnimalType.SelectedItem.ToString();
            int age;
            if (!int.TryParse(txtAge.Text, out age) || age < 0)
            {
                MessageBox.Show("Please enter a valid age.");
                return;
            }

            Animal animal = null;
            switch (animalType)
            {
                case "Cow":
                    animal = new Cow("Cow", age);
                    break;
                case "Goat":
                    animal = new Goat("Goat", age);
                    break;
                case "Sheep":
                    animal = new Sheep("Sheep", age);
                    break;
                case "Chicken":
                    animal = new Chicken("Chicken", age);
                    break;
            }

            if (animal != null)
            {
                dgvAnimals.Rows.Add(animal.Name, animal.Age, animal.ProducedProduct);
            }
        }

            }

        }
    



