namespace maarefa
{
    partial class frmManagePrivileges
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagePrivileges));
            this.treeVMenus = new System.Windows.Forms.TreeView();
            this.lblEnable = new System.Windows.Forms.Label();
            this.lblDelete = new System.Windows.Forms.Label();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.lblInsert = new System.Windows.Forms.Label();
            this.chkboxPrint = new System.Windows.Forms.CheckBox();
            this.lblPrint = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblRoles = new System.Windows.Forms.Label();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.chkboxDelete = new System.Windows.Forms.CheckBox();
            this.chkboxUpdate = new System.Windows.Forms.CheckBox();
            this.chkboxInsert = new System.Windows.Forms.CheckBox();
            this.chkboxEnable = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.Images.SetKeyName(0, "books-small.png");
            this.imageList1.Images.SetKeyName(1, "books-startup.png");
            this.imageList1.Images.SetKeyName(2, "icons8-cancel (1).png");
            this.imageList1.Images.SetKeyName(3, "icons8-plus (1).png");
            this.imageList1.Images.SetKeyName(4, "icons8-plus.png");
            // 
            // treeVMenus
            // 
            this.treeVMenus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.treeVMenus.Location = new System.Drawing.Point(223, 62);
            this.treeVMenus.Name = "treeVMenus";
            this.treeVMenus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.treeVMenus.RightToLeftLayout = true;
            this.treeVMenus.Size = new System.Drawing.Size(324, 398);
            this.treeVMenus.TabIndex = 0;
            this.treeVMenus.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeVMenus_AfterSelect);
            // 
            // lblEnable
            // 
            this.lblEnable.AutoSize = true;
            this.lblEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnable.Location = new System.Drawing.Point(150, 97);
            this.lblEnable.Name = "lblEnable";
            this.lblEnable.Size = new System.Drawing.Size(41, 18);
            this.lblEnable.TabIndex = 4;
            this.lblEnable.Text = "التفعيل";
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.Location = new System.Drawing.Point(151, 243);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(40, 18);
            this.lblDelete.TabIndex = 6;
            this.lblDelete.Text = "الحذف";
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdate.Location = new System.Drawing.Point(156, 194);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(35, 18);
            this.lblUpdate.TabIndex = 8;
            this.lblUpdate.Text = "تعديل";
            // 
            // lblInsert
            // 
            this.lblInsert.AutoSize = true;
            this.lblInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsert.Location = new System.Drawing.Point(154, 147);
            this.lblInsert.Name = "lblInsert";
            this.lblInsert.Size = new System.Drawing.Size(37, 18);
            this.lblInsert.TabIndex = 10;
            this.lblInsert.Text = "إدخال";
            // 
            // chkboxPrint
            // 
            this.chkboxPrint.AutoSize = true;
            this.chkboxPrint.Location = new System.Drawing.Point(47, 298);
            this.chkboxPrint.Name = "chkboxPrint";
            this.chkboxPrint.Size = new System.Drawing.Size(15, 14);
            this.chkboxPrint.TabIndex = 7;
            this.chkboxPrint.UseVisualStyleBackColor = true;
            // 
            // lblPrint
            // 
            this.lblPrint.AutoSize = true;
            this.lblPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrint.Location = new System.Drawing.Point(145, 292);
            this.lblPrint.Name = "lblPrint";
            this.lblPrint.Size = new System.Drawing.Size(46, 18);
            this.lblPrint.TabIndex = 12;
            this.lblPrint.Text = "الطباعة";
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(47, 407);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 53);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "حفظ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblRoles
            // 
            this.lblRoles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRoles.AutoSize = true;
            this.lblRoles.Location = new System.Drawing.Point(504, 25);
            this.lblRoles.Name = "lblRoles";
            this.lblRoles.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblRoles.Size = new System.Drawing.Size(46, 13);
            this.lblRoles.TabIndex = 18;
            this.lblRoles.Text = "الوظائف:";
            this.lblRoles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbRoles
            // 
            this.cmbRoles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(259, 22);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbRoles.Size = new System.Drawing.Size(233, 21);
            this.cmbRoles.TabIndex = 19;
            // 
            // chkboxDelete
            // 
            this.chkboxDelete.AutoSize = true;
            this.chkboxDelete.Location = new System.Drawing.Point(47, 247);
            this.chkboxDelete.Name = "chkboxDelete";
            this.chkboxDelete.Size = new System.Drawing.Size(15, 14);
            this.chkboxDelete.TabIndex = 20;
            this.chkboxDelete.UseVisualStyleBackColor = true;
            // 
            // chkboxUpdate
            // 
            this.chkboxUpdate.AutoSize = true;
            this.chkboxUpdate.Location = new System.Drawing.Point(47, 198);
            this.chkboxUpdate.Name = "chkboxUpdate";
            this.chkboxUpdate.Size = new System.Drawing.Size(15, 14);
            this.chkboxUpdate.TabIndex = 21;
            this.chkboxUpdate.UseVisualStyleBackColor = true;
            // 
            // chkboxInsert
            // 
            this.chkboxInsert.AutoSize = true;
            this.chkboxInsert.Location = new System.Drawing.Point(47, 151);
            this.chkboxInsert.Name = "chkboxInsert";
            this.chkboxInsert.Size = new System.Drawing.Size(15, 14);
            this.chkboxInsert.TabIndex = 22;
            this.chkboxInsert.UseVisualStyleBackColor = true;
            // 
            // chkboxEnable
            // 
            this.chkboxEnable.AutoSize = true;
            this.chkboxEnable.Location = new System.Drawing.Point(47, 101);
            this.chkboxEnable.Name = "chkboxEnable";
            this.chkboxEnable.Size = new System.Drawing.Size(15, 14);
            this.chkboxEnable.TabIndex = 23;
            this.chkboxEnable.UseVisualStyleBackColor = true;
            // 
            // frmManagePrivileges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 472);
            this.Controls.Add(this.chkboxEnable);
            this.Controls.Add(this.chkboxInsert);
            this.Controls.Add(this.chkboxUpdate);
            this.Controls.Add(this.chkboxDelete);
            this.Controls.Add(this.cmbRoles);
            this.Controls.Add(this.lblRoles);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblPrint);
            this.Controls.Add(this.chkboxPrint);
            this.Controls.Add(this.lblInsert);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.lblEnable);
            this.Controls.Add(this.treeVMenus);
            this.Name = "frmManagePrivileges";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة إدارة الصلاحيات";
            this.Load += new System.EventHandler(this.frmManageMenus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeVMenus;
        private System.Windows.Forms.Label lblEnable;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Label lblInsert;
        private System.Windows.Forms.CheckBox chkboxPrint;
        private System.Windows.Forms.Label lblPrint;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblRoles;
        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.CheckBox chkboxDelete;
        private System.Windows.Forms.CheckBox chkboxUpdate;
        private System.Windows.Forms.CheckBox chkboxInsert;
        private System.Windows.Forms.CheckBox chkboxEnable;
        private System.Windows.Forms.Label lblDelete;
    }
}