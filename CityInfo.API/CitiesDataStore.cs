using System.Collections.Generic;
using CityInfo.API.Controllers;
using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {

        public static CitiesDataStore Current { get; } = new CitiesDataStore();   //ensures property is immutable = C#66

        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "Majuu",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "TRUMP",
                            Description = "FALA",
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "PENCE",
                            Description = "ZII",
                        },
                    }
                },

                new CityDto()
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "Makeja",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 3,
                            Name = "NURU",
                            Description = "PEPE",
                        },
                        new PointOfInterestDto()
                        {
                            Id = 4,
                            Name = "GIZA",
                            Description = "KALE",
                        },
                    }
                },

                new CityDto()
                {
                    Id = 3,
                    Name = "Nairobi",
                    Description = "Dante's Home",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "KATEE",
                            Description = "DANTE",
                        },
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "MUTISO",
                            Description = "MASLAH",
                        },
                    }

                }
            };
        }
    }
}