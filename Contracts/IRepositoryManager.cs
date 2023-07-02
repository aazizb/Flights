namespace Contracts
{
    public interface IRepositoryManager
    {
        IFlightRepository Flight { get; }
        void Save();
    }
}
