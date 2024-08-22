using System.ComponentModel.DataAnnotations;

namespace EventManagementWebApp.Models
{
    public class Event
    {
        public int EventID { get; set; }
        [Required]
        public string EventName { get; set; }=string.Empty;
        [Required]
        public string EventDescription { get; set; } = string.Empty;
        [Required]
        public DateTime EventDateTime { get; set; }
        [Required]
        public string EventLocation { get; set; } = string.Empty ;
        [Required]
        [Range(1,1000)]
        public int MaxAttendees { get; set; }
        public decimal? TicketPrice { get; set; }

        public List<Registration> Registrations { get; set; } = new List<Registration>();

    }

}
