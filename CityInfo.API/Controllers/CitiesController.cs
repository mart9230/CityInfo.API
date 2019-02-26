using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CityInfo.API.Services;
using CityInfo.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [Route("api/cities")]
    [ApiController]
    public class CitiesController : Controller
    {
        private ICityInfoRepository _cityInfoRepository; 

        public CitiesController(ICityInfoRepository cityInfoRepository)
        {
            _cityInfoRepository = cityInfoRepository;
        }

        [HttpGet]
        public IActionResult GetCities()
        {
            var citiesEntities = _cityInfoRepository.GetCities();
            var results = Mapper.Map<IEnumerable<CityWithoutPointsOfInterestDto>>(citiesEntities);

            return Ok(results);            
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id, bool includePointsOfInterest = false)
        {
            var cityEntity = _cityInfoRepository.GetCity(id, includePointsOfInterest);

            if (cityEntity == null)
                return NotFound();

            if (!includePointsOfInterest)
            {
                var cityWithoutPointsOfInterestDto = Mapper.Map<CityWithoutPointsOfInterestDto>(cityEntity);
                return Ok(cityWithoutPointsOfInterestDto);
            }
            else
            {
                var cityDto = Mapper.Map<CityDto>(cityEntity);
                return Ok(cityDto);
            }
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
