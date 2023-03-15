using QuanLyShop.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShop.DAO
{
    internal class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return instance; }
            private set { instance = value; }
        }

        private MenuDAO() { }

        public List<Menu> GetListMenuByTable(int id)
        {
            List<Menu> listMenu = new List<Menu>();
            string query = "SELECT p.name, bi.count, p.price, p.price*bi.count as totalPrice FROM dbo.Bill as b, dbo.BillInfo as bi, dbo.Pet as p\r\nWHERE bi.idBill=b.id AND bi.idPet = p.id and b.status = 0 and b.idRoom = " + id;

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }

            return listMenu;

        }
    }
}
