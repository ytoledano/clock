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
            this.label1 = new System.Windows.Forms.Label();
            this._idText = new System.Windows.Forms.TextBox();
            this._makashRB = new System.Windows.Forms.RadioButton();
            this._zifzufRB = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // _test1Btn
            // 
            this._test1Btn.Location = new System.Drawing.Point(12, 42);
            this._test1Btn.Name = "_test1Btn";
            this._test1Btn.Size = new System.Drawing.Size(125, 72);
            this._test1Btn.TabIndex = 1;
            this._test1Btn.Text = "1";
            this._test1Btn.UseVisualStyleBackColor = true;
            this._test1Btn.Click += new System.EventHandler(this._testBtn_Click);
            // 
            // _test2Btn
            // 
            this._test2Btn.Location = new System.Drawing.Point(143, 42);
            this._test2Btn.Name = "_test2Btn";
            this._test2Btn.Size = new System.Drawing.Size(125, 72);
            this._test2Btn.TabIndex = 2;
            this._test2Btn.Text = "2";
            this._test2Btn.UseVisualStyleBackColor = true;
            this._test2Btn.Click += new System.EventHandler(this._testBtn_Click);
            // 
            // _test3Btn
            // 
            this._test3Btn.Location = new System.Drawing.Point(274, 42);
            this._test3Btn.Name = "_test3Btn";
            this._test3Btn.Size = new System.Drawing.Size(125, 72);
            this._test3Btn.TabIndex = 3;
            this._test3Btn.Text = "3";
            this._test3Btn.UseVisualStyleBackColor = true;
            this._test3Btn.Click += new System.EventHandler(this._testBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "מזהה נבדק:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _idText
            // 
            this._idText.Location = new System.Drawing.Point(143, 6);
            this._idText.Name = "_idText";
            this._idText.Size = new System.Drawing.Size(185, 20);
            this._idText.TabIndex = 5;
            // 
            // _makashRB
            // 
            this._makashRB.AutoSize = true;
            this._makashRB.Location = new System.Drawing.Point(72, 7);
            this._makashRB.Name = "_makashRB";
            this._makashRB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this._makashRB.Size = new System.Drawing.Size(48, 17);
            this._makashRB.TabIndex = 6;
            this._makashRB.TabStop = true;
            this._makashRB.Text = "מקש";
            this._makashRB.UseVisualStyleBackColor = true;
            // 
            // _zifzufRB
            // 
            this._zifzufRB.AutoSize = true;
            this._zifzufRB.Location = new System.Drawing.Point(8, 7);
            this._zifzufRB.Name = "_zifzufRB";
            this._zifzufRB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this._zifzufRB.Size = new System.Drawing.Size(58, 17);
            this._zifzufRB.TabIndex = 7;
            this._zifzufRB.TabStop = true;
            this._zifzufRB.Text = "צפצוף";
            this._zifzufRB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 137);
            this.Controls.Add(this._zifzufRB);
            this.Controls.Add(this._makashRB);
            this.Controls.Add(this._idText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._test3Btn);
            this.Controls.Add(this._test2Btn);
            this.Controls.Add(this._test1Btn);
            this.Name = "Form1";
            this.Text = "שעון";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _test1Btn;
        private System.Windows.Forms.Button _test2Btn;
        private System.Windows.Forms.Button _test3Btn;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox _idText;
        public System.Windows.Forms.RadioButton _makashRB;
        public System.Windows.Forms.RadioButton _zifzufRB;

    }
}

