using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace maarefa.Classes
{
    class clsManageMenus : DBHandlerSqlServer
    {
        #region Variables
        string _ObjectNameAR, _OBJECTCOMMAND, _CREATEPC;
        int _OBJECTTYPE,_PARNTOBJECT,_SHOWTOOLBAR,_MENUICON, _TOOLBARICON,_CREATEUSER,_TRANSSTATUS, _RECORDSTATUS;
        //DateTime _CREATETIMESTAMP;

        #endregion

        #region Properties

        public string ObjectNameAR
        {
            get { return _ObjectNameAR; }
            set { _ObjectNameAR = value; }
        }
        public string OBJECTCOMMAND
        {
            get { return _OBJECTCOMMAND; }
            set { _OBJECTCOMMAND = value; }
        }
        public string CREATEPC
        {
            get { return _CREATEPC; }
            set { _CREATEPC = value; }
        }
        //public DateTime CREATETIMESTAMP
        //{
        //    get { return _CREATETIMESTAMP; }
        //    set { _CREATETIMESTAMP = value; }
        //}
        public int TRANSSTATUS
        {
            get { return _TRANSSTATUS; }
            set { _TRANSSTATUS = value; }
        }
        public int RECORDSTATUS
        {
            get { return _RECORDSTATUS; }
            set { _RECORDSTATUS = value; }
        }

        public int OBJECTTYPE
        {
            get { return _OBJECTTYPE; }
            set { _OBJECTTYPE = value; }
        }
        public int PARNTOBJECT
        {
            get { return _PARNTOBJECT; }
            set { _PARNTOBJECT = value; }
        }
        public int SHOWTOOLBAR
        {
            get { return _SHOWTOOLBAR; }
            set { _SHOWTOOLBAR = value; }
        }
        public int MENUICON
        {
            get { return _MENUICON; }
            set { _MENUICON = value; }
        }
        public int TOOLBARICON
        {
            get { return _TOOLBARICON; }
            set { _TOOLBARICON = value; }
        }
        public int CREATEUSER
        {
            get { return _CREATEUSER; }
            set { _CREATEUSER = value; }
        }

        #endregion


        #region Methods

        public DataTable GetMenuObjects()
        {
            return GetDataTable("spGetObjects");
            

        }
        public void InsertNewMenuItem()
        {
            ExecuteCommandWithoutTransaction("spInsertObject", "@ObjectNameAR", _ObjectNameAR, "@OBJECTCOMMAND", _OBJECTCOMMAND, "@OBJECTTYPE", _OBJECTTYPE, "@PARNTOBJECT", _PARNTOBJECT
                                                               , "@SHOWTOOLBAR", _SHOWTOOLBAR, "@MENUICON", _MENUICON, "@TOOLBARICON", _TOOLBARICON, "@CREATEUSER", _CREATEUSER, "@CREATEPC", _CREATEPC, "@CREATETIMESTAMP", DateTime.Now, "@TRANSSTATUS", _TRANSSTATUS, "@RECORDSTATUS", _RECORDSTATUS);

        }

        #endregion
    }
}
