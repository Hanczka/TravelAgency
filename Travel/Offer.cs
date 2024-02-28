using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency
{
    public class Offer
    {
        public Offer(int number, Hotel hotel, DateTime dateStart, int numberOfDays, string food)
        {
            Number = number;
            Hotel = hotel;
            DateStart = dateStart;
            NumberOfDays = numberOfDays;
            Food = food;
        }

        public int Number { get; set; }
        public Hotel Hotel { get; set; }
        public DateTime DateStart { get; set; }
        public int NumberOfDays { get; set; }
        public string Food {  get; set; }
       
   
        public decimal CalculatePrice (int children, int adults)
        {
            decimal price = 0;
            price += NumberOfDays * Hotel.Price;

            int day = 4;
            switch (Hotel.Country)
            {
                case "Egipt" :
                    price += 1500m;
                    break;

                case "Meksyk" :
                    price += 2500m;
                    break;

                case "Hiszpania":
                    price += 1000m;
                    break;

                case "Grecja":
                    price += 1000m;
                    break;

                case "Tajlandia":
                    price += 2000m;
                    break;
            }
            if (Food == Service.FoodList.AllInclusive.ToString())
            {
                price += 1200m;  
            }
            price += adults * price;
            price += children * price / 2;
                return price;
        
        }

       
            
     
        public DateTime CalculateDateEnd() {
            DateTime dateEnd = new DateTime();
            dateEnd = DateStart.AddDays(NumberOfDays);
            return dateEnd;

        }
    }
}
