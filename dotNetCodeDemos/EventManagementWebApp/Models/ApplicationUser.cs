using Microsoft.AspNetCore.Identity;

namespace EventManagementWebApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        public List<Registration> Registrations { get; set; } = new List<Registration>();
    }

}
