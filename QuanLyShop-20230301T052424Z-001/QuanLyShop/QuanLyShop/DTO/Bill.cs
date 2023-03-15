using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShop.DTO
{
    internal class Bill
    {
        private int id;
        public int ID { get => id; set => id = value; }
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public int Status { get => status; set => status = value; }
        public int Discount { get => discount; set => discount = value; }

        private DateTime? dateCheckIn;

        private DateTime? dateCheckOut;

        private int status;

        private int discount;

        public Bill(int id, DateTime? dateCheckIn, DateTime? dateCheckOut, int status, int discount = 0)
        {
            this.ID = id;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
            this.Status = status;
            this.Discount = discount;
        }

        public Bill(DataRow row) {
            this.ID = (int)row["id"];
            this.DateCheckIn = (DateTime?)row["dateCheckIn"];
            var dateCheckOutTemp = row["dateCheckOut"];
            if(dateCheckOutTemp.ToString() != "")
            {
                this.dateCheckOut =(DateTime?)dateCheckOutTemp; 
            }
            this.Status = (int)row["status"];
            this.Discount = (int)row["discount"];
        }
    }
}
