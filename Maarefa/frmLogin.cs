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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        #region Variables
        clsLogin objLogin = new clsLogin();
        DataTable usertbl = new DataTable();
        #endregion

        #region Methods
        private bool ValidateUserCred()
        {
            
            objLogin.UserName = txtUserName.Text;
            objLogin.PassWord = txtPassword.Text;
            usertbl = objLogin.CheckUserCred(); 

            if (usertbl.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("اسم المستخدم أو كلمة المرور غير صحيح");
                return false;
            }

        }
        #endregion

        #region Events
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("من فضلك أدخل اسم المستخدم");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("من فضلك أدخل كلمة المرور");
            }
            else if (ValidateUserCred())
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
       
        #endregion

       

        


    }
}
