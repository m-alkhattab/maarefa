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
        public Enum Imglst = null;
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
        private void populateCmb()
        {
            for (int i = 0; i <= imageList1.Images.Count-1; i++)
            {
                cmbMenuIcon.Items.Insert(imageList1.Images.IndexOfKey(imageList1.Images.Keys[i]), imageList1.Images.Keys[i]);
                cmbShortcutIcon.Items.Insert(imageList1.Images.IndexOfKey(imageList1.Images.Keys[i]), imageList1.Images.Keys[i]);
            }
            
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
                if (e.Node.Text.ToString() == "/")
                {
                    txtOBJECT_NAME_AR.Text = "/";
                    txtOBJECT_COMMAND.Text = "";
                    txtOBJECT_TYPE.Text = "";
                    txtPARNT_OBJECT.Text = "0";
                    txtOBJECT_COMMAND.Enabled = false;
                    txtOBJECT_NAME_AR.Enabled = false;
                    txtOBJECT_TYPE.Enabled = false;
                    txtPARNT_OBJECT.Enabled = false;
                    cmbShortcutIcon.Enabled = false;
                    cmbMenuIcon.Enabled = false;
                    chkbxSHOWTOOLBAR.Enabled = false;
                
                
                }
                else
                {
                    txtOBJECT_COMMAND.Enabled = true;
                    txtOBJECT_NAME_AR.Enabled = true;
                    txtOBJECT_TYPE.Enabled = true;
                    txtPARNT_OBJECT.Enabled = true;
                    cmbShortcutIcon.Enabled = true;
                    cmbMenuIcon.Enabled = true;
                    chkbxSHOWTOOLBAR.Enabled = true;
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
            cmbShortcutIcon.Enabled = true;
            cmbShortcutIcon.SelectedIndex = -1;
            cmbMenuIcon.Enabled = true;
            cmbMenuIcon.SelectedIndex = -1;
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
            objManageMenus.MENUICON = cmbMenuIcon.SelectedIndex;
            objManageMenus.TOOLBARICON = cmbShortcutIcon.SelectedIndex;
            objManageMenus.OBJECTID = Convert.ToInt16(treeVMenus.SelectedNode.Tag.ToString());
            if (mode == 1)
            {
                objManageMenus.InsertNewMenuItem();

            }
            else
            {
                objManageMenus.UpdateMenuItem();

            }
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtOBJECT_COMMAND.Clear();
            txtOBJECT_NAME_AR.Clear();
            txtOBJECT_TYPE.Clear();
            txtPARNT_OBJECT.Clear();
            treeVMenus.Nodes.Clear();
            cmbMenuIcon.SelectedIndex = -1;
            cmbShortcutIcon.SelectedIndex = -1;
            loadParents();
            treeVMenus.ExpandAll();
            treeVMenus.Enabled = true;
            treeVMenus.Focus();



        }

        #endregion

       

      

       

   

     

       

    }
}
