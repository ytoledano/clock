using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace AnalogClockControl
{
    /// <summary>
    /// Control name: Analog Clock Control
    /// Description: A customizable and resizable clock control
    /// Developed by: Syed Mehroz Alam
    /// Email: smehrozalam@yahoo.com
    /// URL: Programming Home "http://www.geocities.com/smehrozalam/"
    /// </summary>
    public class AnalogClock : UserControl
    {

        private System.ComponentModel.IContainer components;

        public AnalogClock(int testNum)
        {
            _testNum = testNum;
            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();

            // TODO: Add any initialization after the InitializeComponent call
            DoubleBuffered = true;
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._timer1 = new System.Windows.Forms.Timer(this.components);
            // 
            // timer1
            // 
            this._timer1.Enabled = false;
            this._timer1.Interval = 22;
            this._timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AnalogClock
            // 
            this.Name = "AnalogClock";
            this.Resize += new System.EventHandler(this.AnalogClock_Resize);
            this.Load += new System.EventHandler(this.AnalogClock_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AnalogClock_Paint);
            this.KeyPress += OnKeyPress;
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        private void OnKeyPress(object sender, KeyPressEventArgs keyPressEventArgs)
        {
            switch (keyPressEventArgs.KeyChar)
            {
                case '4':
                    if (!_timer1.Enabled)
                        Start();
                    break;

            }
        }

        #endregion

        private double MSSinceBeg()
        {
            return (DateTime.UtcNow - _startTime).TotalMilliseconds;
        }

        private void AnalogClock_Load(object sender, EventArgs e)
        {
            AnalogClock_Resize(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
            if (!_isPlayedSound && MSSinceBeg() > MS_TO_SOUND)
            {
                ThreadPool.QueueUserWorkItem(o => Console.Beep(_random.NextDouble() > 0.5 ? SOUND_1_HZ : SOUND_2_HZ, 100));
                _soundPlayedMS = MSSinceBeg();
                double beepRad = (_soundPlayedMS/CYCLE_MS)*2*PI + _needleOffset;
                _beepSecs = (60 * beepRad / (2 * PI)) % 60;
                _isPlayedSound = true;
            }
            if (_isPlayedSound && MSSinceBeg() > _soundPlayedMS + MS_AFTER_SOUND)
            {
                Stop();
                var userInputFurm = new UserInputForm("שמעתי את הצפצוף כשהמחוג היה ב (0-59):");
                userInputFurm.ShowDialog();
                int userInput = userInputFurm.UserInput;
                OnTestComplete(userInput,_beepSecs);
            }
        }

        public void BeReady()
        {
            _isFirst = true;
            Refresh();
        }

        public void Start()
        {
            _startTime = DateTime.UtcNow;
            _timer1.Enabled = true;
            Refresh();
        }

        public void Stop()
        {
            _timer1.Enabled = false;
        }

        private void DrawLine(double fThickness, double fLength, Color color, double fRadians, PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(color, (float)fThickness),
                (float)(_fCenterX - fLength / 9 * Math.Sin(fRadians)),
               (float)(_fCenterY + fLength / 9 * Math.Cos(fRadians)),
               (float)(_fCenterX + fLength * Math.Sin(fRadians)),
               (float)(_fCenterY - fLength * Math.Cos(fRadians)));
        }

        private void DrawPolygon(double fThickness, double fLength, Color color, double fRadians, PaintEventArgs e)
        {

            PointF A = new PointF((float)(_fCenterX + fThickness * 2 * Math.Sin(fRadians + PI / 2)),
                (float)(_fCenterY - fThickness * 2 * Math.Cos(fRadians + PI / 2)));
            PointF B = new PointF((float)(_fCenterX + fThickness * 2 * Math.Sin(fRadians - PI / 2)),
                (float)(_fCenterY - fThickness * 2 * Math.Cos(fRadians - PI / 2)));
            PointF C = new PointF((float)(_fCenterX + fLength * Math.Sin(fRadians)),
                (float)(_fCenterY - fLength * Math.Cos(fRadians)));
            PointF D = new PointF((float)(_fCenterX - fThickness * 4 * Math.Sin(fRadians)),
                (float)(_fCenterY + fThickness * 4 * Math.Cos(fRadians)));
            PointF[] points = { A, D, B, C };
            e.Graphics.FillPolygon(new SolidBrush(color), points);
        }

        private void AnalogClock_Paint(object sender, PaintEventArgs e)
        {
            double ms = MSSinceBeg();
            if (_startTime == default(DateTime))
                ms = 0;
            double fRadHr = (ms / CYCLE_MS) * 2 * PI + _needleOffset;
            e.Graphics.FillEllipse(new SolidBrush(Color.White), (float)(_fCenterX - _fCenterCircleRadius / 2), (float)(_fCenterY - _fCenterCircleRadius / 2),
                (float)_fCenterCircleRadius, (float)_fCenterCircleRadius);
            DrawPolygon(_fHourThickness, _fHourLength, _hrColor, fRadHr, e);
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            e.Graphics.FillPolygon(new SolidBrush(Color.White), new[] { new PointF(0, 0), new PointF(Width, 0), new PointF(Width, Height) });
            e.Graphics.FillPolygon(new SolidBrush(Color.White), new[] { new PointF(0, 0), new PointF(0, Height), new PointF(Width, Height) });
            if (_isFirst)
                Controls.Clear();
            for (int i = 0; i < 60; i++)
            {
                if (i % 5 == 0) // Draw 5 minute ticks
                {
                    e.Graphics.DrawLine(new Pen(_ticksColor, (float)F_TICKS_THICKNESS),
                        (float)_fCenterX + (float)(_fRadius / 1.50F * Math.Sin(i * 6 * PI / 180)),
                        (float)_fCenterY - (float)(_fRadius / 1.50F * Math.Cos(i * 6 * PI / 180)),
                        (float)_fCenterX + (float)(_fRadius / 1.65F * Math.Sin(i * 6 * PI / 180)),
                        (float)_fCenterY - (float)(_fRadius / 1.65F * Math.Cos(i * 6 * PI / 180)));
                    if (_isFirst)
                    {
                        var label = new Label
                        {
                            Text = i.ToString(),
                            BackColor = Color.White,
                            Name = "label" + i,
                            Location =
                                new Point((int)(_fCenterX + (float)(_fRadius / 1.40F * Math.Sin(i * 6 * PI / 180))) - 5,
                                    (int)((float)_fCenterY - (float)(_fRadius / 1.40F * Math.Cos(i * 6 * PI / 180))) - 5),
                            AutoSize = true,
                        };
                        Controls.Add(label);
                    }
                }
            }
            _isFirst = false;
        }

        private void AnalogClock_Resize(object sender, EventArgs e)
        {
            Width = Height;
            _fRadius = (double)Height / 2;
            _fCenterX = (double)ClientSize.Width / 2;
            _fCenterY = (double)ClientSize.Height / 2;
            _fHourLength = (double)Height / 3 / 1.65F;
            _fHourThickness = (double)Height / 100;
            _fCenterCircleRadius = (double)Height / 2;
            Refresh();
        }

        private static double GetRandomInRange(double beg, double end)
        {
            double offset = _random.NextDouble() * (end - beg);
            return beg + offset;
        }

        private bool _isFirst = true;
        private const double CYCLE_MS = 5120;
        private static readonly Random _random = new Random();
        private readonly double _needleOffset = GetRandomInRange(0, 2 * PI);
        private const int SOUND_1_HZ = 440;
        private const int SOUND_2_HZ = 1500;
        private bool _isPlayedSound;
        private readonly int MS_TO_SOUND = (int)GetRandomInRange(750, 5120);
        private readonly int MS_AFTER_SOUND = (int)GetRandomInRange(1500, 2500);

        private readonly int _testNum;
        const double PI = Math.PI;

        private DateTime _startTime;

        double _fRadius;
        double _fCenterX;
        double _fCenterY;
        double _fCenterCircleRadius;

        double _fHourLength;

        double _fHourThickness;

        private const double F_TICKS_THICKNESS = 1;

        readonly Color _hrColor = Color.DarkMagenta;
        readonly Color _ticksColor = Color.Black;

        private Timer _timer1;
        private double _soundPlayedMS;
        private double _beepSecs;

        public delegate void TestCompleteDel(int userInput, double beepSecs);
        public event TestCompleteDel OnTestComplete;
    }
}
