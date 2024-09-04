namespace Farm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            cmbAnimalType = new ComboBox();
            txtAge = new TextBox();
            btnAddAnimal = new Button();
            imageListAnimals = new ImageList(components);
            lblBalance = new Label();
            dgvAnimals = new DataGridView();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).BeginInit();
            SuspendLayout();
            // 
            // cmbAnimalType
            // 
            cmbAnimalType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAnimalType.FormattingEnabled = true;
            cmbAnimalType.Location = new Point(12, 12);
            cmbAnimalType.Name = "cmbAnimalType";
            cmbAnimalType.Size = new Size(150, 23);
            cmbAnimalType.TabIndex = 0;
            cmbAnimalType.SelectedIndexChanged += animalTypeComboBox_SelectedIndexChanged;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(200, 12);
            txtAge.Name = "txtAge";
            txtAge.PlaceholderText = "Enter age of animal";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 1;
            // 
            // btnAddAnimal
            // 
            btnAddAnimal.Location = new Point(354, 12);
            btnAddAnimal.Name = "btnAddAnimal";
            btnAddAnimal.Size = new Size(120, 23);
            btnAddAnimal.TabIndex = 2;
            btnAddAnimal.Text = "Add Animal";
            btnAddAnimal.UseVisualStyleBackColor = true;
            btnAddAnimal.Click += btnAdd_Click;
            // 
            // imageListAnimals
            // 
            imageListAnimals.ColorDepth = ColorDepth.Depth32Bit;
            imageListAnimals.ImageStream = (ImageListStreamer)resources.GetObject("imageListAnimals.ImageStream");
            imageListAnimals.TransparentColor = Color.Transparent;
            imageListAnimals.Images.SetKeyName(0, "cow.png");
            imageListAnimals.Images.SetKeyName(1, "goat.png");
            imageListAnimals.Images.SetKeyName(2, "sheep.png");
            imageListAnimals.Images.SetKeyName(3, "chicken.png");
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(668, 16);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(72, 15);
            lblBalance.TabIndex = 6;
            lblBalance.Text = "Balance: 140";
            // 
            // dgvAnimals
            // 
            dgvAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimals.Location = new Point(12, 59);
            dgvAnimals.Name = "dgvAnimals";
            dgvAnimals.Size = new Size(600, 400);
            dgvAnimals.TabIndex = 8;
            dgvAnimals.CellClick += dgvAnimals_CellClick;
            dgvAnimals.CellPainting += dgvAnimals_CellPainting;
            // 
            // timer1
            // 
            timer1.Interval = 60000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(dgvAnimals);
            Controls.Add(lblBalance);
            Controls.Add(btnAddAnimal);
            Controls.Add(txtAge);
            Controls.Add(cmbAnimalType);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbAnimalType;
        private TextBox txtAge;
        private Button btnAddAnimal;
        private Button generateReportButton;
        private ImageList imageListAnimals;
        private Label lblBalance;
        private DataGridView dgvAnimals;
        private System.Windows.Forms.Timer timer1;
    }
}
