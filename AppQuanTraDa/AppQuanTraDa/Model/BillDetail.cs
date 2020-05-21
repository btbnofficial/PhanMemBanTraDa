using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanTraDa.Model
{
    public class BillDetail
    {
        private int id;
        private int billId;
        private int foodId;
        private int count;

        public BillDetail() { }

        public BillDetail(int id, int billId, int foodId, int count)
        {
            this.Id = id;
            this.BillId = billId;
            this.FoodId = foodId;
            this.Count = count;
        }

        public BillDetail(DataRow row)
        {
            this.Id = (int)row["Id"];
            this.BillId = (int)row["BillId"];
            this.FoodId = (int)row["FoodId"];
            this.Count = (int)row["Count"];
        }

        public int Id { get => id; set => id = value; }
        public int BillId { get => billId; set => billId = value; }
        public int FoodId { get => foodId; set => foodId = value; }
        public int Count { get => count; set => count = value; }
    }
}
