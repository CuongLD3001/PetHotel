using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShop.DTO
{
    public class Pet
    {
        private int id;
        private string name;
        private int categoryId;
        private float price;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int CategoryId { get => categoryId; set => categoryId = value; }
        public float Price { get => price; set => price = value; }

        public Pet(int id, string name, int categoryId, float price)
        {
            this.Id = id;
            this.Name = name;
            this.CategoryId = categoryId;
            this.Price = price;
        }

        public Pet(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name = row["name"].ToString();
            this.CategoryId = (int)row["idCategory"];
            this.Price = Convert.ToSingle(row["price"]);
        }
    }
}
