using Contracts;

using Service.Contracts;

namespace Service.Services
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IFlightService> flightService;

        public ServiceManager(IRepositoryManager repository, ILoggerManager logger)
        {
            flightService = new Lazy<IFlightService>(() => new
            FlightService(repository, logger));
        }
        public IFlightService FlightService =>
            flightService.Value;
    }
}
