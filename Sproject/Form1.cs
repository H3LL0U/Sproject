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
    public partial class TextTransmitter : Form
    {
        public TextTransmitter()
        {
            InitializeComponent();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            OutputLabel.Text = "";
            InputTextBox.Text = "";
        }

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OutputLabel.Text = InputTextBox.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText(InputTextBox.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PasteFromClipboardButton_Click(object sender, EventArgs e)
        {
            InputTextBox.Text = Clipboard.GetText();
        }
    }
}
