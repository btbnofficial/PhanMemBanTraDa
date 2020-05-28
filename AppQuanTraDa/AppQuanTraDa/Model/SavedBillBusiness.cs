using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanTraDa.Model
{
    public class SavedBillBusiness
    {
        public static void AddSavedBill(string tableName, int count, double totalPrice, DateTime dateCheckOut, string foodName)
        {
            SqlParameter[] pars = new SqlParameter[5];

            pars[0] = new SqlParameter("@TableName", SqlDbType.NVarChar, 100);
            pars[0].Value = tableName;

            pars[1] = new SqlParameter("@Count", SqlDbType.Int);
            pars[1].Value = count;

            pars[2] = new SqlParameter("@TotalPrice", SqlDbType.Float);
            pars[2].Value = float.Parse(totalPrice.ToString());

            pars[3] = new SqlParameter("@DateCheckOut", SqlDbType.DateTime);
            pars[3].Value = dateCheckOut;

            pars[4] = new SqlParameter("@FoodName", SqlDbType.NVarChar, 100);
            pars[4].Value = foodName;

            DataProvider.ThucHien("usp_AddSavedBill", pars, true);
        }

        public static List<SavedBill> GetListSavedBill(DateTime fromDate, DateTime toDate)
        {
            DataTable dt = DataProvider.GetList("Select * from SavedBill where DateCheckOut >= '"+fromDate+"' and DateCheckOut <= '"+toDate+"'", null, false);
            List<SavedBill> lstSavedBill = new List<SavedBill>();

            foreach(DataRow row in dt.Rows)
            {
                SavedBill obj = new SavedBill(row);
                lstSavedBill.Add(obj);
            }
            return lstSavedBill;
        }

        public static List<SavedBill> GetListSavedBillFromFoodName(DateTime fromDate, DateTime toDate, string foodName)
        {
            DataTable dt = DataProvider.GetList("Select * from SavedBill where DateCheckOut >= '" + fromDate + "' and DateCheckOut <= '" + toDate + "' and SavedBill.FoodName = N'"+foodName+"'", null, false);
            List <SavedBill> lstSavedBill = new List<SavedBill>();

            foreach (DataRow row in dt.Rows)
            {
                SavedBill obj = new SavedBill(row);
                lstSavedBill.Add(obj);
            }
            return lstSavedBill;
        }
    }
}
