using System;
using System.Collections.Generic;
using System.Text;

namespace Sinav2
{
    public class Hotels
    {
        public int Id { get; set; }
        public string HotelName { get; set; }
        public int Price { get; set; }
        public int Capasity { get; set; }
        public int CategoryId { get; set; }

        public List<Hotels> Liste { get; set; }

        public Hotels()
        {
            Liste=new List<Hotels>
            {
                new Hotels("Marina",250,1000,1),
                new Hotels("Sheraton",550,2000,2),
                new Hotels("Abant",50,500,3),
                new Hotels("Club",350,750,4),
                new Hotels("Grand",1550,10000,3),
                new Hotels("Luxurt",2250,5000,2),
                new Hotels("Eagle",150,3500,4),
                new Hotels("Arinna",200,250,1),
                new Hotels("Babaylon",100,800,2),
                new Hotels("Ikbal",340,1500,4),
            };

        }
        public Hotels(string hotelName, int price, int capasity, int categoryId)
        {

            HotelName = hotelName;
            Price = price;
            Capasity = capasity;
            CategoryId = categoryId;
        }

        public override string ToString()
        {
            return $"{HotelName,-10}" +
                $"{Price,-10}" +
                $"{Capasity,-10}" +
                $"{CategoryId,-10}";
        }
    }
}
