using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanTraDa.Model
{
    public class Bill
    {
        private int id;
        private DateTime dateCheckIn;
        private DateTime dateCheckOut;
        private int tableId;
        private int status;

        public Bill() { }

        public Bill(int id, DateTime dateCheckIn, DateTime dateCheckOut, int tableId, int status)
        {
            this.Id = id;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
            this.TableId = tableId;
            this.Status = status;
        }

        public Bill(DataRow row)
        {
            this.Id = (int)row["Id"];
            this.DateCheckIn = (DateTime)row["DateCheckIn"];
            this.DateCheckOut = (DateTime)row["DateCheckOut"];
            this.TableId = (int)row["TableId"];
            this.Status = (int)row["Status"];
        }

        public int Id { get => id; set => id = value; }
        public DateTime DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public int TableId { get => tableId; set => tableId = value; }
        public int Status { get => status; set => status = value; }
    }
}
