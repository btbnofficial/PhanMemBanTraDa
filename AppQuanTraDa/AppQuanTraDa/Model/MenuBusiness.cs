using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanTraDa.Model
{
    public class MenuBusiness
    {
        public static List<Menu> GetListMenuFromTableId(int tableId)
        {
            List<Menu> lstMenu = new List<Menu>();

            string query = "select Food.Name as FoodName, BillDetail.Count as Count, Food.Price as Price, Food.Price*BillDetail.count as TotalPrice from BillDetail, Bill, Food " +
                "where BillDetail.BillId = Bill.Id and BillDetail.FoodId = Food.Id and Bill.TableId = " + tableId;

            DataTable dt = DataProvider.GetList(query, null, false);
            foreach(DataRow row in dt.Rows)
            {
                Menu objMenu = new Menu(row);
                lstMenu.Add(objMenu);
            }

            return lstMenu;
        }
    }
}
