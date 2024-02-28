using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency
{
    public class Hotel
    {
        public Hotel(string name, string country, int category, decimal price)
        {
            Name = name;
            Country = country;
            Category = category;
            Price = price;
        }

        public string Name { get; set; }
        public string Country {  get; set; }
        public int Category {  get; set; }
        public decimal Price { get; set; }
        public string Stars()
        {
            string result = "";
            for (int i = 0; i < Category; i++) 
            {
                result += "*";
            }
            return result;
        }      
    }
}
