using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanTraDa.Model
{
    public class BillDetailBusiness
    {
        /*public static List<BillDetail> GetListBillDetailFromBillId(int billId)
        {
            List<BillDetail> lstBillDetail = new List<BillDetail>();
            string query = "select * from BillDetail where BillId = " + billId + ";";
            DataTable dt = DataProvider.GetList(query, null, false);
            foreach(DataRow row in dt.Rows)
            {
                BillDetail objBillDetail = new BillDetail(row);
                lstBillDetail.Add(objBillDetail);
            }
            return lstBillDetail;
        }*/

        public static void AddBillDetail(int billId, int foodId, int count)
        {
            SqlParameter[] pars = new SqlParameter[3];
            pars[0] = new SqlParameter("@BillId", SqlDbType.Int);
            pars[0].Value = billId;

            pars[1] = new SqlParameter("@FoodId", SqlDbType.Int);
            pars[1].Value = foodId;

            pars[2] = new SqlParameter("@Count", SqlDbType.Int);
            pars[2].Value = count;

            DataProvider.ThucHien("usp_AddBillDetail", pars, true);
        }
    }
}
