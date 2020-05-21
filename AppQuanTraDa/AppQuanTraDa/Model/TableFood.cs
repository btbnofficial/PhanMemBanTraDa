using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanTraDa.Model
{
    public class TableFood
    {
        private int id;
        private string status;
        private string name;

        public TableFood()
        {

        }

        public TableFood(int id, string name, string status)
        {
            this.Id = id;
            this.Status = status;
            this.Name = name;
        }

        public TableFood(DataRow row)
        {
            this.Id = (int)row["Id"];
            this.Name = row["Name"].ToString();
            this.Status = row["Status"].ToString();
        }

        public int Id { get => id; set => id = value; }
        public string Status { get => status; set => status = value; }
        public string Name { get => name; set => name = value; }
    }
}
