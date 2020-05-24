using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanTraDa.Model
{
    public class TableFoodBusiness
    {
        public static List<TableFood> GetListTableFood()
        {
            List<TableFood> lstTableFood = new List<TableFood>();
            DataTable dt = DataProvider.GetList("usp_GetTableList",null, true);
            foreach(DataRow item in dt.Rows)
            {
                TableFood tableFood = new TableFood(item);
                lstTableFood.Add(tableFood);
            }
            return lstTableFood;
            #region Comments

            /*
             List<TableFood> lstTableFood = new List<TableFood>();

            SqlConnection conn = new SqlConnection(DataProvider.connectionString);

            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "usp_GetTableList";
                comm.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = comm.ExecuteReader();
                TableFood objTableFood;
                while(reader.Read())
                {
                    objTableFood = new TableFood();
                    objTableFood.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                    objTableFood.Status = reader.GetString(reader.GetOrdinal("Status"));
                    objTableFood.Name = reader.GetString(reader.GetOrdinal("Name"));
                    lstTableFood.Add(objTableFood);
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

            return lstTableFood;
             */
            #endregion
        }

        public static void ChangeTableStatus(int tableId)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@TableFoodId", SqlDbType.Int);
            parameters[0].Value = tableId;

            DataProvider.ThucHien("usp_ChangeTableStatus", parameters, true);
        }

        public static void ChangeTableStatusToEmpty(int tableId)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@TableFoodId", SqlDbType.Int);
            parameters[0].Value = tableId;

            DataProvider.ThucHien("usp_ChangeTableStatusToEmpty", parameters, true);
        }

        public static bool AddTableFood(string tableName)
        {
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 100);
            pars[0].Value = tableName;

            return DataProvider.ThucHien("usp_AddTalbeFood", pars, true);
        }

        public static bool DeleteTableFood(int id)
        {
            return DataProvider.ThucHien("delete from TableFood where Id = " + id, null, false);
        }
    }
}
