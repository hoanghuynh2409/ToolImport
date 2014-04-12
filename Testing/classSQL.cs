using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class DB
    {
        public static void ExecuteSQL(String Sql, SqlConnection dbconn)
        {
            //huynh add
            SqlCommand cmd = new SqlCommand(Sql, dbconn);
            try
            {
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                cmd.Dispose();
                throw (ex);
            }
        }


        public static class Scalar<returnType>
        {
            public static returnType ExecuteScalar(SqlCommand cmd)
            {
                 return (returnType)cmd.ExecuteScalar();
            }

        }

        public static DataSet GetTable(String Sql,String tablename, SqlConnection dbconn)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(Sql, dbconn);
            da.Fill(ds, tablename);
            return ds;
        }
    }

    class classSQL
    {

    }
}
