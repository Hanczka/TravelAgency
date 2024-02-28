using TravelAgency;

Console.WriteLine("DZISIEJSZE PROMOWANE OFERTY!");
List<int> randomNumer = Service.GetNumbers();

Travel travel = new Travel();
//List<Hotel>Hotels = travel.CreateHotels();
//List<Offer> offer = new List<Offer>();


foreach (int num in randomNumer)
{

    Console.WriteLine("---------------------");
    Console.WriteLine("Numer: " + (travel.Offers[num].Number).ToString());
    Console.WriteLine("Kraj: " + travel.Offers[num].Hotel.Country);
    Console.WriteLine("Termin: " + travel.Offers[num].DateStart.ToShortDateString() + " - " + travel.Offers[num].CalculateDateEnd().ToShortDateString()+ " ("+ travel.Offers[num].NumberOfDays.ToString()+" dni) ");
    Console.WriteLine("Hotel: " + travel.Offers[num].Hotel.Name +" ("+ travel.Offers[num].Hotel.Stars()+")");
    Console.WriteLine("Wyżywienie: " + travel.Offers[num].Food);
    Console.WriteLine("Cena: " + travel.Offers[num].Hotel.Price +" PLN/os");

}
Console.WriteLine("Wybierz numer oferty");
Console.WriteLine();
string numberOffer = Console.ReadLine();
Console.WriteLine("PROSZĘ PODAĆ ILOŚĆ OSÓB DOROSŁYCH:");
Console.WriteLine();
string adults = Console.ReadLine();
Console.WriteLine("PROSZĘ PODAĆ ILOŚĆ DZIECI:");
string children = Console.ReadLine();

Offer useroffer = Service.FindOffer(travel, Convert.ToInt32(numberOffer));
decimal price = useroffer.CalculatePrice(Convert.ToInt32 (children), Convert.ToInt32(adults));
Console.WriteLine("CAŁKOWITA CENA WAKACJI WYNOSI:" + price);

