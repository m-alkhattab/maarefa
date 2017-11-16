namespace maarefa
{
    partial class frmRoles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoles));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColRoleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAddNode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColRoleId,
            this.ColRoleName,
            this.ColEdit,
            this.ColDelete});
            this.dataGridView1.Location = new System.Drawing.Point(12, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(646, 386);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColRoleId
            // 
            this.ColRoleId.HeaderText = "مسلسل";
            this.ColRoleId.Name = "ColRoleId";
            // 
            // ColRoleName
            // 
            this.ColRoleName.HeaderText = "مجموعة";
            this.ColRoleName.Name = "ColRoleName";
            this.ColRoleName.Width = 300;
            // 
            // ColEdit
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "تعديل";
            this.ColEdit.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColEdit.HeaderText = "تعديل";
            this.ColEdit.Name = "ColEdit";
            this.ColEdit.Text = "تعديل";
            // 
            // ColDelete
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "حذف";
            this.ColDelete.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColDelete.HeaderText = "حذف";
            this.ColDelete.Name = "ColDelete";
            this.ColDelete.Text = "";
            // 
            // btnAddNode
            // 
            this.btnAddNode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddNode.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddNode.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAddNode.FlatAppearance.BorderSize = 0;
            this.btnAddNode.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNode.Image")));
            this.btnAddNode.Location = new System.Drawing.Point(599, 12);
            this.btnAddNode.Name = "btnAddNode";
            this.btnAddNode.Size = new System.Drawing.Size(48, 49);
            this.btnAddNode.TabIndex = 2;
            this.btnAddNode.UseVisualStyleBackColor = false;
            // 
            // frmRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 476);
            this.Controls.Add(this.btnAddNode);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmRoles";
            this.Text = "frmRoles";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRoleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRoleName;
        private System.Windows.Forms.DataGridViewButtonColumn ColEdit;
        private System.Windows.Forms.DataGridViewButtonColumn ColDelete;
        private System.Windows.Forms.Button btnAddNode;
    }
}