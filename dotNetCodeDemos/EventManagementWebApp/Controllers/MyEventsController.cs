using EventManagementWebApp.Data;
using EventManagementWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EventManagementWebApp.Controllers
{
    public class MyEventsController : Controller
    {
        private readonly ApplicationDbContext db;

        public MyEventsController(ApplicationDbContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            var userRegs = db.Registrations.Include(r=>r.Event).Where(r => r.UserID == User.Identity.Name).ToList();
            List<Event> events = new List<Event>();
            foreach (var reg in userRegs) 
            {
                events.Add(reg.Event);
            }
            return View(events);
        }

        public IActionResult Cancel(int id) 
        {
            var eventToUnregister = db.Registrations.Include(r=>r.Event).Where(r => r.UserID == User.Identity.Name && r.EventID == id).FirstOrDefault();
            if (eventToUnregister != null && eventToUnregister.Event.EventDateTime >= DateTime.Now) 
            {
                db.Registrations.Remove(eventToUnregister);
                db.SaveChanges();
                TempData["Message"] = $"For the event {eventToUnregister.Event.EventName} - unregistered successfully";
            }
            else
            {
                TempData["Message"] = $"The event {eventToUnregister.Event.EventName} - is already over, can not be cancelled";
            }
            return RedirectToAction("Index");
        }
    }
}
