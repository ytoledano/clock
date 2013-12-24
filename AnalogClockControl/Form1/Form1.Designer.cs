namespace Form1
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
            this._test1Btn = new System.Windows.Forms.Button();
            this._test2Btn = new System.Windows.Forms.Button();
            this._test3Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _test1Btn
            // 
            this._test1Btn.Location = new System.Drawing.Point(12, 12);
            this._test1Btn.Name = "_test1Btn";
            this._test1Btn.Size = new System.Drawing.Size(125, 72);
            this._test1Btn.TabIndex = 1;
            this._test1Btn.Text = "1";
            this._test1Btn.UseVisualStyleBackColor = true;
            this._test1Btn.Click += new System.EventHandler(this._testBtn_Click);
            // 
            // _test2Btn
            // 
            this._test2Btn.Location = new System.Drawing.Point(143, 12);
            this._test2Btn.Name = "_test2Btn";
            this._test2Btn.Size = new System.Drawing.Size(125, 72);
            this._test2Btn.TabIndex = 2;
            this._test2Btn.Text = "2";
            this._test2Btn.UseVisualStyleBackColor = true;
            this._test2Btn.Click += new System.EventHandler(this._testBtn_Click);
            // 
            // _test3Btn
            // 
            this._test3Btn.Location = new System.Drawing.Point(274, 12);
            this._test3Btn.Name = "_test3Btn";
            this._test3Btn.Size = new System.Drawing.Size(125, 72);
            this._test3Btn.TabIndex = 3;
            this._test3Btn.Text = "3";
            this._test3Btn.UseVisualStyleBackColor = true;
            this._test3Btn.Click += new System.EventHandler(this._testBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 93);
            this.Controls.Add(this._test3Btn);
            this.Controls.Add(this._test2Btn);
            this.Controls.Add(this._test1Btn);
            this.Name = "MainForm";
            this.Text = "שעון";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _test1Btn;
        private System.Windows.Forms.Button _test2Btn;
        private System.Windows.Forms.Button _test3Btn;

    }
}

