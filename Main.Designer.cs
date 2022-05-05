namespace ipinfo
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ipInfoLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.ip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ipInfoLabel
            // 
            this.ipInfoLabel.AutoSize = true;
            this.ipInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.ipInfoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ipInfoLabel.ForeColor = System.Drawing.Color.MintCream;
            this.ipInfoLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ipInfoLabel.Location = new System.Drawing.Point(12, 9);
            this.ipInfoLabel.Name = "ipInfoLabel";
            this.ipInfoLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ipInfoLabel.Size = new System.Drawing.Size(54, 21);
            this.ipInfoLabel.TabIndex = 0;
            this.ipInfoLabel.Text = ". . . . . .";
            this.ipInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ipInfoLabel.UseMnemonic = false;
            this.ipInfoLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.ipInfoLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.ipInfoLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.BackColor = System.Drawing.Color.Transparent;
            this.speedLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.speedLabel.ForeColor = System.Drawing.Color.MintCream;
            this.speedLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.speedLabel.Location = new System.Drawing.Point(148, 30);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(43, 21);
            this.speedLabel.TabIndex = 1;
            this.speedLabel.Text = "0B/s";
            this.speedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.speedLabel.UseMnemonic = false;
            this.speedLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.speedLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.speedLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // ip
            // 
            this.ip.AutoSize = true;
            this.ip.BackColor = System.Drawing.Color.Transparent;
            this.ip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ip.ForeColor = System.Drawing.Color.MintCream;
            this.ip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ip.Location = new System.Drawing.Point(12, 30);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(76, 21);
            this.ip.TabIndex = 2;
            this.ip.Text = "127.0.0.1";
            this.ip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ip.UseMnemonic = false;
            this.ip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.ip.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.ip.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(600, 60);
            this.ControlBox = false;
            this.Controls.Add(this.ip);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.ipInfoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Main";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ipInfoLabel;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label ip;
    }
}

