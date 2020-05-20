using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanTraDa.Model
{
    public class DataProvider
    {
        public static string connectionString = @"Data Source=DESKTOP-G2C1736\SQLEXPRESS;Initial Catalog=AppBanTraDa;Integrated Security=True";

        public static DataTable GetList(string query, SqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            { 
                conn.Open();

                SqlCommand comm = new SqlCommand(query, conn);

                if(parameters!=null)
                {
                    string[] lstPara = query.Split(' ');
                    int i = 0;
                    foreach(string item in lstPara)
                    {
                        if(item.Contains("@"))
                        {
                            comm.Parameters.AddWithValue(item, parameters[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(comm);

                adapter.Fill(dt);

                conn.Close();
            }
            return dt;
        }

    }
}
