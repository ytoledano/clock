using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
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
            Regex regex = new Regex(@"\((\d+)\-(\d+)\)");
            var match = regex.Match(question??"");
            if (match.Success)
            {
                _lowRange = int.Parse(match.Groups[1].Value);
                _highRange = int.Parse(match.Groups[2].Value);
            }
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
            if (int.TryParse(textBox1.Text, out userInput) && userInput >= _lowRange && userInput <= _highRange)
            {
                UserInput = userInput;
                Close();
                return;
            }
            MessageBox.Show(string.Format("בבקשה, מספר בין {0} ל-{1}",_lowRange,_highRange));
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
        private readonly int _lowRange,_highRange;
    }
}
