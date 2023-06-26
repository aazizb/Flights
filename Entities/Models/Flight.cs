namespace Entities.Models
{
    public class Flight
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Departure { get; set; }
        public required string Destination { get; set; }
        public int Distance { get; set; }
    }
}
