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
            cmbOBJECT_TYPE.Items.Insert(0, "قائمة");
            cmbOBJECT_TYPE.Items.Insert(1, "شاشة");
            cmbOBJECT_TYPE.Items.Insert(2, "تقرير");

        }
        private void Save()
        {
            objManageMenus.ObjectNameAR = txtOBJECT_NAME_AR.Text;
            objManageMenus.OBJECTCOMMAND = txtOBJECT_COMMAND.Text;
            objManageMenus.OBJECTTYPE = cmbOBJECT_TYPE.SelectedIndex;
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
        }
        private void AddNode()
        {
            mode = 1;
            txtOBJECT_COMMAND.Clear();
            txtOBJECT_COMMAND.Enabled = true;
            txtOBJECT_NAME_AR.Clear();
            txtOBJECT_NAME_AR.Enabled = true;
            cmbOBJECT_TYPE.SelectedIndex = -1;
            cmbOBJECT_TYPE.Enabled = true;
            cmbShortcutIcon.Enabled = true;
            cmbShortcutIcon.SelectedIndex = -1;
            cmbMenuIcon.Enabled = true;
            cmbMenuIcon.SelectedIndex = -1;
            txtPARNT_OBJECT.Text = treeVMenus.SelectedNode.Tag.ToString();
            chkbxSHOWTOOLBAR.Checked = false;
            if (treeVMenus.SelectedNode.Tag.ToString() == "0")
            {
                chkbxSHOWTOOLBAR.Enabled = false;
            }
            else
            {
                chkbxSHOWTOOLBAR.Enabled = true;
            }
            btnCancel.Enabled = true;
            btnSave.Enabled = true;
            treeVMenus.Enabled = false;
            treeVMenus.Focus();
        }
        private void ReloadTree()
        {
            txtOBJECT_COMMAND.Clear();
            txtOBJECT_NAME_AR.Clear();
            cmbOBJECT_TYPE.SelectedIndex = -1;
            txtPARNT_OBJECT.Clear();
            treeVMenus.Nodes.Clear();
            loadParents();
            treeVMenus.ExpandAll();
            treeVMenus.Enabled = true;
            treeVMenus.Focus();
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
                    cmbOBJECT_TYPE.SelectedIndex = -1;
                    txtPARNT_OBJECT.Text = "-1";
                    txtOBJECT_COMMAND.Enabled = false;
                    txtOBJECT_NAME_AR.Enabled = false;
                    cmbOBJECT_TYPE.Enabled = false;
                    txtPARNT_OBJECT.Enabled = false;
                    cmbShortcutIcon.Enabled = false;
                    cmbMenuIcon.Enabled = false;
                    btnRemoveMImage.Enabled = false;
                    btnRemoveTImage.Enabled = false;
                    chkbxSHOWTOOLBAR.Enabled = false;
                    btnDeleteNode.Enabled = false;
                    btnCancel.Enabled = false;
                    btnSave.Enabled = false;
                    cmbShortcutIcon.SelectedIndex = -1;
                    cmbMenuIcon.SelectedIndex = -1;
                
                
                }
                else
                {
                    txtOBJECT_COMMAND.Enabled = true;
                    txtOBJECT_NAME_AR.Enabled = true;
                    cmbOBJECT_TYPE.Enabled = true;
                    cmbShortcutIcon.Enabled = true;
                    cmbMenuIcon.Enabled = true;
                    btnRemoveTImage.Enabled = true;
                    btnRemoveMImage.Enabled = true;
                    if (e.Node.Parent.Tag.ToString() == "0")
                    {
                        chkbxSHOWTOOLBAR.Enabled = false;
                    }
                    else
                    {
                        chkbxSHOWTOOLBAR.Enabled = true;
                    }
                    btnDeleteNode.Enabled = true;
                    btnCancel.Enabled = true;
                    btnSave.Enabled = true;
                    DataRow dr = menutbl.Rows.Find(e.Node.Tag.ToString());
                    txtOBJECT_NAME_AR.Text = dr["OBJECT_NAME_AR"].ToString();
                    txtOBJECT_COMMAND.Text = dr["OBJECT_COMMAND"].ToString();
                    cmbOBJECT_TYPE.SelectedIndex = Convert.ToInt16(dr["OBJECT_TYPE"]);
                    txtPARNT_OBJECT.Text = dr["PARNT_OBJECT"].ToString();
                    cmbMenuIcon.SelectedIndex = Convert.ToInt16(dr["MENU_ICON"].ToString());
                    cmbShortcutIcon.SelectedIndex = Convert.ToInt16(dr["TOOLBAR_ICON"].ToString());
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
            AddNode();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtOBJECT_NAME_AR.Text == "")
            {
                MessageBox.Show("!من فضلك تأكد من إدخال إسم القائمة", "خطأ في البيانات المدخلة", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtOBJECT_COMMAND.Text == "" && cmbOBJECT_TYPE.SelectedIndex == 1)
            {
                MessageBox.Show("!من فضلك قم بإدخال اسم الشاشة", "خطأ في البيانات المدخلة", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtOBJECT_COMMAND.Text == "" && cmbOBJECT_TYPE.SelectedIndex == 2)
            {
                MessageBox.Show("!من فضلك قم بإدخال اسم التقرير", "خطأ في البيانات المدخلة", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialogresult = MessageBox.Show("هل تريد تأكيد حفظ التعديلات ؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogresult == DialogResult.Yes)
                {
                    Save();
                    ReloadTree();
                }

            }

        }

        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("هل تريد حقا التراجع عن هذه التعديلات؟", "تراجع", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogresult == DialogResult.Yes)
            {
                ReloadTree();
            }


        }
        private void btnDeleteNode_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("هل تريد حقا حذف هذه القائمة ؟", "حذف القائمة المختارة", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogresult == DialogResult.Yes)
            {
                objManageMenus.OBJECTID = Convert.ToInt16(treeVMenus.SelectedNode.Tag.ToString());
                objManageMenus.DeleteMenuItem();
                ReloadTree();
            }
            else
            {
                treeVMenus.Focus();
            }

        }

     

        #endregion

        private void btnRemoveMImage_Click(object sender, EventArgs e)
        {
            cmbMenuIcon.SelectedIndex = -1;
        }
        private void btnRemoveTImage_Click(object sender, EventArgs e)
        {
           cmbShortcutIcon.SelectedIndex = -1;
        }


      

       

      

       

   

     

       

    }
}
