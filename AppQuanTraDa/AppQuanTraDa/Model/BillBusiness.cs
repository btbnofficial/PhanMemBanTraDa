using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        public static Bill GetUncheckedBillFromTableId(int tableFoodId)
        {
            Bill bill = null;
            string query = "select * from Bill where TableId = " + tableFoodId + "and status = 0;";
            DataTable dt = DataProvider.GetList(query, null, false);
            if(dt.Rows.Count==0)
            {
                return null;
            }
            else
            {
                foreach(DataRow r in dt.Rows)
                {
                    bill = new Bill(dt.Rows[0]);
                }
                return bill;
            }
        }

        public static int GetUncheckedBillIdFromTableId(int tableFoodId)
        {
            Bill bill = null;
            int id = 0;
            string query = "select * from Bill where TableId = " + tableFoodId + "and status = 0;";
            DataTable dt = DataProvider.GetList(query, null, false);
            if (dt.Rows.Count == 0)
            {
                return -1;
            }
            else
            {
                foreach (DataRow r in dt.Rows)
                {
                    bill = new Bill(dt.Rows[0]);
                    id = bill.Id;
                }
            return id;
            }
        }

        public static void AddBill(int tableId)
        {
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("TableId", SqlDbType.Int);
            pars[0].Value = tableId;

            DataProvider.ThucHien("usp_AddBill", pars, true);
        }

        public static List<Bill> GetListBill()
        {
            List<Bill> lstBill = new List<Bill>();

            DataTable dt = DataProvider.GetList("Select * from Bill", null, false);

            foreach (DataRow row in dt.Rows)
            {
                Bill objBill = new Bill(row);
                lstBill.Add(objBill);
            }

            return lstBill;
        }

        public static int GetMaxBillId()
        {
            int max = 0;

            List<Bill> lstBill = new List<Bill>();

            DataTable dt = DataProvider.GetList("Select * from Bill", null, false);

            foreach (DataRow row in dt.Rows)
            {
                Bill objBill = new Bill(row);

                if(max<objBill.Id)
                {
                    max = objBill.Id;
                }
            }

            return max;
        }

        public static void CheckOut(int billId)
        {
            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@BillId", SqlDbType.Int);
            pars[0].Value = billId;

            DataProvider.ThucHien("usp_CheckOutBill", pars, true);
        }
    }
}
