namespace Clock
{
    partial class EndOfCycleDialog
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
            this._questionLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _okBtn
            // 
            this._okBtn.Location = new System.Drawing.Point(261, 92);
            this._okBtn.Name = "_okBtn";
            this._okBtn.Size = new System.Drawing.Size(75, 23);
            this._okBtn.TabIndex = 2;
            this._okBtn.Text = "אישור";
            this._okBtn.UseVisualStyleBackColor = true;
            this._okBtn.Click += new System.EventHandler(this._okBtn_Click);
            // 
            // _questionLabel
            // 
            this._questionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._questionLabel.Location = new System.Drawing.Point(15, 9);
            this._questionLabel.Name = "_questionLabel";
            this._questionLabel.Size = new System.Drawing.Size(324, 49);
            this._questionLabel.TabIndex = 1;
            this._questionLabel.Text = "באיזו מידה הרגשת שאת/ה זה/ו שיצרת את הצליל?";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(236, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // EndOfCycleDialog
            // 
            this.AcceptButton = this._okBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 128);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this._questionLabel);
            this.Controls.Add(this._okBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EndOfCycleDialog";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _okBtn;
        private System.Windows.Forms.Label _questionLabel;
        private System.Windows.Forms.TextBox textBox1;
    }
}