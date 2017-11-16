namespace maarefa
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mstripMain = new System.Windows.Forms.MenuStrip();
            this.pnlMainDecor = new System.Windows.Forms.Panel();
            this.tstripMainShortcuts = new System.Windows.Forms.ToolStrip();
            this.imglistMain = new System.Windows.Forms.ImageList(this.components);
            this.tbcontrolMain = new System.Windows.Forms.TabControl();
            this.sstatusMain = new System.Windows.Forms.StatusStrip();
            this.SuspendLayout();
            // 
            // mstripMain
            // 
            this.mstripMain.Location = new System.Drawing.Point(0, 0);
            this.mstripMain.Name = "mstripMain";
            this.mstripMain.Size = new System.Drawing.Size(1264, 24);
            this.mstripMain.TabIndex = 0;
            this.mstripMain.Text = "mstripMain";
            // 
            // pnlMainDecor
            // 
            this.pnlMainDecor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlMainDecor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainDecor.Location = new System.Drawing.Point(0, 24);
            this.pnlMainDecor.Name = "pnlMainDecor";
            this.pnlMainDecor.Size = new System.Drawing.Size(1264, 10);
            this.pnlMainDecor.TabIndex = 1;
            // 
            // tstripMainShortcuts
            // 
            this.tstripMainShortcuts.AutoSize = false;
            this.tstripMainShortcuts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(205)))), ((int)(((byte)(107)))));
            this.tstripMainShortcuts.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.tstripMainShortcuts.Location = new System.Drawing.Point(0, 34);
            this.tstripMainShortcuts.Name = "tstripMainShortcuts";
            this.tstripMainShortcuts.Size = new System.Drawing.Size(1264, 80);
            this.tstripMainShortcuts.TabIndex = 2;
            this.tstripMainShortcuts.Text = "toolStrip1";
            // 
            // imglistMain
            // 
            this.imglistMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglistMain.ImageStream")));
            this.imglistMain.TransparentColor = System.Drawing.Color.Transparent;
            this.imglistMain.Images.SetKeyName(0, "users.ico");
            this.imglistMain.Images.SetKeyName(1, "Tulips.jpg");
            // 
            // tbcontrolMain
            // 
            this.tbcontrolMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbcontrolMain.Location = new System.Drawing.Point(0, 114);
            this.tbcontrolMain.Name = "tbcontrolMain";
            this.tbcontrolMain.RightToLeftLayout = true;
            this.tbcontrolMain.SelectedIndex = 0;
            this.tbcontrolMain.Size = new System.Drawing.Size(1264, 587);
            this.tbcontrolMain.TabIndex = 3;
            // 
            // sstatusMain
            // 
            this.sstatusMain.Location = new System.Drawing.Point(0, 707);
            this.sstatusMain.Name = "sstatusMain";
            this.sstatusMain.Size = new System.Drawing.Size(1264, 22);
            this.sstatusMain.TabIndex = 4;
            this.sstatusMain.Text = "statusStrip1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.sstatusMain);
            this.Controls.Add(this.tbcontrolMain);
            this.Controls.Add(this.tstripMainShortcuts);
            this.Controls.Add(this.pnlMainDecor);
            this.Controls.Add(this.mstripMain);
            this.MainMenuStrip = this.mstripMain;
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip mstripMain;
        private System.Windows.Forms.Panel pnlMainDecor;
        public System.Windows.Forms.ToolStrip tstripMainShortcuts;
        public System.Windows.Forms.ImageList imglistMain;
        public System.Windows.Forms.TabControl tbcontrolMain;
        private System.Windows.Forms.StatusStrip sstatusMain;
    }
}