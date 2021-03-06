﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanTraDa.Model
{
    public class Menu
    {
        private string foodName;
        private double price;
        private int count;
        private double totalPrice;

        public Menu() { }

        public Menu(string foodName,double price, int count, double totalPrice)
        {
            this.FoodName = foodName;
            this.Count = count;
            this.Price = price;
            this.TotalPrice = totalPrice;
        }

        public Menu(DataRow row)
        {
            this.FoodName = row["FoodName"].ToString();
            this.Price = Double.Parse(row["Price"].ToString());
            this.Count = (int)row["Count"];
            this.TotalPrice = Double.Parse(row["TotalPrice"].ToString());
        }

        public string FoodName { get => foodName; set => foodName = value; }
        public int Count { get => count; set => count = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }
        public double Price { get => price; set => price = value; }
    }
}
