using HotelFinder.Business.Abstract;
using HotelFinder.Business.Concrete;
using HotelFinderEntities;
using Microsoft.AspNetCore.Mvc;


namespace HotelFinder.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]

    public class HotelsController : ControllerBase
    {
        private InHotelService _hotelService;
        public HotelsController()
        {
            _hotelService = new HotelManager();
        }
        [HttpGet]
        public List<Hotel> Get()
        {
            return _hotelService.GetAllHotels();
        }
        [HttpGet("{id}")]
        public Hotel Get(int id)
        {
            return _hotelService.GetHotelById(id);
        }
        [HttpPost]
        public Hotel Post([FromBody] Hotel hotel)
        {
            return _hotelService.CreateHotel(hotel);
        }
        [HttpPut]
        public Hotel Put([FromBody] Hotel hotel)
        {
            return _hotelService.UpdateHotel(hotel);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _hotelService.DeleteHotel(id);
        }
    }
}
