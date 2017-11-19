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
    public partial class frmManageMenus : frmParent
    {
        public frmManageMenus()
        {
            InitializeComponent();
        }

      

        #region Variables
        clsManageMenus objManageMenus = new clsManageMenus();
        DataTable menutbl = new DataTable();
        int mode = 0; //edit = 0 or new = 1

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
                if (e.Node.Text.ToString() == "/")
                {
                    txtOBJECT_NAME_AR.Text = "/";
                    txtOBJECT_COMMAND.Text = "";
                    txtOBJECT_TYPE.Text = "";
                    txtPARNT_OBJECT.Text = "0";
                
                
                }
                else
                {
                    DataRow dr = menutbl.Rows.Find(e.Node.Tag.ToString());
                    txtOBJECT_NAME_AR.Text = dr["OBJECT_NAME_AR"].ToString();
                    txtOBJECT_COMMAND.Text = dr["OBJECT_COMMAND"].ToString();
                    txtOBJECT_TYPE.Text = dr["OBJECT_TYPE"].ToString();
                    txtPARNT_OBJECT.Text = dr["PARNT_OBJECT"].ToString();
                    if (dr["SHOWTOOLBAR"].ToString() == "1")
                    {
                        chkbxSHOWTOOLBAR.Checked = true;
                    }
                    else
                    {
                        chkbxSHOWTOOLBAR.Checked = false;

                    }
                }
        }
        private void btnAddNode_Click(object sender, EventArgs e)
        {
            mode = 1;
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
            txtPARNT_OBJECT.Text = treeVMenus.SelectedNode.Tag.ToString();
            chkbxSHOWTOOLBAR.Checked = false;
            chkbxSHOWTOOLBAR.Enabled = true;
            treeVMenus.Enabled = false;
            treeVMenus.Focus();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            objManageMenus.ObjectNameAR = txtOBJECT_NAME_AR.Text;
            objManageMenus.OBJECTCOMMAND = txtOBJECT_COMMAND.Text;
            objManageMenus.OBJECTTYPE = Convert.ToInt16(txtOBJECT_TYPE.Text);
            objManageMenus.PARNTOBJECT = Convert.ToInt16(treeVMenus.SelectedNode.Tag.ToString());
            objManageMenus.SHOWTOOLBAR = chkbxSHOWTOOLBAR.Checked ? 1 : 0;
            objManageMenus.MENUICON = 0;
            objManageMenus.TOOLBARICON = 0;
            objManageMenus.CREATEUSER = 1;
            objManageMenus.CREATEPC = "10.1.1.10";
            //objManageMenus.CREATETIMESTAMP = DateTime.Now;
            objManageMenus.TRANSSTATUS = 0;
            objManageMenus.RECORDSTATUS = 0;
            objManageMenus.InsertNewMenuItem();
            txtOBJECT_COMMAND.Clear();
            txtOBJECT_NAME_AR.Clear();
            txtOBJECT_TYPE.Clear();
            txtPARNT_OBJECT.Clear();
            treeVMenus.Nodes.Clear();
            loadParents();
            treeVMenus.ExpandAll();
            treeVMenus.Enabled = true;
            treeVMenus.Focus();


        }
        private void btnBrowseMenu_Click(object sender, EventArgs e)
        {
            txtMenuImgPath.Text = imageList1.Images.IndexOfKey(imageList1.Images.Keys[1]).ToString();

            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtOBJECT_COMMAND.Clear();
            txtOBJECT_NAME_AR.Clear();
            txtOBJECT_TYPE.Clear();
            txtPARNT_OBJECT.Clear();
            treeVMenus.Nodes.Clear();
            loadParents();
            treeVMenus.ExpandAll();
            treeVMenus.Enabled = true;
            treeVMenus.Focus();



        }

        #endregion

       

      

       

   

     

       

    }
}
