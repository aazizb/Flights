﻿using Entities.Models;

namespace Service.Contracts
{
    public interface IFlightService
    {
        IEnumerable<Flight> GetAll(bool trackchanges);
        Flight GetFlightBy(int id, bool trackchanges);
        Flight CreateFlight(Flight flight);
        void DeleteFlight(int id, bool trackchanges);
        void UpdateFlight(int id, Flight flight);
    }
}
