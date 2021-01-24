using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HospitalAdmissionSystem.DataLayer.DBOperations
{
    class DBHelper
    {
        public static SqlConnection GetConnectionString()
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=HospitalAdmissionSystem;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            return con;
        }
    }
}
