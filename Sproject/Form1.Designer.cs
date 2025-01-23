namespace Sproject
{
    partial class TextTransmitter
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
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PasteFromClipboardButton = new System.Windows.Forms.Button();
            this.CopyToClipboardButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputTextBox
            // 
            this.InputTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InputTextBox.Location = new System.Drawing.Point(149, 12);
            this.InputTextBox.Multiline = true;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(244, 112);
            this.InputTextBox.TabIndex = 0;
            this.InputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            // 
            // OutputLabel
            // 
            this.OutputLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OutputLabel.Location = new System.Drawing.Point(24, 261);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(494, 107);
            this.OutputLabel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "legen";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "overnemen";
            // 
            // PasteFromClipboardButton
            // 
            this.PasteFromClipboardButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasteFromClipboardButton.BackgroundImage = global::Sproject.Properties.Resources.paste;
            this.PasteFromClipboardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PasteFromClipboardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.PasteFromClipboardButton.Location = new System.Drawing.Point(399, 155);
            this.PasteFromClipboardButton.Name = "PasteFromClipboardButton";
            this.PasteFromClipboardButton.Size = new System.Drawing.Size(119, 103);
            this.PasteFromClipboardButton.TabIndex = 7;
            this.PasteFromClipboardButton.UseVisualStyleBackColor = true;
            this.PasteFromClipboardButton.Click += new System.EventHandler(this.PasteFromClipboardButton_Click);
            // 
            // CopyToClipboardButton
            // 
            this.CopyToClipboardButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CopyToClipboardButton.BackgroundImage = global::Sproject.Properties.Resources.copy1;
            this.CopyToClipboardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CopyToClipboardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.CopyToClipboardButton.Location = new System.Drawing.Point(149, 155);
            this.CopyToClipboardButton.Name = "CopyToClipboardButton";
            this.CopyToClipboardButton.Size = new System.Drawing.Size(119, 103);
            this.CopyToClipboardButton.TabIndex = 6;
            this.CopyToClipboardButton.UseVisualStyleBackColor = true;
            this.CopyToClipboardButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CopyButton
            // 
            this.CopyButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CopyButton.BackgroundImage = global::Sproject.Properties.Resources.copy;
            this.CopyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CopyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.CopyButton.Location = new System.Drawing.Point(274, 155);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(119, 103);
            this.CopyButton.TabIndex = 2;
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClearButton.BackgroundImage = global::Sproject.Properties.Resources.trash;
            this.ClearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.ClearButton.Location = new System.Drawing.Point(24, 155);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(119, 103);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "kopiëren";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "plakken";
            // 
            // TextTransmitter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 377);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PasteFromClipboardButton);
            this.Controls.Add(this.CopyToClipboardButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.InputTextBox);
            this.Name = "TextTransmitter";
            this.Text = "Text transmitter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CopyToClipboardButton;
        private System.Windows.Forms.Button PasteFromClipboardButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

