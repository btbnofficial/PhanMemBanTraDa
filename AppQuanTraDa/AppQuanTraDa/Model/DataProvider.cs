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

        public static DataTable GetList(string query, SqlParameter[] parameters = null, bool isThuTuc = false)
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = query;

                if(isThuTuc)
                {
                    comm.CommandType = CommandType.StoredProcedure;
                }
                else
                {
                    comm.CommandType = CommandType.Text;
                }

                if(parameters!=null && parameters.Length>0)
                {
                    comm.Parameters.AddRange(parameters);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public static bool ThucHien(string query, SqlParameter[] pars = null, bool isThuTuc = false)
        {
            bool isThucHien = false;

            SqlConnection conn = new SqlConnection(connectionString);
            
            try
            {
                conn.Open();

                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = query;
                if(isThuTuc)
                {
                    comm.CommandType = CommandType.StoredProcedure;
                }
                else
                {
                    comm.CommandType = CommandType.Text;
                }

                if(pars!=null && pars.Length>0)
                {
                    comm.Parameters.AddRange(pars);
                }

                isThucHien = (comm.ExecuteNonQuery()>0) ? true : false;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            return isThucHien;
        }
    }
}
