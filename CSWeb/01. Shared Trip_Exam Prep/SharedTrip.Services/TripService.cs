﻿using SharedTrip.Data;
using SharedTrip.Data.Models;
using SharedTrip.Models.Common.Trips;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SharedTrip.Services
{
    public class TripService : ITripService
    {
        private readonly SharedTripDbContext dbContext;

        public TripService(SharedTripDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Add(TripAddInputModel inputModel)
        {
            var trip = new Trip()
            {
                Id = Guid.NewGuid().ToString(),
                StartPoint = inputModel.StartPoint,
                EndPoint = inputModel.Description,
                DepartureTime = inputModel.DepartureTime,
                Seats = inputModel.Seats,
                Description = inputModel.Description,
                ImagePath = inputModel.ImagePath
            };

            this.dbContext.Trips.Add(trip);
            this.dbContext.SaveChanges();
        }

        public IEnumerable<Trip> GetAll()
        {
            return this.dbContext.Trips;
        }

        public object GetDetails(string id)
        {
            throw new NotImplementedException();
        }
    }
}
