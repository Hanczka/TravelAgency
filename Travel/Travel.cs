using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency
{


    public class Travel
    {

        public Travel()
        {

            Hotels=CreateHotels();

            Offers=CreateOffers();

        }

        public List<Hotel> Hotels { get; set; }

        public List<Offer> Offers { get; set; }

        public List<Hotel> CreateHotels()
        {
            Hotels = new List<Hotel>
        {

            new Hotel("Cancun Bay Resort", "Meksyk", 3, 450m),

            new Hotel("Iberostar Quetzal", "Meksyk", 5, 690m),

            new Hotel("Imperial Laguna by Faranda", "Meksyk", 2, 320m),

            new Hotel("Playacalida", "Hiszpania", 4, 620m),

            new Hotel("Playa Real Resort", "Hiszpania", 4, 380m),

            new Hotel("Palia Puerto del Sol", "Hiszpania", 3, 240m),

            new Hotel("Sea Gull", "Egipt", 3, 270m),

            new Hotel("Continental Hurghada", "Egipt", 4, 360m),

            new Hotel("Sharm Grand Plaza", "Egipt", 5, 620m),

            new Hotel("Ikaros Hotel", "Grecja", 3, 220m),

            new Hotel("Labranda Sandy Beach Resort", "Grecja", 5, 580m),

            new Hotel("Lida Corfu", "Grecja", 4, 310m),

            new Hotel("Playa Real Resort", "Tajlandia", 5, 720m),

            new Hotel("Novotel Rayong", "Tajlandia", 4, 410m),

            new Hotel("Cholchan Pattaya Resort", "Tajlandia", 3, 290m),


        };
            return Hotels;
        }

        public List<Offer> CreateOffers()
        {
            Offers = new List<Offer>
            {
                new Offer(1, Hotels[0],new DateTime(2022,06,15),7,Service.FoodList.Breakfast.ToString()),

                new Offer(2, Hotels[1],new DateTime(2022,06,15),7,Service.FoodList.AllInclusive.ToString()),

                new Offer(3, Hotels[2],new DateTime(2022,06,15),7,Service.FoodList.Breakfast.ToString()),

                new Offer(4, Hotels[3],new DateTime(2022,06,15),7,Service.FoodList.Breakfast.ToString()),

                new Offer(5, Hotels[4],new DateTime(2022,06,15),7,Service.FoodList.Breakfast.ToString()),

                new Offer(6, Hotels[5],new DateTime(2022,06,15),7,Service.FoodList.AllInclusive.ToString()),

                new Offer(7, Hotels[6],new DateTime(2022,06,15),7,Service.FoodList.Breakfast.ToString()),

                new Offer(8, Hotels[7],new DateTime(2022,06,15),7,Service.FoodList.AllInclusive.ToString()),

                new Offer(9, Hotels[8],new DateTime(2022,06,15),7,Service.FoodList.AllInclusive.ToString()),

                new Offer(10, Hotels[9],new DateTime(2022,06,15),7,Service.FoodList.Breakfast.ToString()),
            };

            return Offers;




        }


    }
}
