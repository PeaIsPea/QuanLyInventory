using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace DAO
{
    public class DatabaseConnect
    {
        string strConn = "Data Source=LAPTOP-0R646PR6\\SQLEXPRESS;Initial Catalog=qlsp;Integrated Security=True";
        protected SqlConnection conn = null; 
        public void OpenConnection()
        {

            if(conn == null)
            {
                conn = new  SqlConnection(strConn);

            }
            if(conn.State == ConnectionState.Closed) {
                conn.Open();
            
            }
            
        }

        public void CloseConnection()
        {
            if(conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
