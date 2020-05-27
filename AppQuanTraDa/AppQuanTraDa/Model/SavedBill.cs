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
        private double totalPrice;
        private DateTime dateCheckOut;

        public SavedBill() { }

        public SavedBill(string tableName, double totalPrice, DateTime dateCheckOut)
        {
            this.TableName = tableName;
            this.TotalPrice = totalPrice;
            this.DateCheckOut = dateCheckOut;
        }

        public SavedBill(DataRow row)
        {
            this.TableName = row["TableName"].ToString();
            this.TotalPrice = Double.Parse(row["TotalPrice"].ToString());
            this.DateCheckOut = DateTime.Parse(row["DateCheckOut"].ToString());
        }

        public string TableName { get => tableName; set => tableName = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }
        public DateTime DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
    }
}
