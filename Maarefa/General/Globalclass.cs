using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maarefa
{

    static class Globalclass
    {
        #region Variables
        //public static string _Servername;
        //public static string _DBname;
        //public static string _Sqluser;
       // public static string _Sqlpassword;
       //public static string _Userid;
       // public static string _Branchid;
       // public static string _pc_ip;

        private static string serverName;

        private static string dBName;

        private static string dBUserName;

        private static string dBPassword;

        private static string userName;

        private static int userID;

        private static int branchID;

        private static string pC_IP;

        #endregion

        #region Properities

        public static string ServerName
        {
            get { return serverName; }
            set { serverName = value; }
        }


        public static string DBName
        {
            get { return dBName; }
            set { dBName = value; }
        }

        public static string DBUserName
        {
            get { return dBUserName; }
            set { dBUserName = value; }
        }

        public static string DBPassword
        {
            get { return dBPassword; }
            set { dBPassword = value; }
        }

        public static string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public static int UserID
        {
            get { return userID; }
            set { userID = value; }
        }


        public static int BranchID
        {
            get { return branchID; }
            set { branchID = value; }
        }

        public static string PC_IP
        {
            get { return pC_IP; }
            set { pC_IP = value; }
        }
        #endregion

    }
}
