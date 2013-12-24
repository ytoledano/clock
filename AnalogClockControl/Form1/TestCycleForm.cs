using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnalogClockControl;

namespace Form1
{
    public partial class TestCycleForm : Form
    {

        public TestCycleForm()
        {
            InitializeComponent();
        }

        public TestCycleForm(int testNum)
            : this()
        {
            _testNum = testNum;
            Text = "שעון " + testNum;
            _testCount = _testNum == 1 ? 3 : 50;

        }

        protected override void OnLoad(EventArgs e)
        {
            _countLabel.Text = (_i + 1).ToString();
            AnalogClock clockControl = new AnalogClock(_testNum);
            _clockGroup.Controls.Add(clockControl);
            clockControl.Dock = DockStyle.Fill;
            clockControl.OnTestComplete += OnTestComplete;
            clockControl.BeReady();
        }

        private void OnTestComplete(int userInput)
        {
            _i++;
            _countLabel.Text = (_i + 1).ToString();
            foreach (var c in _clockGroup.Controls)
            {
                ((AnalogClock)c).OnTestComplete -= OnTestComplete;

            }
            _clockGroup.Controls.Clear();
            if (_i >= _testCount)
            {
                MessageBox.Show("סיימת את שלב " + _testNum);
                Close();
                return;
            }
            AnalogClock clockControl = new AnalogClock(_testNum);
            _clockGroup.Controls.Add(clockControl);
            clockControl.Dock = DockStyle.Fill;
            clockControl.OnTestComplete += OnTestComplete;
            clockControl.BeReady();
            clockControl.Focus();
        }



        private int _i;
        private readonly int _testNum;
        int _testCount;
    }
}
