using Contracts;

namespace Repository
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext context;
        private readonly Lazy<IFlightRepository> flightRepository;
        public RepositoryManager(RepositoryContext context)
        {
            this.context = context;

            flightRepository = new Lazy<IFlightRepository>(() => new
                FlightRepository(context));

        }
        public IFlightRepository Flight => flightRepository.Value;

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
