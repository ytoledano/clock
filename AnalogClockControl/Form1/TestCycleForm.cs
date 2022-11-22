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
using System.IO;
using Clock;

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
            _testCount = _testNum == 1 ? 15 : 15;

        }

        protected override void OnLoad(EventArgs e)
        {
            _countLabel.Text = (_i + 1).ToString();
            AnalogClock clockControl = new AnalogClock(_testNum, true, Form1.Form._zifzufRB.Checked);
            _clockGroup.Controls.Add(clockControl);
            clockControl.Dock = DockStyle.Fill;
            clockControl.OnTestComplete += OnTestComplete;
            clockControl.BeReady();
        }

        private void OnTestComplete(int userInputSecs, double beepSecs, string sideClicked, double secsClicked, string inhibition, int soundHz, double beepSecsBefore)
        {
            if (userInputSecs != -1)
            {
                LogResult(_testNum, _i, userInputSecs, beepSecs, sideClicked, secsClicked, inhibition, soundHz, beepSecsBefore);
                _i++;
            }
            _countLabel.Text = (_i + 1).ToString();
            foreach (var c in _clockGroup.Controls)
                ((AnalogClock) c).OnTestComplete -= OnTestComplete;
            _clockGroup.Controls.Clear();
            if (_i >= _testCount)
            {
                //MessageBox.Show("סיימת את שלב " + _testNum);
                (new EndOfCycleDialog(_testNum)).ShowDialog();
                Close();
                return;
            }
            AnalogClock clockControl = new AnalogClock(_testNum, false, Form1.Form._zifzufRB.Checked);
            _clockGroup.Controls.Add(clockControl);
            clockControl.Dock = DockStyle.Fill;
            clockControl.OnTestComplete += OnTestComplete;
            clockControl.BeReady();
            clockControl.Focus();
        }

        public static void LogResult(int testNum, int gameNum, int userInputSecs, double beepSecs, string sideClicked, double secsClicked, string inhibition, int soundHz, double beepSecsBefore)
        {
            FileInfo file = new FileInfo("output.csv");
            if (!file.Exists)
                File.WriteAllText(file.FullName, "Subject ID,Time,Cycle Num,Test Num,User Secs,Beep Secs,Side Clicked,Inhibition,Clicked Secs,Sound HZ,Beep Secs Before,Question 2\r\n");
            File.AppendAllText(file.FullName,
                string.Format("{0},{1},{2},{3},{4},{5:n2},\"{6}\",\"{7}\",{8:n2},{9},{10:n2},{11}\r\n", Form1.Form._idText.Text, DateTime.Now, testNum, gameNum + 1,
                userInputSecs, beepSecs, sideClicked, inhibition, secsClicked, soundHz,beepSecsBefore, Form1.Form._zifzufRB.Checked ? "Zifzuf" : "Makash"));
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            foreach(Control control in _clockGroup.Controls)
                control.Dispose();
        }

        private int _i;
        private readonly int _testNum;
        readonly int _testCount;
    }
}
