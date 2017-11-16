using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics;

namespace maarefa
{
    public class DBHandlerSqlServer
    {

        #region "Variable"
        private System.Data.SqlClient.SqlConnection dbConnect;
        private System.Data.SqlClient.SqlDataAdapter da;
        private System.Data.SqlClient.SqlCommand dbCommand;
        private System.Data.SqlClient.SqlTransaction dbTransaction;
        #endregion
        public static string _CnString;

        #region "Properties"
        private string _PageName = "";
        public string PageName
        {
            get { return _PageName; }
            set { _PageName = value; }
        }

        public static string Constring
        {
            get { return _CnString; }
            set { _CnString = value; }
        }

        #endregion

        #region "Constructors"
        // InitializeConnection(); 
        public DBHandlerSqlServer()
        {
        }

        ~DBHandlerSqlServer()
        {
            //#End Region 

            //#Region "Destructors" 
            CloseConnection();
            Dispose();
        }
        #endregion

        #region "Methods"

        protected bool ValidateGridValue(object gridValue)
        {
            if (gridValue != null && !object.ReferenceEquals(gridValue, System.DBNull.Value))
            {
                if (!string.IsNullOrEmpty(gridValue.ToString()))
                {
                    return true;
                }
            }
            return false;
        }

        private void InitializeConnection()
        {
            if (dbConnect == null)
            {
                dbConnect = new System.Data.SqlClient.SqlConnection();
                //dbConnect.ConnectionString = Man.ConectionsString
                dbConnect.ConnectionString = _CnString;
            }
        }

        protected void Dispose()
        {
            if (dbConnect != null)
            {
                dbConnect.Dispose();
                dbConnect = null;
            }
            if (da != null)
            {
                da.Dispose();
                da = null;
            }
            if (dbCommand != null)
            {
                dbCommand.Dispose();
                dbCommand = null;
            }
            if (dbTransaction != null)
            {
                dbTransaction.Dispose();
                dbTransaction = null;
            }
        }

        protected System.Data.DataTable InsertIntoTable(string spName)
        {
            InitializeConnection();
            da = new System.Data.SqlClient.SqlDataAdapter(spName, dbConnect);
            da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            System.Data.DataTable dt = new System.Data.DataTable();
            try
            {
                da.Fill(dt);
            }
            catch (System.Exception ex)
            {
                // Msg.[Error](ex.Message)
            }
            finally
            {
                CloseConnection();
                Dispose();
            }
            return dt;
        }

        protected System.Data.DataTable InsertIntoTable(string spName, params object[] parameters)
        {
            InitializeConnection();
            da = new System.Data.SqlClient.SqlDataAdapter(spName, dbConnect);
            da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            for (int i = 0; i <= parameters.Length - 2; i++)
            {
                da.SelectCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter(parameters[i].ToString(), parameters[i + 1]));
                i += 1;
            }
            System.Data.DataTable dt = new System.Data.DataTable();
            try
            {
                da.Fill(dt);
            }
            catch (System.Exception ex)
            {
                //Msg.[Error](ex.Message)
            }
            finally
            {
                CloseConnection();
                Dispose();
            }
            return dt;
        }

