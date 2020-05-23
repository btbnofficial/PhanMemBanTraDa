using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanTraDa.Model
{
    public class Food
    {
        private int id;
        private string name;
        private double price;

        public Food() { }

        public Food(int id, string name, double price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }

        public Food(DataRow row)
        {
            this.Id = (int)row["Id"];
            this.Name = row["Name"].ToString();
            this.Price = Double.Parse(row["Price"].ToString());
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
    }
}
