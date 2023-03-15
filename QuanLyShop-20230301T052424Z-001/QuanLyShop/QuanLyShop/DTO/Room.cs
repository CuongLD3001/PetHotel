using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShop.DTO
{
    public class Room
    {
       
        

        private int id;
        private string name;
        private string status;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }

        public Room() { }

        public Room(int id, string name, string status)
        {
            this.Id = id;
            this.Name = name;
            this.Status = status;
        }

        public Room(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Status = row["status"].ToString();
        }
    }
}
