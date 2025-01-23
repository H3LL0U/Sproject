namespace Sproject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButtonGreen = new System.Windows.Forms.RadioButton();
            this.radioButtonBlue = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButtonGreen
            // 
            this.radioButtonGreen.AutoSize = true;
            this.radioButtonGreen.Location = new System.Drawing.Point(133, 96);
            this.radioButtonGreen.Name = "radioButtonGreen";
            this.radioButtonGreen.Size = new System.Drawing.Size(54, 17);
            this.radioButtonGreen.TabIndex = 0;
            this.radioButtonGreen.TabStop = true;
            this.radioButtonGreen.Text = "Groen";
            this.radioButtonGreen.UseVisualStyleBackColor = true;
            this.radioButtonGreen.CheckedChanged += new System.EventHandler(this.radioButtonGreen_CheckedChanged);
            // 
            // radioButtonBlue
            // 
            this.radioButtonBlue.AutoSize = true;
            this.radioButtonBlue.Location = new System.Drawing.Point(133, 119);
            this.radioButtonBlue.Name = "radioButtonBlue";
            this.radioButtonBlue.Size = new System.Drawing.Size(46, 17);
            this.radioButtonBlue.TabIndex = 1;
            this.radioButtonBlue.TabStop = true;
            this.radioButtonBlue.Text = "Blue";
            this.radioButtonBlue.UseVisualStyleBackColor = true;
            this.radioButtonBlue.CheckedChanged += new System.EventHandler(this.radioButtonBlue_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecteer een kleur";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 248);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonBlue);
            this.Controls.Add(this.radioButtonGreen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonGreen;
        private System.Windows.Forms.RadioButton radioButtonBlue;
        private System.Windows.Forms.Label label1;
    }
}

