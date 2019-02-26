using CityInfo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class CityDataStore
    {
        public static CityDataStore current { get; } = new CityDataStore();
        public List<CityDto> Cities { get; set; }

        public CityDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York",
                    Description = "Big Apple",

                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Statue of Liberty",
                            Description = "Statue of Liberty"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Central Park",
                            Description = "Central Park"
                        },
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Miami",
                    Description = "Beautiful beaches",

                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 3,
                            Name = "Dolphin Mall",
                            Description = "Dolphin Mall"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 4,
                            Name = "Versailles",
                            Description = "Versailles"
                        },
                    }

                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "Big Tower"
                },
            };
        }
    }
}
