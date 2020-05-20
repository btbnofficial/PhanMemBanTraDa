using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanTraDa.Model
{
    class AccountBusiness
    {
        public static List<Account> LayDanhSachAccount()
        {
            List<Account> lstAccount = new List<Account>();

            SqlConnection conn = new SqlConnection(DataProvider.connectionString);

            try
            {
                conn.Open();

                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "usp_GetListAccount";

                SqlDataReader reader = comm.ExecuteReader();

                Account objAccount;
                while(reader.Read())
                {
                    objAccount = new Account();
                    objAccount.Username = reader.GetString(reader.GetOrdinal("Username"));
                    objAccount.Type = reader.GetInt32(reader.GetOrdinal("Type"));
                    lstAccount.Add(objAccount);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            return lstAccount;
        }

        
    }
}
