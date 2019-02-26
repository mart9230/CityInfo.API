using CityInfo.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public static class CityInfoExtensions
    {
        public static void EnsureSeedDataForContext(this CityInfoContext context)
        {
            if (context.Cities.Any())
            {
                return;
            }

            // init seed data
            var cities = new List<City>()
            {
                new City()
                {
                    Name = "New York City",
                    Description = "The one with that big park",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest(){
                        Name="Central Park",
                        Description = "The most visited urban park in the United States.",
                        },

                        new PointOfInterest(){
                        Name="Empire State Building",
                        Description = "A 102-story skyscraper.",
                        },
                    }
                },
                new City()
                {
                    Name = "Paris",
                    Description = "The one with that big Tower",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest(){
                        Name="EIffel Tower",
                        Description = "The big Tower",
                        },

                        new PointOfInterest(){
                        Name="The Louvre",
                        Description = "The World's largest Museunm",
                        },
                    }
                },
            };

            context.Cities.AddRange(cities);
            context.SaveChanges();
        }
    }
}
