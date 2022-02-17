namespace ipinfo
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ipInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ipInfoLabel
            // 
            resources.ApplyResources(this.ipInfoLabel, "ipInfoLabel");
            this.ipInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.ipInfoLabel.ForeColor = System.Drawing.Color.MintCream;
            this.ipInfoLabel.Name = "ipInfoLabel";
            this.ipInfoLabel.UseMnemonic = false;
            this.ipInfoLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.ipInfoLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.ipInfoLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.CausesValidation = false;
            this.ControlBox = false;
            this.Controls.Add(this.ipInfoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ipInfoLabel;
    }
}