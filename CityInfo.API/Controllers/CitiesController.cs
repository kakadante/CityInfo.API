using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [Route("api/cities")]
    //[Route("api/[controller]")]


    public class CitiesController : Controller
    {
        [HttpGet()]

        public IActionResult GetCities()
        {
            return new JsonResult(CitiesDataStore.Current.Cities);
        }


        [HttpGet("{Id}")]
        public IActionResult GetCity(int id)
        {
           var CityToReturn = CitiesDataStore.Current.Cities.FirstOrDefault(c =>c.Id == id);

           if (CityToReturn == null)
           {
               return NotFound();
           }

           return Ok(CityToReturn);
        }
    }
}