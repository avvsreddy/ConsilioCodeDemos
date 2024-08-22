namespace EventManagementWebApp.Models
{
    public class Registration
    {
        public int RegistrationID { get; set; }
        public int EventID { get; set; }
        public string UserID { get; set; } = string.Empty;
        public Event Event { get; set; }

    }

}
