using EventManagementWebApp.Data;
using EventManagementWebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EventManagementWebApp.Controllers
{
    [Authorize]
    public class RegisterEventsController : Controller
    {
        private readonly ApplicationDbContext db;

        public RegisterEventsController(ApplicationDbContext _db) 
        {
            db = _db;
        }
        public IActionResult Index()
        {
            var events = db.Events.Where(e => e.EventDateTime >= DateTime.Now);
            return View(events);
        }

        public IActionResult Register(int id)
        {
            var eventToRegister = db.Events.Find(id);
            //ViewBag.EventToRegister = eventToRegister;

            var isRegistered = db.Registrations.Any(r => r.UserID == User.Identity.Name && r.EventID == id);
            if (!isRegistered)
            {
                Registration reg = new Registration
                {
                    Event = eventToRegister,
                    EventID = id,
                    UserID = User?.Identity?.Name ?? "Unknown"
                };
                db.Registrations.Add(reg);
                db.SaveChanges();
                TempData["message"] = $"Registered successfully for the event {eventToRegister.EventName}";
            }
            else
            {
                TempData["message"] = $"Already Registered for the event {eventToRegister.EventName}";
            }
            return RedirectToAction("Index");
        }
    }
}
