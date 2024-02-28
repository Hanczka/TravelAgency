using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency
{
    public static class Service
    {
        public static List<int> GetNumbers()
        {
            var numbers = new List<int>();
            var random = new Random();
            while (numbers.Count < 3)
            {
                int number = random.Next(1, 6);
                if (!numbers.Contains(number))
                    numbers.Add(number);
            }
            return numbers;
        }

        public enum FoodList
        {
            AllInclusive,
            Breakfast,

        }
       
        public static Offer FindOffer(Travel travel,int number)
        {
            foreach (Offer offer in travel.Offers)
            {
                if (offer.Number == number) return offer;
            }return null;

        }
    }
}
