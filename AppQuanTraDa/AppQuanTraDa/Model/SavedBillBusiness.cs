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
        public static void AddSavedBill(string tableName, double totalPrice, DateTime dateCheckOut)
        {
            SqlParameter[] pars = new SqlParameter[3];

            pars[0] = new SqlParameter("@TableName", SqlDbType.NVarChar, 100);
            pars[0].Value = tableName;

            pars[1] = new SqlParameter("@TotalPrice", SqlDbType.Float);
            pars[1].Value = float.Parse(totalPrice.ToString());

            pars[2] = new SqlParameter("@DateCheckOut", SqlDbType.DateTime);
            pars[2].Value = dateCheckOut;

            DataProvider.ThucHien("usp_AddSavedBill", pars, true);
        }

        public static List<SavedBill> GetListSavedBill()
        {
            DataTable dt = DataProvider.GetList("Select * from SavedBill", null, false);
            List<SavedBill> lstSavedBill = new List<SavedBill>();

            foreach(DataRow row in dt.Rows)
            {
                SavedBill obj = new SavedBill(row);
                lstSavedBill.Add(obj);
            }
            return lstSavedBill;
        }
    }
}
