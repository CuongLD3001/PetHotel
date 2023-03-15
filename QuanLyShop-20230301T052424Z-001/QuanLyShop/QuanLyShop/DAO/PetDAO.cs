using QuanLyShop.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShop.DAO
{
    public class PetDAO
    {
        private static PetDAO instance;

        public static PetDAO Instance
        {
            get { if (instance == null) instance = new PetDAO(); return instance; }
            private set { instance = value; }
        }

        private PetDAO() { }

        public List<Pet> GetPetByCategoryId(int id)
        {
            List<Pet> list = new List<Pet>();

            string query = "SELECT * FROM PET WHERE idCategory = " + id;

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Pet pet = new Pet(item);
                list.Add(pet);
            }

            return list;
        }
    }
}
