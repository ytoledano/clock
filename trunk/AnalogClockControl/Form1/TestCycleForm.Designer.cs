namespace Form1
{
    partial class TestCycleForm
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
            this._clockGroup = new System.Windows.Forms.GroupBox();
            this._countLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _clockGroup
            // 
            this._clockGroup.Location = new System.Drawing.Point(12, 12);
            this._clockGroup.Name = "_clockGroup";
            this._clockGroup.Size = new System.Drawing.Size(688, 705);
            this._clockGroup.TabIndex = 0;
            this._clockGroup.TabStop = false;
            this._clockGroup.Text = "שעון";
            // 
            // _countLabel
            // 
            this._countLabel.AutoSize = true;
            this._countLabel.Location = new System.Drawing.Point(678, 721);
            this._countLabel.Name = "_countLabel";
            this._countLabel.Size = new System.Drawing.Size(13, 13);
            this._countLabel.TabIndex = 1;
            this._countLabel.Text = "1";
            // 
            // TestCycleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 743);
            this.Controls.Add(this._countLabel);
            this.Controls.Add(this._clockGroup);
            this.Name = "TestCycleForm";
            this.Text = "שעון";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox _clockGroup;
        private System.Windows.Forms.Label _countLabel;
    }
}