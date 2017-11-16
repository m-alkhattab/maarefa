using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maarefa
{
    public class clsGlobalResources
    {
        #region Variables

        private static string serverName;

        public static string ServerName
        {
            get { return clsGlobalResources.serverName; }
            set { clsGlobalResources.serverName = value; }
        }


        private static string dBName;
        public static string DBName
        {
            get { return clsGlobalResources.dBName; }
            set { clsGlobalResources.dBName = value; }
        }

        private static string dBUserName;
        public static string DBUserName
        {
            get { return clsGlobalResources.dBUserName; }
            set { clsGlobalResources.dBUserName = value; }
        }

        private static string dBPassword;
        public static string DBPassword
        {
            get { return clsGlobalResources.dBPassword; }
            set { clsGlobalResources.dBPassword = value; }
        }
        private static string userName;

        public static string UserName
        {
            get { return clsGlobalResources.userName; }
            set { clsGlobalResources.userName = value; }
        }
        #endregion
    }
}
