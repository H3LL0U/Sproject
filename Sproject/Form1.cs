using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
namespace Sproject
{


    public partial class CarTool : Form
    {
        List<Car> all_cars;





        
        private void updateCombobox(ComboBox comboBox,List<Car> new_items)
        {
            comboBox.Items.Clear();
            foreach (var car in new_items)
            {
                comboBox.Items.Add(car.geefNaam());
                

            }
            comboBox1_SelectedIndexChanged(new Object(), new EventArgs());
        }
        private void clearCarList()
        {
            
            var file_path = "./voorraad.txt";
            if (!(File.Exists(file_path)))
            {
                File.Create(file_path);
                return;
            }
            File.WriteAllText(file_path, "");

        }
        private List<Car> replaceCars(List<Car> new_all_cars)
        {
            clearCarList();
            foreach (Car car in new_all_cars)
            {
                AddCarToFile(car);
            }
            return new_all_cars;
        }
        private List<Car> deleteSelectedCar(List<Car> cars, Car car_to_remove)
        {
            clearCarList();
            cars.Remove(car_to_remove);
            foreach (var car in cars) { 
            
            AddCarToFile(car);
            
            }
            return cars;
        }
        private List<Car> getAllCars()
        {

            var cars = new List<Car>();
            var file_path = "./voorraad.txt";
            if (!(File.Exists(file_path))){
                File.Create(file_path);
                return cars;
            }
            var carsInfoFileContents = File.ReadAllText(file_path).Split('\n');

            foreach (var car in carsInfoFileContents)

            {
                if (car != "")
                {
                    
                    //default values for reading 
                    var price = 999999999.0;
                    var color = string.Empty;
                    var merk = string.Empty;
                    var type = string.Empty;
                    var doors = 4;
                    var picture = string.Empty;
                    var car_parameters = car.Split(';');
                    foreach (var param in car_parameters)
                    {
                        if (param.StartsWith("Merk="))
                        {
                            merk = param.Substring("Merk=".Length);
                        }
                        else if (param.StartsWith("Color="))
                        {
                            color = param.Substring("Color=".Length);
                        }
                        else if (param.StartsWith("Type="))
                        {
                            type = param.Substring("Type=".Length);
                        }
                        else if (param.StartsWith("Price="))
                        {
                            price = double.Parse(param.Substring("Price=".Length));

                        }
                        else if (param.StartsWith("Doors="))
                        {
                            doors = int.Parse(param.Substring("Doors=".Length));

                        }
                        else if (param.StartsWith("Picture="))
                        {
                            picture = param.Substring("Picture=".Length);

                        }




                    }
                    var carObject = new Car(price, color, merk, type, doors, picture);
                    cars.Add(carObject);
                }
            }

            


            return cars;
        }
        private void AddCarToFile(Car car)
        {
            
            var carLine = $"Merk={car.merk};Color={car.color};Type={car.type};Price={car.price};Doors={car.doors};Picture={car.picture}";

            
            File.AppendAllText("./voorraad.txt", carLine + Environment.NewLine);
        }
        public CarTool()
        {
            InitializeComponent();
            this.all_cars = getAllCars();
            //add cars saved in the text file to the combobox initially
            updateCombobox(VoorraadCombobox, all_cars);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CarPictureBox = new System.Windows.Forms.PictureBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.DoorsLabel = new System.Windows.Forms.Label();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.MerkTypeLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VoorraadCombobox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SelectImageButton = new System.Windows.Forms.Button();
            this.PictureComboBox = new System.Windows.Forms.ComboBox();
            this.PriceComboBox = new System.Windows.Forms.ComboBox();
            this.DoorsComboBox = new System.Windows.Forms.ComboBox();
            this.ColorComboBox = new System.Windows.Forms.ComboBox();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.MerkComboBox = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.DeleteCarButton = new System.Windows.Forms.Button();
            this.UpdatePriceButton = new System.Windows.Forms.Button();
            this.NewPriceField = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.SaveCarButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarPictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecteer een auto:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CarPictureBox);
            this.groupBox1.Controls.Add(this.PriceLabel);
            this.groupBox1.Controls.Add(this.DoorsLabel);
            this.groupBox1.Controls.Add(this.ColorLabel);
            this.groupBox1.Controls.Add(this.MerkTypeLabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.VoorraadCombobox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 216);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Voorraad";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CarPictureBox
            // 
            this.CarPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CarPictureBox.Location = new System.Drawing.Point(354, 19);
            this.CarPictureBox.Name = "CarPictureBox";
            this.CarPictureBox.Size = new System.Drawing.Size(173, 173);
            this.CarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CarPictureBox.TabIndex = 11;
            this.CarPictureBox.TabStop = false;
            this.CarPictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(109, 161);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(0, 13);
            this.PriceLabel.TabIndex = 10;
            // 
            // DoorsLabel
            // 
            this.DoorsLabel.AutoSize = true;
            this.DoorsLabel.Location = new System.Drawing.Point(109, 136);
            this.DoorsLabel.Name = "DoorsLabel";
            this.DoorsLabel.Size = new System.Drawing.Size(0, 13);
            this.DoorsLabel.TabIndex = 9;
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(109, 110);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(0, 13);
            this.ColorLabel.TabIndex = 8;
            // 
            // MerkTypeLabel
            // 
            this.MerkTypeLabel.AutoSize = true;
            this.MerkTypeLabel.Location = new System.Drawing.Point(109, 87);
            this.MerkTypeLabel.Name = "MerkTypeLabel";
            this.MerkTypeLabel.Size = new System.Drawing.Size(0, 13);
            this.MerkTypeLabel.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Vraagprijs:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Aantal Deuren:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kleur:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Merk en type:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // VoorraadCombobox
            // 
            this.VoorraadCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VoorraadCombobox.FormattingEnabled = true;
            this.VoorraadCombobox.Location = new System.Drawing.Point(22, 51);
            this.VoorraadCombobox.Name = "VoorraadCombobox";
            this.VoorraadCombobox.Size = new System.Drawing.Size(121, 21);
            this.VoorraadCombobox.TabIndex = 2;
            this.VoorraadCombobox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SaveCarButton);
            this.groupBox2.Controls.Add(this.SelectImageButton);
            this.groupBox2.Controls.Add(this.PictureComboBox);
            this.groupBox2.Controls.Add(this.PriceComboBox);
            this.groupBox2.Controls.Add(this.DoorsComboBox);
            this.groupBox2.Controls.Add(this.ColorComboBox);
            this.groupBox2.Controls.Add(this.TypeComboBox);
            this.groupBox2.Controls.Add(this.MerkComboBox);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(23, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 237);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nieuwe Auto";
            // 
            // SelectImageButton
            // 
            this.SelectImageButton.Location = new System.Drawing.Point(218, 159);
            this.SelectImageButton.Name = "SelectImageButton";
            this.SelectImageButton.Size = new System.Drawing.Size(76, 23);
            this.SelectImageButton.TabIndex = 27;
            this.SelectImageButton.Text = "Selecteer...";
            this.SelectImageButton.UseVisualStyleBackColor = true;
            this.SelectImageButton.Click += new System.EventHandler(this.SelectImageButton_Click);
            // 
            // PictureComboBox
            // 
            this.PictureComboBox.FormattingEnabled = true;
            this.PictureComboBox.Location = new System.Drawing.Point(135, 161);
            this.PictureComboBox.Name = "PictureComboBox";
            this.PictureComboBox.Size = new System.Drawing.Size(77, 21);
            this.PictureComboBox.TabIndex = 26;
            // 
            // PriceComboBox
            // 
            this.PriceComboBox.FormattingEnabled = true;
            this.PriceComboBox.Location = new System.Drawing.Point(135, 134);
            this.PriceComboBox.Name = "PriceComboBox";
            this.PriceComboBox.Size = new System.Drawing.Size(159, 21);
            this.PriceComboBox.TabIndex = 25;
            // 
            // DoorsComboBox
            // 
            this.DoorsComboBox.FormattingEnabled = true;
            this.DoorsComboBox.Location = new System.Drawing.Point(135, 107);
            this.DoorsComboBox.Name = "DoorsComboBox";
            this.DoorsComboBox.Size = new System.Drawing.Size(159, 21);
            this.DoorsComboBox.TabIndex = 24;
            this.DoorsComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // ColorComboBox
            // 
            this.ColorComboBox.FormattingEnabled = true;
            this.ColorComboBox.Location = new System.Drawing.Point(135, 81);
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.Size = new System.Drawing.Size(159, 21);
            this.ColorComboBox.TabIndex = 23;
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(135, 54);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(159, 21);
            this.TypeComboBox.TabIndex = 22;
            // 
            // MerkComboBox
            // 
            this.MerkComboBox.FormattingEnabled = true;
            this.MerkComboBox.Location = new System.Drawing.Point(135, 27);
            this.MerkComboBox.Name = "MerkComboBox";
            this.MerkComboBox.Size = new System.Drawing.Size(159, 21);
            this.MerkComboBox.TabIndex = 21;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(22, 164);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 13);
            this.label20.TabIndex = 20;
            this.label20.Text = "Afbeelding";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(22, 137);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 13);
            this.label21.TabIndex = 19;
            this.label21.Text = "Vraagprijs:";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Aantal Deuren";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Kleur:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Type:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Merk:";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.DeleteCarButton);
            this.GroupBox3.Controls.Add(this.UpdatePriceButton);
            this.GroupBox3.Controls.Add(this.NewPriceField);
            this.GroupBox3.Controls.Add(this.Label6);
            this.GroupBox3.Location = new System.Drawing.Point(377, 245);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(274, 237);
            this.GroupBox3.TabIndex = 4;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Wijzingen";
            // 
            // DeleteCarButton
            // 
            this.DeleteCarButton.Location = new System.Drawing.Point(38, 208);
            this.DeleteCarButton.Name = "DeleteCarButton";
            this.DeleteCarButton.Size = new System.Drawing.Size(206, 23);
            this.DeleteCarButton.TabIndex = 3;
            this.DeleteCarButton.Text = "Verwijder geselecteerde auto";
            this.DeleteCarButton.UseVisualStyleBackColor = true;
            this.DeleteCarButton.Click += new System.EventHandler(this.DeleteCarButton_Click);
            // 
            // UpdatePriceButton
            // 
            this.UpdatePriceButton.Location = new System.Drawing.Point(82, 57);
            this.UpdatePriceButton.Name = "UpdatePriceButton";
            this.UpdatePriceButton.Size = new System.Drawing.Size(146, 23);
            this.UpdatePriceButton.TabIndex = 2;
            this.UpdatePriceButton.Text = "Update vraagprijs";
            this.UpdatePriceButton.UseVisualStyleBackColor = true;
            this.UpdatePriceButton.Click += new System.EventHandler(this.UpdatePriceButton_Click);
            // 
            // NewPriceField
            // 
            this.NewPriceField.Location = new System.Drawing.Point(82, 30);
            this.NewPriceField.Name = "NewPriceField";
            this.NewPriceField.Size = new System.Drawing.Size(146, 20);
            this.NewPriceField.TabIndex = 1;
            this.NewPriceField.TextChanged += new System.EventHandler(this.NewPriceField_TextChanged);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(19, 30);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(56, 13);
            this.Label6.TabIndex = 0;
            this.Label6.Text = "Vraagprijs:";
            // 
            // SaveCarButton
            // 
            this.SaveCarButton.Location = new System.Drawing.Point(25, 208);
            this.SaveCarButton.Name = "SaveCarButton";
            this.SaveCarButton.Size = new System.Drawing.Size(269, 23);
            this.SaveCarButton.TabIndex = 28;
            this.SaveCarButton.Text = "Toevoegen";
            this.SaveCarButton.UseVisualStyleBackColor = true;
            this.SaveCarButton.Click += new System.EventHandler(this.SaveCarButton_Click);
            // 
            // CarTool
            // 
            this.ClientSize = new System.Drawing.Size(686, 494);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CarTool";
            this.Text = "AutoGarage";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarPictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected_car = VoorraadCombobox.Text;
            foreach (Car car in all_cars)
            {
                if (car.geefNaam() == selected_car)
                {
                    MerkTypeLabel.Text = car.ToString();
                    ColorLabel.Text = car.color;
                    DoorsLabel.Text = car.doors.ToString();
                    PriceLabel.Text = car.price.ToString();
                    if (car.heeftAfbeelding() && File.Exists(car.picture))
                    {
                        CarPictureBox.Image = null;
                        CarPictureBox.Image = Image.FromFile(car.picture);
                    }
                    else
                    {

                        CarPictureBox.Image = null;
                    }
                }




            }
        }

        void SaveCarButton_Click(object sender, EventArgs e)
        {
            // Get values from ComboBoxes
            var price = PriceComboBox.Text;
            var color = ColorComboBox.Text;
            var merk = MerkComboBox.Text;
            var type = TypeComboBox.Text;
            var doors = DoorsComboBox.Text;
            var picture = PictureComboBox.Text;

            // Validation checks
            if (string.IsNullOrWhiteSpace(price) ||
                string.IsNullOrWhiteSpace(color) ||
                string.IsNullOrWhiteSpace(merk) ||
                string.IsNullOrWhiteSpace(type) ||
                string.IsNullOrWhiteSpace(doors))
            {
                MessageBox.Show("Alle felden moeten iets bevatten.", "Validatie fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            if (!double.TryParse(price, out var parsedPrice))
            {
                MessageBox.Show("De prijs moet een cijfer zijn", "Validatie fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            if (!int.TryParse(doors, out var parsedDoors))
            {
                MessageBox.Show("Deuren moeten een cijver zijn", "Validatie fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (price.Contains(";") || price.Contains(",") ||
                color.Contains(";") || color.Contains(",") ||
                merk.Contains(";") || merk.Contains(",") ||
                type.Contains(";") || type.Contains(",") ||
                doors.Contains(";") || doors.Contains(","))
            {
                MessageBox.Show("Velden mogen geen ';' of ',' bevatten.", "Validatie fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var new_car = new Car(parsedPrice, color,merk,type,parsedDoors,picture);
            AddCarToFile(new_car);
            all_cars.Add(new_car);
            updateCombobox(VoorraadCombobox, all_cars);
            MessageBox.Show("Nieuwe auto toegevoegd", "Validatie gekeurd", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void SelectImageButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                // Show the dialog and check if the user selected a file
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    string selectedFilePath = openFileDialog.FileName;
                    PictureComboBox.Text = selectedFilePath;
                }

            }

        }

        private void DeleteCarButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ben je zeker dat je de auto wil verwijderen?",
                                                  "Confirmatie",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            foreach (var car in all_cars) {
                if (VoorraadCombobox.Text == car.geefNaam())
                {
                    all_cars = deleteSelectedCar(all_cars,car);

                    
                    VoorraadCombobox.Text = null;
                    updateCombobox(VoorraadCombobox, all_cars);
                    
                    return;
                }
            }
        }

        private void NewPriceField_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdatePriceButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(NewPriceField.Text, out var parsedPrice))
            {
                foreach (var car in all_cars)
                {
                    if (car.geefNaam() == VoorraadCombobox.Text)
                    {
                        car.updateVraagprijs(parsedPrice);
                    }
                    replaceCars(all_cars);
                    comboBox1_SelectedIndexChanged(new Object(), new EventArgs());


                }
            }
            else
            {
                MessageBox.Show("Prijs moet een cijfer zijn", "Validatie fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
