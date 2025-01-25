using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sproject
{
    public partial class CarTool : Form
    {
        public CarTool()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.DoorsLabel = new System.Windows.Forms.Label();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.MerkTypeLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.SelectButton = new System.Windows.Forms.Button();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.NewPriceField = new System.Windows.Forms.TextBox();
            this.UpdatePriceButton = new System.Windows.Forms.Button();
            this.DeleteCarButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
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
            this.groupBox1.Controls.Add(this.pictureBox);
            this.groupBox1.Controls.Add(this.PriceLabel);
            this.groupBox1.Controls.Add(this.DoorsLabel);
            this.groupBox1.Controls.Add(this.ColorLabel);
            this.groupBox1.Controls.Add(this.MerkTypeLabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 216);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Voorraad";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kleur:";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Vraagprijs:";
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
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(354, 34);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(244, 158);
            this.pictureBox.TabIndex = 11;
            this.pictureBox.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SelectButton);
            this.groupBox2.Controls.Add(this.comboBox7);
            this.groupBox2.Controls.Add(this.comboBox6);
            this.groupBox2.Controls.Add(this.comboBox5);
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(23, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 201);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nieuwe Auto";
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
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(135, 27);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(159, 21);
            this.comboBox2.TabIndex = 21;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(135, 54);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(159, 21);
            this.comboBox3.TabIndex = 22;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(135, 81);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(159, 21);
            this.comboBox4.TabIndex = 23;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(135, 107);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(159, 21);
            this.comboBox5.TabIndex = 24;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(135, 134);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(159, 21);
            this.comboBox6.TabIndex = 25;
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(135, 161);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(77, 21);
            this.comboBox7.TabIndex = 26;
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(218, 159);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(76, 23);
            this.SelectButton.TabIndex = 27;
            this.SelectButton.Text = "Selecteer...";
            this.SelectButton.UseVisualStyleBackColor = true;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.DeleteCarButton);
            this.GroupBox3.Controls.Add(this.UpdatePriceButton);
            this.GroupBox3.Controls.Add(this.NewPriceField);
            this.GroupBox3.Controls.Add(this.Label6);
            this.GroupBox3.Location = new System.Drawing.Point(377, 245);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(274, 201);
            this.GroupBox3.TabIndex = 4;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Wijzingen";
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
            // NewPriceField
            // 
            this.NewPriceField.Location = new System.Drawing.Point(82, 30);
            this.NewPriceField.Name = "NewPriceField";
            this.NewPriceField.Size = new System.Drawing.Size(146, 20);
            this.NewPriceField.TabIndex = 1;
            // 
            // UpdatePriceButton
            // 
            this.UpdatePriceButton.Location = new System.Drawing.Point(82, 57);
            this.UpdatePriceButton.Name = "UpdatePriceButton";
            this.UpdatePriceButton.Size = new System.Drawing.Size(146, 23);
            this.UpdatePriceButton.TabIndex = 2;
            this.UpdatePriceButton.Text = "Update vraagprijs";
            this.UpdatePriceButton.UseVisualStyleBackColor = true;
            // 
            // DeleteCarButton
            // 
            this.DeleteCarButton.Location = new System.Drawing.Point(22, 159);
            this.DeleteCarButton.Name = "DeleteCarButton";
            this.DeleteCarButton.Size = new System.Drawing.Size(206, 23);
            this.DeleteCarButton.TabIndex = 3;
            this.DeleteCarButton.Text = "Verwijder geselecteerde auto";
            this.DeleteCarButton.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
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
    }
}
