﻿using CityInfo.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Services
{
    public interface ICityInfoRepository
    {       
        IEnumerable<City> GetCities();
        bool CityExists(int cityId);
        City GetCity(int cityId, bool includePointsOfInterest);
        IEnumerable<PointOfInterest> GetPointsOfInterestForCity(int cityId);
        PointOfInterest GetPointOfInterestForCity(int cityId, int pointOfInterestId);
        void AddPointOfInterestToCity(int cityId, PointOfInterest pointOfInterest);
        void DeletePointOfInterestForCity(PointOfInterest pointOfInterest);
        bool Save();
    }
}
