using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShop.DTO
{
    public class BillInfo
    {
        private int id;
        private int billID;
        private int petID;
        private int count;

        public int Id { get => id; set => id = value; }
        public int BillID { get => billID; set => billID = value; }
        public int PetID { get => petID; set => petID = value; }
        public int Count { get => count; set => count = value; }

        public BillInfo(int id, int billID, int petID, int count)
        {
            Id = id;
            BillID = billID;
            PetID = petID;
            Count = count;
        }

        public BillInfo(DataRow row)
        {
            this.Id = (int)row["id"];
            this.BillID = (int)row["idbill"];
            this.PetID = (int)row["idpet"];
            this.Count = (int)row["count"];
        }
    }
}
