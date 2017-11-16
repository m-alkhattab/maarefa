using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using maarefa.Classes;


namespace maarefa
{
    public partial class frmLogin2 : Form
    {
        #region Variables
        clsBranch cls_Branch;
        clsUser cls_User;
        DBHandlerSqlServer dbHandler;
        DataTable tbl;
        XmlDocument doc;
        #endregion

        public frmLogin2()
        {
            InitializeComponent();
        }



        #region Methods
        private void LoadDBSettings()
        {
            try
            {
                //settings file
                doc = new XmlDocument();
                XmlNode node = doc.SelectSingleNode("/Settings/ServerName");

                doc.Load(Application.StartupPath + "/Settings.xml");

                //isRemembered
                node = doc.SelectSingleNode("/Settings/isRemembered");
                if (node.InnerText == "True")
                {
                    chbxRememberMe.Checked = bool.Parse(node.InnerText);

                    //UserName
                    node = doc.SelectSingleNode("/Settings/UserName");
                    txtUserName.Text = node.InnerText;
                }

                //Server Name
                node = doc.SelectSingleNode("/Settings/ServerName");
                Globalclass.ServerName = node.InnerText;

                //DB Name
                node = doc.SelectSingleNode("/Settings/DBName");
                Globalclass.DBName = node.InnerText;

                //DB User Name
                node = doc.SelectSingleNode("/Settings/DBUserName");
                Globalclass.DBUserName = node.InnerText;

                //DB Password
                node = doc.SelectSingleNode("/Settings/DBPassword");
                Globalclass.DBPassword = node.InnerText;

                DBHandlerSqlServer._CnString = "Data Source=" + Globalclass.ServerName + ";Initial Catalog=" + Globalclass.DBName + ";User ID=" + Globalclass.DBUserName + ";Password=" + Globalclass.DBPassword;
            }
            catch (Exception ex)
            {

                MessageBox.Show("نأسف لقد حدث خطأ");
            }
        }



        private bool Validation()
        {
            try
            {


                if (txtUserName.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل اسم المستخدم");
                    return false;

                }
                else if (txtPassword.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل كلمة المرور");
                    return false;

                }
                else if (cmbxBranches.SelectedIndex == -1)
                {
                    MessageBox.Show("من فضلك اختار الفرع");
                    return false;

                }

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("نأسف لقد حدث خطأ");
                return false;
            }
        }

        #endregion


        #region Events
        private void frmLogin2_Load(object sender, EventArgs e)
        {
            try
            {

                LoadDBSettings();

                //load Branches
                cls_Branch = new clsBranch();
                cmbxBranches.DataSource = cls_Branch.getBranches();
                cmbxBranches.ValueMember = "BranchID";
                cmbxBranches.DisplayMember = "BranchName";
                cmbxBranches.SelectedIndex = -1;

                //load User Name
                //if (Properties.Settings.Default.UserName != string.Empty)
                //{
                //    txtUserName.Text = Properties.Settings.Default.UserName;
                //}
            }
            catch (Exception)
            {

                MessageBox.Show("نأسف لقد حدث خطأ");
            }

        }
        private void lnlDBSetting_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDBSettings frm = new frmDBSettings();
            frm.Show();
            //hide this form
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validation())
                {
                    cls_User = new clsUser();
                    cls_User.UserName = txtUserName.Text;
                    cls_User.Password = txtPassword.Text;
                    cls_User.BranchID = int.Parse(cmbxBranches.SelectedValue.ToString());
                    tbl = cls_User.checkUserCredentials(cls_User);
                    if (tbl.Rows.Count > 0)
                    {
                        //if (chbxRememberMe.Checked)
                        //{
                        //    Properties.Settings.Default.UserName = txtUserName.Text;
                        //    Properties.Settings.Default.Save();
                        //}
                        SaveUserDate(tbl);
                        frmMain frm = new frmMain();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("من فضلك تأكد من صحة اسم المستخدم وكلمة المرور");
                    }
                }

            }
            catch (Exception)
            {

                MessageBox.Show("نأسف لقد حدث خطأ");
            }

        }

        private void SaveUserDate(DataTable tbl)
        {
            doc = new XmlDocument();
            doc.Load(Application.StartupPath + "/Settings.xml");

            //User Name
            XmlNode node = doc.SelectSingleNode("/Settings/UserName");
            node.InnerText = txtUserName.Text;
            Globalclass.UserName = tbl.Rows[0]["UserName"].ToString();

            //UserID
            node = doc.SelectSingleNode("/Settings/UserID");
            node.InnerText = tbl.Rows[0]["UserID"].ToString();
            Globalclass.UserID = int.Parse(tbl.Rows[0]["UserID"].ToString());

            //BranchID
            node = doc.SelectSingleNode("/Settings/BranchID");
            node.InnerText = tbl.Rows[0]["BranchID"].ToString();
            Globalclass.BranchID = int.Parse(tbl.Rows[0]["BranchID"].ToString());

            //PC_IP
            node = doc.SelectSingleNode("/Settings/PC_IP");
            node.InnerText = tbl.Rows[0]["PC_IP"].ToString();
            Globalclass.PC_IP = tbl.Rows[0]["PC_IP"].ToString();

        }
        private void frmLogin2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void chbxRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxRememberMe.Checked)
            {
                 doc = new XmlDocument();
                doc.Load(Application.StartupPath + "/Settings.xml");

                //User Name
                XmlNode node = doc.SelectSingleNode("/Settings/UserName");
                node.InnerText = txtUserName.Text;
            }

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        #endregion

    }
}
