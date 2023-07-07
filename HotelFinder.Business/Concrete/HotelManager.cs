using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelFinder.Business.Abstract;
using HotelFinderDataAccess.Abstract;
using HotelFinderDataAccess.Concrate;
using HotelFinderEntities;
using Microsoft.AspNetCore.Mvc;

namespace HotelFinder.Business.Concrete
{
    public class HotelManager : InHotelService
    {
        private IHotelRepository _hotelRepository;
        public HotelManager()
        {
            _hotelRepository= new HotelRepository();
        }

        public Hotel CreateHotel(Hotel hotel)
        {
            return _hotelRepository.CreateHotel(hotel);
        }

        public void DeleteHotel(int id)
        {
            _hotelRepository.DeleteHotel(id);
        }

        public List<Hotel> GetAllHotels()
        {
           return _hotelRepository.GetAllHotels()
;
        }

        public Hotel GetHotelById(int id)
        {
            if(id>0)
            {
                return _hotelRepository.GetHotelById(id);
            }
            throw new Exception("Id do not 0");
              
        }

        public Hotel GetHotelByName(string name)
        {
            return _hotelRepository.GetHotelByName(name);   
        }

        public Hotel UpdateHotel(Hotel hotel)
        {
            return _hotelRepository.UpdateHotel(hotel); 
        }
    }
}

