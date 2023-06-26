namespace Service.Contracts
{
    public interface IServiceManager
    {
        IFlightService FlightService { get; }
    }
}
