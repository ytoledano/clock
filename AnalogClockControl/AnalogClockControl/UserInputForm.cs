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
        public UserInputForm(string question = null, bool displayLeftRight = false)
        {
            InitializeComponent();
            ControlBox = false;
            label1.Text = question ?? "";
            if (displayLeftRight)
            {
                _leftBtn.Visible = _rightBtn.Visible = true;
                _retryBtn.Visible = textBox1.Visible = _okBtn.Visible = false;
            }
            else
            {
                textBox1.Focus();
            }
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

        private void SideBtnClick(object sender, EventArgs e)
        {
            UserInput = ((Button) sender).Name == "_leftBtn" ? 1 : -1;
            Close();
        }

        private void _retryBtn_Click(object sender, EventArgs e)
        {
            UserInput = -1;
            Close();
        }

        public int UserInput { get; private set; }
    }
}
