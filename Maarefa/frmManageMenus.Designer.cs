namespace maarefa
{
    partial class frmManageMenus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageMenus));
            this.treeVMenus = new System.Windows.Forms.TreeView();
            this.btnAddNode = new System.Windows.Forms.Button();
            this.btnDeleteNode = new System.Windows.Forms.Button();
            this.txtOBJECT_NAME_AR = new System.Windows.Forms.TextBox();
            this.lblOBJECT_NAME_AR = new System.Windows.Forms.Label();
            this.lblPARNT_OBJECT = new System.Windows.Forms.Label();
            this.txtPARNT_OBJECT = new System.Windows.Forms.TextBox();
            this.lblOBJECT_TYPE = new System.Windows.Forms.Label();
            this.txtOBJECT_TYPE = new System.Windows.Forms.TextBox();
            this.lblOBJECT_COMMAND = new System.Windows.Forms.Label();
            this.txtOBJECT_COMMAND = new System.Windows.Forms.TextBox();
            this.chkbxSHOWTOOLBAR = new System.Windows.Forms.CheckBox();
            this.lblSHOWTOOLBAR = new System.Windows.Forms.Label();
            this.tbtnEditNode = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblMenuImage = new System.Windows.Forms.Label();
            this.lblShortcutImage = new System.Windows.Forms.Label();
            this.txtShortcutImgPath = new System.Windows.Forms.TextBox();
            this.txtMenuImgPath = new System.Windows.Forms.TextBox();
            this.btnBrowseMenu = new System.Windows.Forms.Button();
            this.btnBrowseShortcut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeVMenus
            // 
            this.treeVMenus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.treeVMenus.Location = new System.Drawing.Point(521, 12);
            this.treeVMenus.Name = "treeVMenus";
            this.treeVMenus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.treeVMenus.RightToLeftLayout = true;
            this.treeVMenus.Size = new System.Drawing.Size(324, 401);
            this.treeVMenus.TabIndex = 0;
            this.treeVMenus.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeVMenus_AfterSelect);
            // 
            // btnAddNode
            // 
            this.btnAddNode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddNode.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddNode.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAddNode.FlatAppearance.BorderSize = 0;
            this.btnAddNode.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNode.Image")));
            this.btnAddNode.Location = new System.Drawing.Point(718, 419);
            this.btnAddNode.Name = "btnAddNode";
            this.btnAddNode.Size = new System.Drawing.Size(48, 49);
            this.btnAddNode.TabIndex = 1;
            this.btnAddNode.UseVisualStyleBackColor = false;
            this.btnAddNode.Click += new System.EventHandler(this.btnAddNode_Click);
            // 
            // btnDeleteNode
            // 
            this.btnDeleteNode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteNode.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteNode.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnDeleteNode.FlatAppearance.BorderSize = 0;
            this.btnDeleteNode.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteNode.Image")));
            this.btnDeleteNode.Location = new System.Drawing.Point(617, 419);
            this.btnDeleteNode.Name = "btnDeleteNode";
            this.btnDeleteNode.Size = new System.Drawing.Size(48, 49);
            this.btnDeleteNode.TabIndex = 2;
            this.btnDeleteNode.UseVisualStyleBackColor = false;
            // 
            // txtOBJECT_NAME_AR
            // 
            this.txtOBJECT_NAME_AR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOBJECT_NAME_AR.Enabled = false;
            this.txtOBJECT_NAME_AR.Location = new System.Drawing.Point(12, 41);
            this.txtOBJECT_NAME_AR.Name = "txtOBJECT_NAME_AR";
            this.txtOBJECT_NAME_AR.Size = new System.Drawing.Size(273, 20);
            this.txtOBJECT_NAME_AR.TabIndex = 3;
            this.txtOBJECT_NAME_AR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOBJECT_NAME_AR
            // 
            this.lblOBJECT_NAME_AR.AutoSize = true;
            this.lblOBJECT_NAME_AR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOBJECT_NAME_AR.Location = new System.Drawing.Point(460, 40);
            this.lblOBJECT_NAME_AR.Name = "lblOBJECT_NAME_AR";
            this.lblOBJECT_NAME_AR.Size = new System.Drawing.Size(34, 18);
            this.lblOBJECT_NAME_AR.TabIndex = 4;
            this.lblOBJECT_NAME_AR.Text = "الاسم";
            // 
            // lblPARNT_OBJECT
            // 
            this.lblPARNT_OBJECT.AutoSize = true;
            this.lblPARNT_OBJECT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPARNT_OBJECT.Location = new System.Drawing.Point(408, 186);
            this.lblPARNT_OBJECT.Name = "lblPARNT_OBJECT";
            this.lblPARNT_OBJECT.Size = new System.Drawing.Size(86, 18);
            this.lblPARNT_OBJECT.TabIndex = 6;
            this.lblPARNT_OBJECT.Text = "المستوى الأعلى";
            // 
            // txtPARNT_OBJECT
            // 
            this.txtPARNT_OBJECT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPARNT_OBJECT.Enabled = false;
            this.txtPARNT_OBJECT.Location = new System.Drawing.Point(12, 191);
            this.txtPARNT_OBJECT.Name = "txtPARNT_OBJECT";
            this.txtPARNT_OBJECT.Size = new System.Drawing.Size(273, 20);
            this.txtPARNT_OBJECT.TabIndex = 5;
            this.txtPARNT_OBJECT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOBJECT_TYPE
            // 
            this.lblOBJECT_TYPE.AutoSize = true;
            this.lblOBJECT_TYPE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOBJECT_TYPE.Location = new System.Drawing.Point(439, 137);
            this.lblOBJECT_TYPE.Name = "lblOBJECT_TYPE";
            this.lblOBJECT_TYPE.Size = new System.Drawing.Size(55, 18);
            this.lblOBJECT_TYPE.TabIndex = 8;
            this.lblOBJECT_TYPE.Text = "نوع الأمر";
            // 
            // txtOBJECT_TYPE
            // 
            this.txtOBJECT_TYPE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOBJECT_TYPE.Enabled = false;
            this.txtOBJECT_TYPE.Location = new System.Drawing.Point(12, 141);
            this.txtOBJECT_TYPE.Name = "txtOBJECT_TYPE";
            this.txtOBJECT_TYPE.Size = new System.Drawing.Size(273, 20);
            this.txtOBJECT_TYPE.TabIndex = 7;
            this.txtOBJECT_TYPE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOBJECT_COMMAND
            // 
            this.lblOBJECT_COMMAND.AutoSize = true;
            this.lblOBJECT_COMMAND.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOBJECT_COMMAND.Location = new System.Drawing.Point(460, 90);
            this.lblOBJECT_COMMAND.Name = "lblOBJECT_COMMAND";
            this.lblOBJECT_COMMAND.Size = new System.Drawing.Size(33, 18);
            this.lblOBJECT_COMMAND.TabIndex = 10;
            this.lblOBJECT_COMMAND.Text = "الأمر";
            // 
            // txtOBJECT_COMMAND
            // 
            this.txtOBJECT_COMMAND.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOBJECT_COMMAND.Enabled = false;
            this.txtOBJECT_COMMAND.Location = new System.Drawing.Point(12, 91);
            this.txtOBJECT_COMMAND.Name = "txtOBJECT_COMMAND";
            this.txtOBJECT_COMMAND.Size = new System.Drawing.Size(273, 20);
            this.txtOBJECT_COMMAND.TabIndex = 9;
            this.txtOBJECT_COMMAND.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkbxSHOWTOOLBAR
            // 
            this.chkbxSHOWTOOLBAR.AutoSize = true;
            this.chkbxSHOWTOOLBAR.Enabled = false;
            this.chkbxSHOWTOOLBAR.Location = new System.Drawing.Point(270, 241);
            this.chkbxSHOWTOOLBAR.Name = "chkbxSHOWTOOLBAR";
            this.chkbxSHOWTOOLBAR.Size = new System.Drawing.Size(15, 14);
            this.chkbxSHOWTOOLBAR.TabIndex = 11;
            this.chkbxSHOWTOOLBAR.UseVisualStyleBackColor = true;
            // 
            // lblSHOWTOOLBAR
            // 
            this.lblSHOWTOOLBAR.AutoSize = true;
            this.lblSHOWTOOLBAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSHOWTOOLBAR.Location = new System.Drawing.Point(339, 235);
            this.lblSHOWTOOLBAR.Name = "lblSHOWTOOLBAR";
            this.lblSHOWTOOLBAR.Size = new System.Drawing.Size(155, 18);
            this.lblSHOWTOOLBAR.TabIndex = 12;
            this.lblSHOWTOOLBAR.Text = "إظهار في شريط الاختصارات";
            // 
            // tbtnEditNode
            // 
            this.tbtnEditNode.Appearance = System.Windows.Forms.Appearance.Button;
            this.tbtnEditNode.Location = new System.Drawing.Point(317, 381);
            this.tbtnEditNode.Name = "tbtnEditNode";
            this.tbtnEditNode.Size = new System.Drawing.Size(104, 53);
            this.tbtnEditNode.TabIndex = 13;
            this.tbtnEditNode.Text = "تعديل";
            this.tbtnEditNode.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tbtnEditNode.UseVisualStyleBackColor = true;
            this.tbtnEditNode.CheckedChanged += new System.EventHandler(this.tbtnEditNode_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(181, 381);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 53);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "حفظ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(46, 381);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 53);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "إلغاء";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblMenuImage
            // 
            this.lblMenuImage.AutoSize = true;
            this.lblMenuImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuImage.Location = new System.Drawing.Point(420, 284);
            this.lblMenuImage.Name = "lblMenuImage";
            this.lblMenuImage.Size = new System.Drawing.Size(74, 18);
            this.lblMenuImage.TabIndex = 16;
            this.lblMenuImage.Text = "صورة القائمة";
            // 
            // lblShortcutImage
            // 
            this.lblShortcutImage.AutoSize = true;
            this.lblShortcutImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShortcutImage.Location = new System.Drawing.Point(355, 333);
            this.lblShortcutImage.Name = "lblShortcutImage";
            this.lblShortcutImage.Size = new System.Drawing.Size(139, 18);
            this.lblShortcutImage.TabIndex = 17;
            this.lblShortcutImage.Text = "صورة شريط الاختصارات";
            // 
            // txtShortcutImgPath
            // 
            this.txtShortcutImgPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtShortcutImgPath.Enabled = false;
            this.txtShortcutImgPath.Location = new System.Drawing.Point(76, 331);
            this.txtShortcutImgPath.Name = "txtShortcutImgPath";
            this.txtShortcutImgPath.Size = new System.Drawing.Size(209, 20);
            this.txtShortcutImgPath.TabIndex = 18;
            this.txtShortcutImgPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMenuImgPath
            // 
            this.txtMenuImgPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMenuImgPath.Enabled = false;
            this.txtMenuImgPath.Location = new System.Drawing.Point(76, 282);
            this.txtMenuImgPath.Name = "txtMenuImgPath";
            this.txtMenuImgPath.Size = new System.Drawing.Size(209, 20);
            this.txtMenuImgPath.TabIndex = 19;
            this.txtMenuImgPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBrowseMenu
            // 
            this.btnBrowseMenu.Enabled = false;
            this.btnBrowseMenu.Location = new System.Drawing.Point(12, 279);
            this.btnBrowseMenu.Name = "btnBrowseMenu";
            this.btnBrowseMenu.Size = new System.Drawing.Size(58, 23);
            this.btnBrowseMenu.TabIndex = 20;
            this.btnBrowseMenu.Text = "تصفح";
            this.btnBrowseMenu.UseVisualStyleBackColor = true;
            this.btnBrowseMenu.Click += new System.EventHandler(this.btnBrowseMenu_Click);
            // 
            // btnBrowseShortcut
            // 
            this.btnBrowseShortcut.Enabled = false;
            this.btnBrowseShortcut.Location = new System.Drawing.Point(12, 329);
            this.btnBrowseShortcut.Name = "btnBrowseShortcut";
            this.btnBrowseShortcut.Size = new System.Drawing.Size(58, 23);
            this.btnBrowseShortcut.TabIndex = 21;
            this.btnBrowseShortcut.Text = "تصفح";
            this.btnBrowseShortcut.UseVisualStyleBackColor = true;
            // 
            // frmManageMenus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 472);
            this.Controls.Add(this.btnBrowseShortcut);
            this.Controls.Add(this.btnBrowseMenu);
            this.Controls.Add(this.txtMenuImgPath);
            this.Controls.Add(this.txtShortcutImgPath);
            this.Controls.Add(this.lblShortcutImage);
            this.Controls.Add(this.lblMenuImage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbtnEditNode);
            this.Controls.Add(this.lblSHOWTOOLBAR);
            this.Controls.Add(this.chkbxSHOWTOOLBAR);
            this.Controls.Add(this.lblOBJECT_COMMAND);
            this.Controls.Add(this.txtOBJECT_COMMAND);
            this.Controls.Add(this.lblOBJECT_TYPE);
            this.Controls.Add(this.txtOBJECT_TYPE);
            this.Controls.Add(this.lblPARNT_OBJECT);
            this.Controls.Add(this.txtPARNT_OBJECT);
            this.Controls.Add(this.lblOBJECT_NAME_AR);
            this.Controls.Add(this.txtOBJECT_NAME_AR);
            this.Controls.Add(this.btnDeleteNode);
            this.Controls.Add(this.btnAddNode);
            this.Controls.Add(this.treeVMenus);
            this.Name = "frmManageMenus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageMenus";
            this.Load += new System.EventHandler(this.frmManageMenus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeVMenus;
        private System.Windows.Forms.Button btnAddNode;
        private System.Windows.Forms.Button btnDeleteNode;
        private System.Windows.Forms.TextBox txtOBJECT_NAME_AR;
        private System.Windows.Forms.Label lblOBJECT_NAME_AR;
        private System.Windows.Forms.Label lblPARNT_OBJECT;
        private System.Windows.Forms.TextBox txtPARNT_OBJECT;
        private System.Windows.Forms.Label lblOBJECT_TYPE;
        private System.Windows.Forms.TextBox txtOBJECT_TYPE;
        private System.Windows.Forms.Label lblOBJECT_COMMAND;
        private System.Windows.Forms.TextBox txtOBJECT_COMMAND;
        private System.Windows.Forms.CheckBox chkbxSHOWTOOLBAR;
        private System.Windows.Forms.Label lblSHOWTOOLBAR;
        private System.Windows.Forms.CheckBox tbtnEditNode;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblMenuImage;
        private System.Windows.Forms.Label lblShortcutImage;
        private System.Windows.Forms.TextBox txtShortcutImgPath;
        private System.Windows.Forms.TextBox txtMenuImgPath;
        private System.Windows.Forms.Button btnBrowseMenu;
        private System.Windows.Forms.Button btnBrowseShortcut;
    }
}