using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        public static Food GetFoodFromId(int foodId)
        {
            DataTable dt = DataProvider.GetList("Select * from Food where Id = "+foodId, null, false);

            foreach (DataRow row in dt.Rows)
            {
                return new Food(row);
            }
            return null;
        }

        public static bool DeleteFood(int foodId)
        {
            SqlParameter[] pars = new SqlParameter[1];

            pars[0] = new SqlParameter("@FoodId", SqlDbType.Int);
            pars[0].Value = foodId;

            return DataProvider.ThucHien("usp_DeleteFood", pars, true);
        }

        public static bool AddFood(string foodName, double foodPrice)
        {
            SqlParameter[] pars = new SqlParameter[2];

            pars[0] = new SqlParameter("@Name", SqlDbType.NVarChar,100);
            pars[0].Value = foodName;

            pars[1] = new SqlParameter("@Price", SqlDbType.Float);
            pars[1].Value = float.Parse(foodPrice.ToString());

            return DataProvider.ThucHien("usp_AddFood", pars, true);
        }

        public static bool EditFoodPrice(int foodId, double foodPrice)
        {
            SqlParameter[] pars = new SqlParameter[2];

            pars[0] = new SqlParameter("@Price", SqlDbType.Float);
            pars[0].Value = float.Parse(foodPrice.ToString());

            pars[1] = new SqlParameter("@Id", SqlDbType.Int);
            pars[1].Value = foodId;

            return DataProvider.ThucHien("usp_EditFoodPrice", pars, true);
        }
    }
}
