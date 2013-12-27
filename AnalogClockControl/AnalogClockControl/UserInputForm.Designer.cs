namespace AnalogClockControl
{
    partial class UserInputForm
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
            this._okBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._rightBtn = new System.Windows.Forms.Button();
            this._leftBtn = new System.Windows.Forms.Button();
            this._retryBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _okBtn
            // 
            this._okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._okBtn.Location = new System.Drawing.Point(168, 74);
            this._okBtn.Name = "_okBtn";
            this._okBtn.Size = new System.Drawing.Size(75, 23);
            this._okBtn.TabIndex = 0;
            this._okBtn.Text = "אשר";
            this._okBtn.UseVisualStyleBackColor = true;
            this._okBtn.Click += new System.EventHandler(this._okBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(143, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(231, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "המחוג עצר ב (0-59):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _rightBtn
            // 
            this._rightBtn.Location = new System.Drawing.Point(168, 74);
            this._rightBtn.Name = "_rightBtn";
            this._rightBtn.Size = new System.Drawing.Size(75, 23);
            this._rightBtn.TabIndex = 3;
            this._rightBtn.Text = "ימין";
            this._rightBtn.UseVisualStyleBackColor = true;
            this._rightBtn.Visible = false;
            this._rightBtn.Click += new System.EventHandler(this.SideBtnClick);
            // 
            // _leftBtn
            // 
            this._leftBtn.Location = new System.Drawing.Point(87, 74);
            this._leftBtn.Name = "_leftBtn";
            this._leftBtn.Size = new System.Drawing.Size(75, 23);
            this._leftBtn.TabIndex = 4;
            this._leftBtn.Text = "שמאל";
            this._leftBtn.UseVisualStyleBackColor = true;
            this._leftBtn.Visible = false;
            this._leftBtn.Click += new System.EventHandler(this.SideBtnClick);
            // 
            // _retryBtn
            // 
            this._retryBtn.Location = new System.Drawing.Point(37, 74);
            this._retryBtn.Name = "_retryBtn";
            this._retryBtn.Size = new System.Drawing.Size(125, 23);
            this._retryBtn.TabIndex = 5;
            this._retryBtn.Text = "אופס, נסה/י שוב";
            this._retryBtn.UseVisualStyleBackColor = true;
            this._retryBtn.Click += new System.EventHandler(this._retryBtn_Click);
            // 
            // UserInputForm
            // 
            this.AcceptButton = this._okBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 113);
            this.Controls.Add(this._retryBtn);
            this.Controls.Add(this._leftBtn);
            this.Controls.Add(this._rightBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this._okBtn);
            this.Name = "UserInputForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _okBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _rightBtn;
        private System.Windows.Forms.Button _leftBtn;
        private System.Windows.Forms.Button _retryBtn;
    }
}