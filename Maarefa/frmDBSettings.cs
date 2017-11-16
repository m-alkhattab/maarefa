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

namespace maarefa
{
    public partial class frmDBSettings : Form
    {
        public frmDBSettings()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmLogin2 frm = new frmLogin2();
            frm.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {


                if (Validation())
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(Application.StartupPath + "/Settings.xml");
                    //Server Name
                    XmlNode node = doc.SelectSingleNode("/Settings/ServerName");
                    node.InnerText = txtServerName.Text;
                    //DB Name
                    node = doc.SelectSingleNode("/Settings/DBName");
                    node.InnerText = txtDBName.Text;
                    //DB User Name
                    node = doc.SelectSingleNode("/Settings/DBUserName");
                    node.InnerText = txtUserName.Text;
                    //DB Password
                    node = doc.SelectSingleNode("/Settings/DBPassword");
                    node.InnerText = txtPassword.Text;
                    doc.Save(Application.StartupPath + "/Settings.xml");

                    MessageBox.Show("تم الحفظ بنجاح");

                    Globalclass.ServerName = txtServerName.Text;
                    Globalclass.DBName = txtDBName.Text;
                    Globalclass.DBUserName = txtUserName.Text;
                    Globalclass.DBPassword = txtPassword.Text;

                    MessageBox.Show("سيتم إعادة تشغيل البرنامج", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                }
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


            if (txtServerName.Text == "")
            {
                MessageBox.Show("من فضلك ادخل الخادم");
                return false;

            }
            else if (txtDBName.Text == "")
            {
                MessageBox.Show("من فضلك ادخل قاعدة البيانات");
                return false;


            }
            else if (txtUserName.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم المستخدم");
                return false;


            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("من فضلك ادخل كلمة المرور");
                return false;


            }
            return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        private void frmDBSettings_Load(object sender, EventArgs e)
        {
            txtServerName.Text = Globalclass.ServerName;
            txtDBName.Text = Globalclass.DBName;
            txtUserName.Text = Globalclass.DBUserName;
            txtPassword.Text = Globalclass.DBPassword;
        }

        private void frmDBSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin2 frm = new frmLogin2();
            frm.Show();
            this.Hide();
        }
    }
}
