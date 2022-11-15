﻿using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [ApiController]
    public class CitiesController : ControllerBase
    {
        [HttpGet("api/cities")]
        public JsonResult GetCities()
        {
            return new JsonResult(
                new List<object>
                {
                    new { id = 1, Name = "New York City" },
                    new { id = 2, Name = "Antwerp" }
                });
        }

        [HttpGet("api/neoCities")]
        public JsonResult GetneoCities()
        {
            return new JsonResult(
                new List<object>
                {
                    new { id = 1, Name = "Akron" },
                    new { id = 2, Name = "Cleveland" }
                });
        }
    }
}