using System;
using System.Data;
using System.Data.SqlClient;

namespace A3DSQLServices
{
    public class InfSQLServices
    {
        #region "Class Initialization"
        /*****************************************************************/
        
        private static InfSQLServices _iInfSQLServices = null;
        public InfSQLServices()

        {

        }
        public static InfSQLServices _IInfSQLServices
        {
            get
            {
                if (_iInfSQLServices == null)
                {
                    _iInfSQLServices = new InfSQLServices();
                }
                
                return _iInfSQLServices;
            }

        }
        /*****************************************************************/
        #endregion
        #region "Variable Declaration"
        public string InfSQLConnectionString { get; set; }=default;
        public SqlDataAdapter SqlDa = new SqlDataAdapter();
        public SqlCommand SqlCommd = new SqlCommand();
        public SqlTransaction SqlTrans = null;
       
        #endregion
        #region "Function"
        public DataTable InfExecuteDataTable(string SqlQuery, bool lFetchSchema = true)
        {
            DataTable DtResult = new DataTable();
            //
            try
            {
                using (SqlConnection SQLConn = new SqlConnection(InfSQLConnectionString))
                {
                    SqlDa = new SqlDataAdapter(SqlQuery, SQLConn);
                    if (lFetchSchema == true) { SqlDa.FillSchema(DtResult, SchemaType.Source); }
                    SqlDa.Fill(DtResult);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

            return DtResult;
        }
        public DataTable InfExecuteDataTable(string SqlQuery,SqlConnection SQLConn, SqlTransaction sqlTrans)
        {
            DataTable DtResult = new DataTable();
            //
            try
            {


                SqlCommd = new SqlCommand
                {
                    Connection = SQLConn,
                    Transaction = sqlTrans,
                    CommandText = SqlQuery,
                    CommandType = CommandType.Text
                };

                SqlDa = new SqlDataAdapter(SqlCommd);
                SqlDa.FillSchema(DtResult, SchemaType.Source);
                SqlDa.Fill(DtResult);

            }
            catch (Exception ex)
            {

                throw ex;
            }

            return DtResult;
        }
        public int InfExecuteQuery(string SqlQuery)
        {
            int IResult = 0;

            try
            {

                using (SqlConnection SQLConn = new SqlConnection(InfSQLConnectionString))
                {
                    if (SQLConn.State != ConnectionState.Open) { SQLConn.Open(); }
                    SqlCommd = new SqlCommand
                    {
                        Connection = SQLConn,
                        CommandType = CommandType.Text,
                        CommandText = SqlQuery,
                        CommandTimeout = 0
                    };
                    //SqlCommd.BeginExecuteNonQuery();
                    IResult = SqlCommd.ExecuteNonQuery();
                    //if (SQLConn.State != ConnectionState.Closed) { SQLConn.Close(); }
                    //SqlCommd.EndExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

            return IResult;
        }
        public int InfExecuteTranstion(string SqlQuery, SqlConnection SQLConn, SqlTransaction SqlTrans)
        {
            int iReturn = 0;
            try
            {
                // openConnection();
                using (SqlCommd = new SqlCommand(SqlQuery, SQLConn, SqlTrans))
                {
                    iReturn = SqlCommd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return iReturn;
        }
        public int InfUpdateDataAdapter(string SqlQuery, DataTable DtSourceDataTable)
        {
            int iReturn = 0;
            //
            DataTable DtDummyDataTable = new DataTable();
            try
            {
                using (SqlConnection SQLConn = new SqlConnection(InfSQLConnectionString))
                {
                    if (SQLConn.State != ConnectionState.Open) { SQLConn.Open(); }
                    SqlCommd = new SqlCommand
                    {
                        Connection = SQLConn,
                        CommandType = CommandType.Text,
                        CommandText = SqlQuery,
                        CommandTimeout = 0
                    };
                    SqlDa = new SqlDataAdapter(SqlCommd);

                    SqlDa.FillSchema(DtDummyDataTable, SchemaType.Source);
                    SqlDa.Fill(DtDummyDataTable);

                    SqlCommandBuilder combuild = new SqlCommandBuilder(SqlDa);
                    SqlDa.InsertCommand = combuild.GetInsertCommand();
                    SqlDa.UpdateCommand = combuild.GetUpdateCommand();
                    SqlDa.DeleteCommand = combuild.GetDeleteCommand();
                    DtDummyDataTable = DtSourceDataTable.GetChanges().Copy();
                    SqlDa.AcceptChangesDuringUpdate = true;
                    iReturn = SqlDa.Update(DtDummyDataTable);
                }
                return iReturn;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void InfUpdateDataAdapter(string SqlQuery, DataTable DtSourceDataTable, SqlConnection SQLConn, SqlTransaction sqlTrans)
        {
            try
            {

                DataTable dtDummy = new DataTable();
                SqlCommd = new SqlCommand
                {
                    Connection = SQLConn,
                    CommandType = CommandType.Text,
                    CommandText = SqlQuery,
                    CommandTimeout = 0
                };
                SqlDa = new SqlDataAdapter(SqlCommd);

                SqlDa.FillSchema(dtDummy, SchemaType.Source);
                SqlDa.Fill(dtDummy);

                SqlCommandBuilder combuild = new SqlCommandBuilder(SqlDa);
                SqlDa.InsertCommand = combuild.GetInsertCommand();
                SqlDa.UpdateCommand = combuild.GetUpdateCommand();
                SqlDa.DeleteCommand = combuild.GetDeleteCommand();
                dtDummy = DtSourceDataTable.GetChanges().Copy();
                SqlDa.AcceptChangesDuringUpdate = true;
                SqlDa.Update(dtDummy);

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        #endregion

    }
}