        protected System.Data.DataTable GetDataTable(string spName, params object[] parameters)
        {
            InitializeConnection();
            da = new System.Data.SqlClient.SqlDataAdapter(spName, dbConnect);
            da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            for (int i = 0; i <= parameters.Length - 2; i++)
            {
                da.SelectCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter(parameters[i].ToString(), parameters[i + 1]));
                i += 1;
            }
            System.Data.DataTable dt = new System.Data.DataTable();
            try
            {
                da.Fill(dt);
            }
            catch (System.Exception ex)
            {
                //Msg.[Error](ex.Message)
            }
            finally
            {
                CloseConnection();
                Dispose();
            }
            return dt;
        }

        protected System.Data.DataTable GetDataTable_DT(string spName, params object[] parameters)
        {
            InitializeConnection();
            da = new System.Data.SqlClient.SqlDataAdapter(spName, dbConnect);
            da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            for (int i = 0; i <= parameters.Length - 2; i++)
            {
                object obj = parameters[i + 1];
                if ((obj) is DataTable)
                {
                    //--------------To Pas Datatable------------------
                    da.SelectCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter(parameters[i].ToString(), parameters[i + 1])).SqlDbType = SqlDbType.Structured;
                    //------------------------------------------------

                }
                else
                {
                    da.SelectCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter(parameters[i].ToString(), parameters[i + 1]));

                }
                i += 1;
            }
            System.Data.DataTable dt = new System.Data.DataTable();
            try
            {
                da.Fill(dt);
            }
            catch (System.Exception ex)
            {
                //Msg.[Error](ex.Message)
            }
            finally
            {
                CloseConnection();
                Dispose();
            }
            return dt;
        }

        protected System.Data.DataTable SelectTransact(string spName, params object[] parameters)
        {
            dbCommand.Parameters.Clear();
            dbCommand.CommandText = spName;
            for (int i = 0; i <= parameters.Length - 2; i++)
            {
                dbCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter(parameters[i].ToString(), parameters[i + 1]));
                i += 1;
            }
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;
            da = new System.Data.SqlClient.SqlDataAdapter(spName, dbConnect);
            da.SelectCommand = dbCommand;
            da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            //for (int i = 0; i < parameters.Length - 1; i++) 
            //{ 
            // dbCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter(parameters[i].ToString(), parameters[i + 1])); 
            // i += 1; 
            //} 
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            //Msg.Alert(dt.Rows.Count.ToString())
            return dt;
        }

        protected System.Data.DataTable SelectTransact(string spName)
        {
            dbCommand.Parameters.Clear();
            dbCommand.CommandText = spName;
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;
            da = new System.Data.SqlClient.SqlDataAdapter(spName, dbConnect);
            da.SelectCommand = dbCommand;
            da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            System.Data.DataTable dt = new System.Data.DataTable();
            // Msg.Alert(dt.Rows.Count.ToString())
            da.Fill(dt);
            return dt;
        }

        public bool TestCon()
        {
            InitializeConnection();
            string Qury = "Select * from INV_Item ";
            da = new System.Data.SqlClient.SqlDataAdapter(Qury, dbConnect);
            da.SelectCommand.CommandType = System.Data.CommandType.Text;
            System.Data.DataTable dt = new System.Data.DataTable();
            try
            {
                da.Fill(dt);
                return true;
            }
            catch (System.Exception ex)
            {
                // Msg.Error(ex.Message); 
                return false;
            }
            finally
            {
                CloseConnection();
                Dispose();
            }
        }

        public System.Data.DataSet SelectDataSet(string spName)
        {
            InitializeConnection();
            da = new System.Data.SqlClient.SqlDataAdapter(spName, dbConnect);
            da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            System.Data.DataSet dt = new System.Data.DataSet();
            try
            {
                da.Fill(dt);
            }
            catch (System.Exception ex)
            {
                //Msg.[Error](ex.Message)
            }
            finally
            {
                CloseConnection();
                Dispose();
            }
            return dt;
        }

        public System.Data.DataSet SelectDataSet(string spName, params object[] parameters)
        {
            InitializeConnection();
            da = new System.Data.SqlClient.SqlDataAdapter(spName, dbConnect);
            da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            for (int i = 0; i <= parameters.Length - 2; i++)
            {
                da.SelectCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter(parameters[i].ToString(), parameters[i + 1]));
                i += 1;
            }
            System.Data.DataSet dt = new System.Data.DataSet();
            try
            {
                da.Fill(dt);
            }
            catch (System.Exception ex)
            {
                //Msg.[Error](ex.Message)
            }
            finally
            {
                CloseConnection();
                Dispose();
            }
            return dt;
        }

        private void OpenConnection()
        {
            if (dbConnect != null)
            {
                if (dbConnect.State != System.Data.ConnectionState.Open)
                {
                    dbConnect.Open();
                }
            }
        }

        protected void CloseConnection()
        {
            if (dbConnect != null)
            {
                if (dbConnect.State != System.Data.ConnectionState.Closed)
                {
                    dbConnect.Close();
                }
            }
        }

        protected void BeginTransaction()
        {
            InitializeConnection();
            OpenConnection();
            dbCommand = new System.Data.SqlClient.SqlCommand();
            dbCommand.Connection = dbConnect;
            dbTransaction = dbConnect.BeginTransaction();
            dbCommand.Transaction = dbTransaction;
        }

        protected void CommitTransaction()
        {
            dbTransaction.Commit();
            CloseConnection();
            Dispose();
        }

        protected void RollBackTransaction()
        {
            dbTransaction.Rollback();
            CloseConnection();
            Dispose();
        }

        protected void ExecuteCommand(string spName)
        {
            dbCommand.Parameters.Clear();
            dbCommand.CommandText = spName;
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;
            dbCommand.ExecuteNonQuery();
        }

        protected void ExecuteCommand(string spName, params object[] parameters)
        {
            dbCommand.Parameters.Clear();
            dbCommand.CommandText = spName;
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;
            for (int i = 0; i <= parameters.Length - 2; i++)
            {
                dbCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter(parameters[i].ToString(), parameters[i + 1]));
                i += 1;
            }
            dbCommand.ExecuteNonQuery();
        }

        protected void ExecuteCommand_DT(string spName, params object[] parameters)
        {
            dbCommand.Parameters.Clear();
            dbCommand.CommandText = spName;
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;

            for (int i = 0; i <= parameters.Length - 2; i++)
            {
                object obj = parameters[i + 1];
                if ((obj) is DataTable)
                {
                    //--------------To Pas Datatable------------------
                    dbCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter(parameters[i].ToString(), parameters[i + 1])).SqlDbType = SqlDbType.Structured;
                    //------------------------------------------------

                }
                else
                {
                    dbCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter(parameters[i].ToString(), parameters[i + 1]));

                }
                i += 1;
            }
            dbCommand.ExecuteNonQuery();
        }

        protected object GetSingleValuewithTransaction(string spName, params object[] parameters)
        {
            dbCommand.Parameters.Clear();
            dbCommand.CommandText = spName;
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;
            for (int i = 0; i <= parameters.Length - 2; i++)
            {
                dbCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter(parameters[i].ToString(), parameters[i + 1]));
                i += 1;
            }
            return dbCommand.ExecuteNonQuery();
        }

        protected void ExecuteCommandWithoutTransaction(string spName)
        {
            InitializeConnection();
            dbCommand = new System.Data.SqlClient.SqlCommand();
            dbCommand.Connection = dbConnect;
            dbCommand.CommandText = spName;
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;
            OpenConnection();
            dbCommand.ExecuteNonQuery();
            CloseConnection();
            Dispose();
        }

        protected void ExecuteCommandWithoutTransaction(string spName, params object[] parameters)
        {
            InitializeConnection();
            dbCommand = new System.Data.SqlClient.SqlCommand();
            dbCommand.Connection = dbConnect;
            dbCommand.CommandText = spName;
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;
            for (int i = 0; i <= parameters.Length - 2; i++)
            {
                dbCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter(parameters[i].ToString(), parameters[i + 1]));
                i += 1;
            }
            OpenConnection();
            dbCommand.ExecuteNonQuery();
            CloseConnection();
            Dispose();
        }

        protected object GetSingleValue(string spName)
        {
            InitializeConnection();
            object result = null;
            dbCommand = new System.Data.SqlClient.SqlCommand();
            dbCommand.Connection = dbConnect;
            dbCommand.CommandText = spName;
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                OpenConnection();
                result = dbCommand.ExecuteScalar();
            }
            catch (System.Exception ex)
            {
                //Msg.[Error](ex.Message)
            }
            finally
            {
                CloseConnection();
                Dispose();
            }
            return result;
        }

        protected object GetSingleValue(string spName, params object[] parameters)
        {
            InitializeConnection();
            object result = null;
            dbCommand = new System.Data.SqlClient.SqlCommand();
            dbCommand.Connection = dbConnect;
            dbCommand.CommandText = spName;
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;
            for (int i = 0; i <= parameters.Length - 2; i++)
            {
                dbCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter(parameters[i].ToString(), parameters[i + 1]));
                i += 1;
            }
            try
            {
                OpenConnection();
                result = dbCommand.ExecuteScalar();
            }
            catch (System.Exception ex)
            {
                //Msg.[Error](ex.Message)
            }
            finally
            {
                CloseConnection();
                Dispose();
            }
            return result;
        }

        protected object GetQueryValue(string Query)
        {
            InitializeConnection();
            object result = null;
            dbCommand = new System.Data.SqlClient.SqlCommand();
            dbCommand.Connection = dbConnect;
            dbCommand.CommandText = Query;
            dbCommand.CommandType = System.Data.CommandType.Text;
            try
            {
                OpenConnection();
                result = dbCommand.ExecuteScalar();
            }
            catch (System.Exception ex)
            {
                //Msg.[Error](ex.Message)
            }
            finally
            {
                CloseConnection();
                Dispose();
            }
            return result;
        }

        protected void SaveImage(string spName, string imgPrm, System.Drawing.Image imgValue, params object[] parameters)
        {
            dbCommand.Parameters.Clear();
            dbCommand.CommandText = spName;
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;
            if (imgValue != null)
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                imgValue.Save(ms, imgValue.RawFormat);
                byte[] arrImg = ms.GetBuffer();
                ms.Close();
                System.Data.SqlClient.SqlParameter sqlPrm = new System.Data.SqlClient.SqlParameter(imgPrm, System.Data.SqlDbType.Image);
                sqlPrm.Value = arrImg;
                dbCommand.Parameters.Add(sqlPrm);
            }
            for (int i = 0; i <= parameters.Length - 2; i++)
            {
                dbCommand.Parameters.Add(new System.Data.SqlClient.SqlParameter(parameters[i].ToString(), parameters[i + 1]));
                i += 1;
            }
            dbCommand.ExecuteNonQuery();
        }

        public System.Data.DataTable GetQueryResult(string query)
        {
            InitializeConnection();
            da = new System.Data.SqlClient.SqlDataAdapter(query, dbConnect);
            System.Data.DataTable dt = new System.Data.DataTable();
            try
            {
                da.Fill(dt);
            }
            catch (System.Exception ex)
            {
                //Msg.[Error](ex.Message)
            }
            finally
            {
                CloseConnection();
                Dispose();
            }
            return dt;
        }

        public void ExecuteQuery(string query)
        {
            dbCommand.CommandText = query;
            dbCommand.ExecuteNonQuery();

        }

        public void ExecuteQueryWithoutTransaction(string query)
        {
            InitializeConnection();
            dbCommand = new System.Data.SqlClient.SqlCommand();
            dbCommand.Connection = dbConnect;
            dbCommand.CommandText = query;
            OpenConnection();
            dbCommand.ExecuteNonQuery();
            CloseConnection();
            Dispose();

        }

        //Public Function GerPermistion(ByVal Page As String) As Integer
        //    Dim tbl As System.Data.DataTable = Me.GetDataTable("[USR_FormPermission_SelectUserPermission]", "@UserCode", User.UserId, "@PageCode", Page)
        //    If tbl.Rows.Count = 0 Then
        //        Return Permission.Full
        //    Else
        //        Return System.Convert.ToInt32(tbl.Rows(0)("Permission"))
        //    End If
        //End Function
        #endregion

    }
}