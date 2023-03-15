using QuanLyShop.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShop.DAO
{
    internal class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return instance; }
            private set { instance = value; }
        }

        private BillDAO() { }

        public int GetUncheckBillIDByRoomID(int id)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("select * from dbo.Bill WHERE idRoom = " + id + " AND status = 0");
            if(data.Rows.Count> 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }

        public void CheckOut(int id, int discount)
        {
            string query = "UPDATE dbo.Bill SET status = 1, " + "discount = " + discount + " WHERE id = " + id;
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        
        public void InsertBill(int id)
        {
            DataProvider.Instance.ExcuteNonQuery("exec USP_InsertBill @idRoom", new object[]{id});
        }

        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExcuteScalar("SELECT MAX(id) FROM dbo.Bill");
            }
            catch
            {
                return 1;
            }
        }
    }
}
