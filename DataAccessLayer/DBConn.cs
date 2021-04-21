using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DBConn
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5TNOU3L\SQLEXPRESS;Initial Catalog=shopping;Integrated Security=True");
        public bool UDI(string q)
        {
            try
            {
                conn.Open();
                SqlCommand cmmd = new SqlCommand(q, conn);

                cmmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

        }

        public DataTable Search(string q)
        {

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(q, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {
                return null;

            }
            finally
            {
                conn.Close();
            }
            
        }

        public SqlDataReader read(String q)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(q, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                return dr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
