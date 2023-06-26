using Contracts;

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

    }
}
