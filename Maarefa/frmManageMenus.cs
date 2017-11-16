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
    public partial class frmManageMenus : Form
    {
        public frmManageMenus()
        {
            InitializeComponent();
        }

      

        #region Variables
        clsManageMenus objManageMenus = new clsManageMenus();
        DataTable menutbl = new DataTable();


        #endregion

        #region Methods
        void loadParents()
        {
            menutbl = objManageMenus.GetMenuObjects();
            menutbl.PrimaryKey = new DataColumn[] { menutbl.Columns["OBJECT_ID"] };
            TreeNode root = new TreeNode();
            root.Text = "/";
            root.Tag = "0";
            treeVMenus.Nodes.Add(root);
            foreach (DataRow dr in menutbl.Rows)
            {
                if (Convert.ToInt16(dr["PARNT_OBJECT"]) == 0)
                {

                    TreeNode parent = new TreeNode();
                    parent.Text = dr["OBJECT_NAME_AR"].ToString();
                    parent.Tag = dr["OBJECT_ID"].ToString();
                    root.Nodes.Add(parent);
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


        #endregion

        #region Events
        private void frmManageMenus_Load(object sender, EventArgs e)
        {
            treeVMenus.Nodes.Clear();
            loadParents();
            treeVMenus.ExpandAll();
            
            
           
        }
        private void treeVMenus_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                
                DataRow dr = menutbl.Rows.Find(e.Node.Tag.ToString());
                txtOBJECT_NAME_AR.Text = dr["OBJECT_NAME_AR"].ToString();
                txtOBJECT_COMMAND.Text = dr["OBJECT_COMMAND"].ToString();
                txtOBJECT_TYPE.Text = dr["OBJECT_TYPE"].ToString();
                txtPARNT_OBJECT.Text = e.Node.Parent.Tag.ToString();
                if (dr["SHOWTOOLBAR"].ToString() == "1")
                {
                    chkbxSHOWTOOLBAR.Checked = true;
                }
                else
                {
                    chkbxSHOWTOOLBAR.Checked = false;

                }
            }
            catch
            { }
        }
        private void btnAddNode_Click(object sender, EventArgs e)
        {
            txtOBJECT_COMMAND.Clear();
            txtOBJECT_COMMAND.Enabled = true;
            txtOBJECT_NAME_AR.Clear();
            txtOBJECT_NAME_AR.Enabled = true;
            txtOBJECT_TYPE.Clear();
            txtOBJECT_TYPE.Enabled = true;
            txtMenuImgPath.Clear();
            txtMenuImgPath.Enabled = true;
            txtShortcutImgPath.Clear();
            txtShortcutImgPath.Enabled = true;
            btnBrowseMenu.Enabled = true;
            btnBrowseShortcut.Enabled = true;
            if (treeVMenus.SelectedNode.Parent != null)
            { txtPARNT_OBJECT.Text = treeVMenus.SelectedNode.Parent.Tag.ToString(); }
            else
            { txtPARNT_OBJECT.Text = "0"; }
            chkbxSHOWTOOLBAR.Checked = false;
            chkbxSHOWTOOLBAR.Enabled = true;
            treeVMenus.Enabled = false;
            treeVMenus.Focus();
            tbtnEditNode.Enabled = false;
        }

        private void tbtnEditNode_CheckedChanged(object sender, EventArgs e)
        {
            if (tbtnEditNode.Checked == true)
            {
                txtOBJECT_COMMAND.Enabled = true;
                txtOBJECT_NAME_AR.Enabled = true;
                txtOBJECT_TYPE.Enabled = true;
                chkbxSHOWTOOLBAR.Enabled = true;
                treeVMenus.Enabled = false;

            }
            else
            {
                txtOBJECT_COMMAND.Enabled = false;
                txtOBJECT_NAME_AR.Enabled = false;
                txtOBJECT_TYPE.Enabled = false;
                chkbxSHOWTOOLBAR.Enabled = false;
                treeVMenus.Enabled = true;
                treeVMenus.Focus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void btnBrowseMenu_Click(object sender, EventArgs e)
        {
            int b = 0;
            var ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.ShowDialog();
            for (int z = 0; z < ofd.FileNames.Length; z++)
            {
                Image img = Image.FromFile(ofd.FileNames[z]);
                string a = b.ToString();
                //imageList1.Images.Add(a, img);
                
            }
        }

      

       

   

     

       

    }
}
