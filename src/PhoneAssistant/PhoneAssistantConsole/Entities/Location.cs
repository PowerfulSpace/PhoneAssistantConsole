namespace PhoneAssistantConsole.Entities
{
    public class Location
    {
        public Guid Id { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public int Population { get; set; }
    }
}
//Добавить миграцию