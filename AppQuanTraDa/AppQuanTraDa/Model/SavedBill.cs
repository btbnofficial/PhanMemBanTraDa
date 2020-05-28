using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanTraDa.Model
{
    public class SavedBill
    {
        private string tableName;
        private int count;
        private double totalPrice;
        private DateTime dateCheckOut;
        private string foodName;

        public SavedBill() { }

        public SavedBill(string tableName, int count, double totalPrice, DateTime dateCheckOut,string foodName)
        {
            this.TableName = tableName;
            this.Count = count;
            this.TotalPrice = totalPrice;
            this.DateCheckOut = dateCheckOut;
            this.FoodName = foodName;
        }

        public SavedBill(DataRow row)
        {
            this.TableName = row["TableName"].ToString();
            this.Count = (int)row["Count"];
            this.TotalPrice = Double.Parse(row["TotalPrice"].ToString());
            this.DateCheckOut = DateTime.Parse(row["DateCheckOut"].ToString());
            this.FoodName = row["FoodName"].ToString();
        }

        public string TableName { get => tableName; set => tableName = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }
        public DateTime DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public string FoodName { get => foodName; set => foodName = value; }
        public int Count { get => count; set => count = value; }
    }
}
