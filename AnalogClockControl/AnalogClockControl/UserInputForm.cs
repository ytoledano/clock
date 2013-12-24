using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AnalogClockControl
{
    public partial class UserInputForm : Form
    {
        public UserInputForm(string question = null)
        {
            InitializeComponent();
            ControlBox = false;
            label1.Text = question ?? "";
            textBox1.Focus();
        }

        protected override void OnActivated(EventArgs e)
        {
            textBox1.Focus();
        }

        private void _okBtn_Click(object sender, EventArgs e)
        {
            int userInput;
            if (int.TryParse(textBox1.Text, out userInput) && userInput >= 0 && userInput < 60)
            {
                UserInput = userInput;
                Close();
                return;
            }
            MessageBox.Show("בבקשה, מספר בין 0 ל-59");
        }

        public int UserInput { get; private set; }
    }
}
