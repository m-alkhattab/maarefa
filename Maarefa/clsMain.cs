using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
namespace maarefa
{
  
    class clsMain : DBHandlerSqlServer
    {
        #region Variables
       


        #endregion

        #region Properties


        #endregion


        #region Methods

        public DataTable GetMenuObjects()
        {
            return GetDataTable("spGetObjects");
            
        }

        #endregion

    }
}
