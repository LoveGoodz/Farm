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
            btnAdd = new Button();
            imageListAnimals = new ImageList(components);
            lblBalance = new Label();
            btnSell = new Button();
            dgvAnimals = new DataGridView();
            colIcon = new DataGridViewImageColumn();
            colAgeProgress = new DataGridViewTextBoxColumn();
            colProductProgress = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).BeginInit();
            SuspendLayout();
            // 
            // cmbAnimalType
            // 
            cmbAnimalType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAnimalType.FormattingEnabled = true;
            cmbAnimalType.Items.AddRange(new object[] { "Cow", "Goat", "Sheep", "Chicken" });
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
            // btnAdd
            // 
            btnAdd.Location = new Point(354, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add Animal";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
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
            // btnSell
            // 
            btnSell.Location = new Point(12, 489);
            btnSell.Name = "btnSell";
            btnSell.Size = new Size(75, 23);
            btnSell.TabIndex = 7;
            btnSell.Text = "Sell Products";
            btnSell.UseVisualStyleBackColor = true;
            // 
            // dgvAnimals
            // 
            dgvAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimals.Columns.AddRange(new DataGridViewColumn[] { colIcon, colAgeProgress, colProductProgress });
            dgvAnimals.Location = new Point(12, 59);
            dgvAnimals.Name = "dgvAnimals";
            dgvAnimals.Size = new Size(600, 400);
            dgvAnimals.TabIndex = 8;
            // 
            // colIcon
            // 
            colIcon.HeaderText = "Icon";
            colIcon.Name = "colIcon";
            // 
            // colAgeProgress
            // 
            colAgeProgress.HeaderText = "Age";
            colAgeProgress.Name = "colAgeProgress";
            // 
            // colProductProgress
            // 
            colProductProgress.HeaderText = "Product";
            colProductProgress.Name = "colProductProgress";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(dgvAnimals);
            Controls.Add(btnSell);
            Controls.Add(lblBalance);
            Controls.Add(btnAdd);
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
        private Button btnAdd;
        private Button generateReportButton;
        private ImageList imageListAnimals;
        private Label lblBalance;
        private Button btnSell;
        private DataGridView dgvAnimals;
        private DataGridViewImageColumn colIcon;
        private DataGridViewTextBoxColumn colAgeProgress;
        private DataGridViewTextBoxColumn colProductProgress;
    }
}
