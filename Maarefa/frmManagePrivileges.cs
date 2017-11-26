using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using maarefa.Classes;

namespace maarefa
{
    public partial class frmManagePrivileges : frmParent
    {
        public frmManagePrivileges()
        {
            InitializeComponent();
        }



        #region Variables
        clsManagePrivileges objManagePrivileges = new clsManagePrivileges();
        DataTable rolestbl = new DataTable();
        DataTable menutbl = new DataTable();
        DataTable privilegetbl = new DataTable();
        int mode = 0; //edit = 0 or new = 1
        #endregion

        #region Methods
        
        void loadParents()
        { 
            menutbl = objManagePrivileges.GetMenuObjects();
            menutbl.PrimaryKey = new DataColumn[] { menutbl.Columns["OBJECT_ID"] };
            foreach (DataRow dr in menutbl.Rows)
            {
                if (Convert.ToInt16(dr["PARNT_OBJECT"]) == 0)
                {

                    TreeNode parent = new TreeNode();
                    parent.Text = dr["OBJECT_NAME_AR"].ToString();
                    parent.Tag = dr["OBJECT_ID"].ToString();
                    treeVMenus.Nodes.Add(parent);
                    loadChilds(parent, dr["OBJECT_ID"].ToString());

                }

            }
        }
        void loadChilds(TreeNode ParentItem, String Object_ID)
        {
            DataRow[] DrArr = menutbl.Select("PARNT_OBJECT = " + Object_ID + "");
            foreach (DataRow dr in DrArr)
            {
                TreeNode child = new TreeNode();
                child.Text = dr["OBJECT_NAME_AR"].ToString();
                child.Tag = dr["OBJECT_ID"].ToString();
                ParentItem.Nodes.Add(child);
                loadChilds(child, dr["OBJECT_ID"].ToString());
            }
        }
         
        private void populateCmb()
        {
            rolestbl = objManagePrivileges.GetRoles();
            cmbRoles.DataSource = rolestbl;
            cmbRoles.DisplayMember = rolestbl.Columns["ROLE_NAME_AR"].ToString();
            cmbRoles.ValueMember = rolestbl.Columns["ROLE_ID"].ToString();
        }
        
        
        #endregion

        #region Events
        private void frmManageMenus_Load(object sender, EventArgs e)
        {

            
            treeVMenus.Nodes.Clear();
            loadParents();
            treeVMenus.ExpandAll();
            populateCmb();
            
           
        }
        private void treeVMenus_AfterSelect(object sender, TreeViewEventArgs e)
        {
            objManagePrivileges.OBJECTID = Convert.ToInt16(e.Node.Tag.ToString());
            objManagePrivileges.ROLEID = cmbRoles.SelectedIndex + 1;
            privilegetbl = objManagePrivileges.GetPrivilege();
            if (privilegetbl.Rows.Count != 0)
            {
                string privstring = privilegetbl.Rows[0].Field<string>(2);
                bool[] privboolarr = privstring.Select(c => c == '1').ToArray();
                chkboxEnable.Checked = privboolarr[0];
                chkboxInsert.Checked = privboolarr[1];
                chkboxUpdate.Checked = privboolarr[2];
                chkboxDelete.Checked = privboolarr[3];
                chkboxPrint.Checked = privboolarr[4];
            }
            else
            {
                DialogResult dialogresult = MessageBox.Show("!  لم يتم تحديد صلاحيات هذه الشاشة لهذه الوظيفة من قبل" + "\n" + "قم بتحديد الصلاحيات ثم اضغط حفظ","", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialogresult == DialogResult.OK)
                {
                    mode = 1;
                    chkboxEnable.Checked = false;
                    chkboxInsert.Checked = false;
                    chkboxUpdate.Checked = false;
                    chkboxDelete.Checked = false;
                    chkboxPrint.Checked = false;
                }
            
            }
        

            
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            string[] privarr = new string[10];         
            privarr[0] = chkboxEnable.Checked ? "1" : "0";
            privarr[1] = chkboxInsert.Checked ? "1" : "0";
            privarr[2] = chkboxUpdate.Checked ? "1" : "0";
            privarr[3] = chkboxDelete.Checked ? "1" : "0";
            privarr[4] = chkboxPrint.Checked ? "1" : "0";
            for (int i = 5; i < 10; i++)
            {
                privarr[i] = "0";
            }
            objManagePrivileges.OBJECTPRIVILEGE = String.Join("",privarr);
            if(mode == 1 )
            {
                try
                {
                    objManagePrivileges.InsertObjectPrivilege();
                    MessageBox.Show("تم الحفظ بنجاح");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حدث الخطأ التالي أثناء الحفظ" + "\n" + ex.ToString());
                }
            }
            else
            {
                try
                {
                    objManagePrivileges.UpdateObjectPrivilege();
                    MessageBox.Show("تم الحفظ بنجاح");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حدث الخطأ التالي أثناء الحفظ" + "\n" + ex.ToString());
                   
                }
            }
            treeVMenus.Nodes.Clear();
            loadParents();
            treeVMenus.ExpandAll();
            treeVMenus.Focus();            
            
        }





        #endregion


    }

   
}
