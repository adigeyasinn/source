using System;
using System.Collections.Generic;
using System.Text;

namespace Sinavv
{
    public class Hotel
    {
        public int Id { get; set; }
        public string HotelName { get; set; }
        public int Price { get; set; }
        public int Capasity { get; set; }
        public int CategoryId { get; set; }
        public static int Count {
            get 
            {
              return  new HotelDal().GetAll().Count;
            } 
            internal set { 
            
            
            } 
        }

        public Hotel()
        {

        }
        public Hotel(string hotelName, int price, int capasity, int categoryId)
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
