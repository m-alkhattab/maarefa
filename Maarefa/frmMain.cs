using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace maarefa
{
    public partial class frmMain : frmParent
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Variables
        clsMain objMain = new clsMain();
        DataTable tblmenu = new DataTable();
        ToolStripMenuItem MenuStripItem = null;
        #endregion

        #region Methods

        //public void PopulateMenusandShortcuts()
        //{
        //    tblmenu = objMain.GetMenuObjects();
        //    foreach (DataRow drmenu in tblmenu.Rows)
        //    {
        //        if (drmenu["PARNT_OBJECT"].ToString() == "")
        //        {
        //            MenuStripItem = new ToolStripMenuItem(drmenu["OBJECT_NAME_AR"].ToString());
        //            mstripMain.Items.Add(MenuStripItem);

        //        }
        //        foreach (DataRow drsmenu in tblmenu.Rows)
        //        {
        //            if (drsmenu["PARNT_OBJECT"].ToString() == drmenu["OBJECT_ID"].ToString())
        //            {
        //                ToolStripMenuItem SubMenuStripItem = new ToolStripMenuItem(drsmenu["OBJECT_NAME_AR"].ToString(), null, new EventHandler(Submenu_Click));
        //                MenuStripItem.DropDownItems.Add(SubMenuStripItem);
        //            }

        //        }
        //        if (Convert.ToInt16(drmenu["SHOWTOOLBAR"]) == 1)
        //        {
        //            ToolStripButton tsb = new ToolStripButton(drmenu["OBJECT_NAME_AR"].ToString(), imglistMain.Images[Convert.ToInt16(drmenu["TOOLBAR_ICON"])], new EventHandler(Shortcut_Click));
        //            tsb.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
        //            tsb.TextAlign = ContentAlignment.BottomCenter;
        //            tsb.ImageAlign = ContentAlignment.MiddleCenter;
        //            tsb.TextImageRelation = TextImageRelation.Overlay;
        //            tstripMainShortcuts.Items.Add(tsb);

        //        }

        //    }
        //}

        void loadmenu()
        {
            tblmenu = objMain.GetMenuObjects();
            foreach (DataRow dr in tblmenu.Rows)
            {
                if (dr["PARNT_OBJECT"].ToString() == "")
                {

                    MenuStripItem = new ToolStripMenuItem(dr["OBJECT_NAME_AR"].ToString(), null, new EventHandler(Item_Click));
                    MenuStripItem.Name = dr["OBJECT_ID"].ToString();
                    MenuStripItem.Image = imglistMain.Images[Convert.ToInt16(dr["MENU_ICON"])];
                    //MenuStripItem.AccessibleName = dr["OBJECT_COMMAND"].ToString();
                    //MenuStripItem.AccessibleDescription = dr["OBJECT_TYPE"].ToString();
                    mstripMain.Items.Add(MenuStripItem);
                    if (Convert.ToInt16(dr["SHOWTOOLBAR"]) == 1)
                    {
                        ToolStripButton tsb = new ToolStripButton(dr["OBJECT_NAME_AR"].ToString(), imglistMain.Images[Convert.ToInt16(dr["TOOLBAR_ICON"])], new EventHandler(Item_Click));
                        tsb.Name= dr["OBJECT_ID"].ToString();
                        tsb.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                        tsb.TextAlign = ContentAlignment.BottomCenter;
                        tsb.ImageAlign = ContentAlignment.MiddleCenter;
                        tsb.TextImageRelation = TextImageRelation.Overlay;
                        tstripMainShortcuts.Items.Add(tsb);

                    }
                    loadsublevelmenu(MenuStripItem, dr["OBJECT_ID"].ToString());

                }

            }
        }
        void loadsublevelmenu(ToolStripMenuItem MenuItem, String Object_ID)
        {
            DataRow[] DrArr = tblmenu.Select("PARNT_OBJECT = " + Object_ID + "");
            foreach (DataRow dr in DrArr)
            {
                ToolStripMenuItem submenu = new ToolStripMenuItem(dr["OBJECT_NAME_AR"].ToString(), null, new EventHandler(Item_Click));
                submenu.Name = dr["OBJECT_ID"].ToString();
                submenu.Image = imglistMain.Images[Convert.ToInt16(dr["MENU_ICON"])];
                //submenu.AccessibleName = dr["OBJECT_COMMAND"].ToString();
                //submenu.AccessibleDescription = dr["OBJECT_TYPE"].ToString();
                MenuItem.DropDownItems.Add(submenu);
                if (Convert.ToInt16(dr["SHOWTOOLBAR"]) == 1)
                {
                    ToolStripButton tsb = new ToolStripButton(dr["OBJECT_NAME_AR"].ToString(), imglistMain.Images[Convert.ToInt16(dr["TOOLBAR_ICON"])], new EventHandler(Item_Click));
                    tsb.Name = dr["OBJECT_ID"].ToString();
                    tsb.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                    tsb.TextAlign = ContentAlignment.BottomCenter;
                    tsb.ImageAlign = ContentAlignment.MiddleCenter;
                    tsb.TextImageRelation = TextImageRelation.Overlay;
                    
                    tstripMainShortcuts.Items.Add(tsb);

                }
                loadsublevelmenu(submenu, dr["OBJECT_ID"].ToString());
            }
        }
        
        #endregion

        #region Events
        private void frmMain_Load(object sender, EventArgs e)
        {
            DBHandlerSqlServer.Constring = "Persist Security Info=False;User ID=maarefa;Password=Te3eC5!4o~9F;Initial Catalog=maarefa;Server=mssql5.gear.host";
            //PopulateMenusandShortcuts();
            loadmenu();

        }

        private void Item_Click(object sender, EventArgs e)
        {
            
            string itemname="";
            if (sender is ToolStripButton)
            {
                ToolStripButton item = (ToolStripButton)sender;
                itemname = item.Name;
            }
            else if (sender is ToolStripMenuItem)
            {
                ToolStripMenuItem item = (ToolStripMenuItem)sender;
                itemname = item.Name;
            }
            {

            }
            DataRow[] DrArr = tblmenu.Select("OBJECT_ID = " + itemname + "");
            string commandname = DrArr[0]["OBJECT_COMMAND"].ToString();
            string objecttype = DrArr[0]["OBJECT_TYPE"].ToString();

            if (tbcontrolMain.TabPages.Count > 0)
            {
                foreach (TabPage tab in tbcontrolMain.TabPages)
                {
                    if (tab.Name == commandname)
                    {
                        tbcontrolMain.SelectedTab = tab;
                        return;
                    }
                    else
                    {


                    }
                }
            }

            switch (Convert.ToInt16(objecttype))
            {
                case 1:
                    var myObj = Activator.CreateInstance(Type.GetType("maarefa." + commandname));
                    Form frm = (Form)myObj;
                    TabPage tp = new TabPage(frm.Text);
                    tp.Name = commandname;
                    frm.TopLevel = false;
                    frm.Parent = tp;
                    frm.Visible = true;
                    //frm.FormBorderStyle = FormBorderStyle.None;
                    //frm.Dock = DockStyle.Fill;
                    tbcontrolMain.TabPages.Add(tp);
                    tbcontrolMain.SelectedTab = tp;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.FormClosed += Frm_FormClosed;
                    //tbcontrolMain.TabPages[0].Controls.Add(frm);
                    //frm.Show();

                    break;
                case 2:
                    MessageBox.Show("Hello from report");
                    break;
                case 3:
                    break;
            }

        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form frm = (Form)sender;
            foreach (TabPage tap in tbcontrolMain.TabPages)
            {
                if (tap.Name == frm.Name)
                {
                    tbcontrolMain.TabPages.Remove(tap);

                    break;
                }

            }
            throw new NotImplementedException();
        }

        //void Shortcut_Click(object sender, EventArgs e)
        //{
        //    foreach (DataRow drsmenu in tblmenu.Rows)
        //    {
        //        if (drsmenu["OBJECT_NAME_AR"].ToString() == sender.ToString())
        //        {
        //            switch (Convert.ToInt16(drsmenu["OBJECT_TYPE"]))
        //            {
        //                case 1:
        //                    var myObj = Activator.CreateInstance(Type.GetType("maarefa." + drsmenu["OBJECT_COMMAND"].ToString()));
        //                    Form frm = (Form)myObj;
        //                    TabPage tp = new TabPage(drsmenu["OBJECT_COMMAND"].ToString());
        //                    tbcontrolMain.TabPages.Add(tp);
        //                    frm.TopLevel = false;
        //                    frm.Visible = true;
        //                    frm.FormBorderStyle = FormBorderStyle.None;
        //                    frm.Dock = DockStyle.Fill;
        //                    tbcontrolMain.TabPages[0].Controls.Add(frm);
        //                    frm.Show();

        //                    break;
        //                case 2:
        //                    MessageBox.Show("Hello from report");
        //                    break;

        //            }
        //        }
        //    }

        //}

        #endregion

    }
}
