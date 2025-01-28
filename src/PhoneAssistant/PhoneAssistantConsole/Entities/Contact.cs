namespace PhoneAssistantConsole.Entities
{
    public class Contact
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
