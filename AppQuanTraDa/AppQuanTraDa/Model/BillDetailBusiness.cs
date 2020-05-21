using System;
using System.Collections.Generic;
using System.Data;
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
    }
}
