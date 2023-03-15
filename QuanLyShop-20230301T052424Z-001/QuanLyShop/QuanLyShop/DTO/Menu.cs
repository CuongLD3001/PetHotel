using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShop.DTO
{
    public class Menu
    {
        private string petName;
        private int count;
        private float price;
        private float totalPrice;


        
        public int Count { get => count; set => count = value; }
        public float Price { get => price; set => price = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
        public string PetName { get => petName; set => petName = value; }

        public Menu(string petName, int count, float price, float totalPrice)
        {
            this.PetName = petName;
            this.Count = count;
            this.Price = price;
            this.TotalPrice = totalPrice;
        }

        public Menu(DataRow row)
        {
            this.PetName = row["name"].ToString();
            this.Count = (int)row["count"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
            this.TotalPrice = (float)Convert.ToDouble(row["totalPrice"].ToString());
        }
    }
}
