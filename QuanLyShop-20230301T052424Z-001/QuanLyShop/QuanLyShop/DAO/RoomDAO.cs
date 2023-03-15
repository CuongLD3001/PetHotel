using QuanLyShop.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShop.DAO
{
    internal class RoomDAO
    {
        private static RoomDAO instance;

        public static RoomDAO Instance
        {
            get { if (instance == null) instance = new RoomDAO(); return instance; }
            private set { instance = value; }
        }

        public static int RoomWidth = 100;
        public static int RoomHeight = 100;

        private RoomDAO() { }

        public void SwitchRoom(int id1, int id2)
        {
            DataProvider.Instance.ExcuteQuery("USP_SwitchRoom @idRoom1 , @idRoom2", new object[]{id1,id2});
        }

        public List<Room> LoadRoomList()
        {
            List<Room> roomList = new List<Room>();

            DataTable data = DataProvider.Instance.ExcuteQuery("dbo.USP_GetRoomList");

            foreach (DataRow item in data.Rows) {
                Room room = new Room(item);
                roomList.Add(room);
            }

            return roomList;
        }
    }
}
