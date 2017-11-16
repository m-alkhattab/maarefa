using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maarefa.Classes
{
    public class clsBranch : DBHandlerSqlServer
    {
        #region Variables
        int branchID;

        public int BranchID
        {
            get { return branchID; }
            set { branchID = value; }
        }

        string branchName;

        public string BranchName
        {
            get { return branchName; }
            set { branchName = value; }
        }
        #endregion

        #region Functions
        public DataTable getBranches()
        {
            try
            {
                return GetDataTable("spGetBranches");
            }
            catch (Exception)
            {

                throw;
            }


        }
        #endregion
    }
}
