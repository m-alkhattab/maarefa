using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maarefa.Classes
{
    public class clsUser : DBHandlerSqlServer
    {
        #region Variables
        int userID;

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        int branchID;

        public int BranchID
        {
            get { return branchID; }
            set { branchID = value; }
        }
        #endregion

        #region Methods

        public DataTable checkUserCredentials(clsUser user)
        {
            try
            {
                return GetDataTable("spCheckUserCredentials", "@UserName", user.UserName, "@Password", user.Password, "@BranchID", user.BranchID);
            }
            catch (Exception)
            {

                MessageBox.Show("نأسف لقد حدث خطأ");
                return new DataTable();
            }
        }
        #endregion
    }
}
