﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [Route("api/cities")]
    //[Route("api/[controller]")]


    public class CitiesController : Controller
    {
        [HttpGet()]

        public JsonResult GetCities()
        {
                return new JsonResult(new List<object>()
                {
                    new {id =1, Name="New York City"},
                    new {id =2, Name="Antwerp"}
                });
        }
    }
}