using Contracts;

using Entities.Models;

using Service.Contracts;

namespace Service.Services
{
    public sealed class FlightService : IFlightService
    {
        private readonly IRepositoryManager repository;
        private readonly ILoggerManager logger;

        public FlightService(IRepositoryManager repository, ILoggerManager logger)
        {
            this.repository = repository;
            this.logger = logger;
        }

        public Flight CreateFlight(Flight flight)
        {
            repository.Flight.CreateFlight(flight);
            repository.save();
            return flight;
        }

        public void DeleteFlight(int id, bool trackchanges)
        {
            var entity = repository.Flight.GetFlightById(id, trackchanges);
            if (entity is null)
            {
                throw new Exception($"Flight: {id} not found");
            }
            repository.Flight.DeleteFlight(entity);
            repository.save();
        }

        public IEnumerable<Flight> GetAll(bool trackchanges)
        {
            try
            {
                return repository.Flight.GetFlights(trackchanges);
            }
            catch (Exception ex)
            {

                logger.LogError($"Flight Management: {nameof(GetAll)} service method {ex}");
                throw;
            }
        }

        public Flight GetFlightBy(int id, bool trackchanges)
        {
            return repository.Flight.GetFlightById(id, trackchanges);
        }
    }
}
