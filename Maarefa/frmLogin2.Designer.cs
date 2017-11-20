namespace maarefa
{
    partial class frmLogin2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin2));
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lnlDBSetting = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chbxRememberMe = new System.Windows.Forms.CheckBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cmbxBranches = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblUserName.Location = new System.Drawing.Point(447, 27);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(81, 19);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "اسم المستخدم";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblPassword.Location = new System.Drawing.Point(455, 63);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 19);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "كلمة المرور";
            // 
            // lnlDBSetting
            // 
            this.lnlDBSetting.AutoSize = true;
            this.lnlDBSetting.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lnlDBSetting.Location = new System.Drawing.Point(377, 213);
            this.lnlDBSetting.Name = "lnlDBSetting";
            this.lnlDBSetting.Size = new System.Drawing.Size(151, 19);
            this.lnlDBSetting.TabIndex = 3;
            this.lnlDBSetting.TabStop = true;
            this.lnlDBSetting.Text = "تحــديــد قــاعــدة الــبيــانــات";
            this.lnlDBSetting.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnlDBSetting_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin.Location = new System.Drawing.Point(432, 154);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(92, 35);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "دخول";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(296, 153);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 36);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "إلغا";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(282, 26);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(149, 20);
            this.txtUserName.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(282, 62);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(149, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // chbxRememberMe
            // 
            this.chbxRememberMe.AutoSize = true;
            this.chbxRememberMe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.chbxRememberMe.Location = new System.Drawing.Point(209, 26);
            this.chbxRememberMe.Name = "chbxRememberMe";
            this.chbxRememberMe.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbxRememberMe.Size = new System.Drawing.Size(63, 23);
            this.chbxRememberMe.TabIndex = 8;
            this.chbxRememberMe.Text = "تذكرني";
            this.chbxRememberMe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chbxRememberMe.UseVisualStyleBackColor = true;
            this.chbxRememberMe.CheckedChanged += new System.EventHandler(this.chbxRememberMe_CheckedChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "books.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(490, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "الفرع";
            // 
            // cmbxBranches
            // 
            this.cmbxBranches.FormattingEnabled = true;
            this.cmbxBranches.Location = new System.Drawing.Point(282, 110);
            this.cmbxBranches.Name = "cmbxBranches";
            this.cmbxBranches.Size = new System.Drawing.Size(148, 21);
            this.cmbxBranches.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::maarefa.Properties.Resources.books_small;
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 240);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(548, 262);
            this.Controls.Add(this.cmbxBranches);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chbxRememberMe);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lnlDBSetting);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Name = "frmLogin2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة الدخول";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin2_FormClosed);
            this.Load += new System.EventHandler(this.frmLogin2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.LinkLabel lnlDBSetting;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chbxRememberMe;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbxBranches;
    }
}