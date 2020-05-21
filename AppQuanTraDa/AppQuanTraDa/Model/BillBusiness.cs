using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanTraDa.Model
{
    public class BillBusiness
    {
        /// <summary>
        /// Nếu thành công trả về billId, nếu không có dòng nào thỏa mãn trả về -1
        /// </summary>
        /// <param name="tableFoodId"></param>
        /// <returns></returns>
        /*public static int GetUncheckedBillIdFromTableId(int tableFoodId)
        {
            int billId = -1; ;
            string query = "select * from Bill where TableId = " + tableFoodId + "and status = 0;";
            DataTable dt = DataProvider.GetList(query, null, false);
            if(dt.Rows.Count==0)
            {
                return -1;
            }
            else
            {
                foreach(DataRow r in dt.Rows)
                {
                    Bill objBill = new Bill(dt.Rows[0]);
                    billId = objBill.Id;
                }
                return billId;
            }
        }*/
    }
}
