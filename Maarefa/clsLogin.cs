using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace maarefa
{
    class clsLogin : DBHandlerSqlServer
    {
        #region Variables
        private string _UserName;
        private string _PassWord;
        #endregion

        #region Properties
        public string UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                _UserName = value;
            }
        }
        public string PassWord
        {
            get
            {
                return _PassWord;
            }
            set
            {
                _PassWord = value;
            }
        }
        #endregion

        #region Methods
        public DataTable CheckUserCred()
        {
            return GetDataTable("spCheckUserCred", "@UserName", _UserName, "@PassWord", _PassWord);
        }
        
        #endregion
    }
}
