using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Form1;

namespace Clock
{
    public partial class EndOfCycleDialog : Form
    {
        private readonly int _testNum;

        public EndOfCycleDialog()
        {
            InitializeComponent();
        }

        public EndOfCycleDialog(int testNum) : this()
        {
            _testNum = testNum;
            switch (_testNum)
            {
                case 1:
                case 2:
                    _questionLabel.Text = @"באיזו מידה הרגשת שאת/ה זה/ו שיצרת את הצלילים?
דרג\י בין 1 (כלל לא) לבין 8 (במידה רבה מאוד)";
                    break;
                case 3:
                    _questionLabel.Text = @"במקרים בהם לחצת על מקש ימין/שמאל, באיזו מידה הרגשת
שאת/ה זה/ו שיצרת את הצלילים?
דרג/י בין 1 (כלל לא) לבין 8 (במידה רבה מאוד)";
                    break;
                case -3:
                    _questionLabel.Text = @"במקרים בהם לא לחצת על מקש כלל, באיזו מידה הרגשת
שאת/ה זה/ו שיצרת את הצלילים?
דרג/י בין 1 (כלל לא) לבין 8 (במידה רבה מאוד)";
                    break;
            }
        }

        private void _okBtn_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            int num;
            if (int.TryParse(text, out num) && num >= 1 && num <= 8)
            {
                TestCycleForm.LogResult(_testNum,-1,num,0,"",0,"",0,0);

                if (_testNum == 3)
                {
                    Hide();
                    (new EndOfCycleDialog(-3)).ShowDialog();
                }
                Close();
            }
            else
            {
                MessageBox.Show("נא הכנס/י מספר בין 1 ל-8");
            }
        }
    }
}
