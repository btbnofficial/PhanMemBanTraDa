using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanTraDa.Model
{
    public class FoodBusiness
    {
        public static List<Food> GetFoodList()
        {
            List<Food> lstFood = new List<Food>();

            DataTable dt = DataProvider.GetList("Select * from Food", null, false);

            foreach(DataRow row in dt.Rows)
            {
                Food objFood = new Food(row);
                lstFood.Add(objFood);
            }

            return lstFood;
        }
    }
}
