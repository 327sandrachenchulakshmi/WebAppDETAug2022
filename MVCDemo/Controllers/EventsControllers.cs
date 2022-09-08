using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;
using System.Reflection;

namespace MVCDemo.Controllers
{
    public class EventsControllers : Controller
    {
        public List<Booking> events { get; set; }
        public IActionResult Index()
        {

            events = new List<Booking>();
            events.Add(new Booking { Title= "Ask CEO", EventDate = DateTime.Today, Qty = 10 });
            events.Add(new Booking { Title = "Ask CEO", EventDate = DateTime.Today, Qty = 10 });
            events.Add(new Booking { Title = "Ask CEO", EventDate = DateTime.Today, Qty = 10 });
            events.Add(new Booking { Title = "Ask CEO", EventDate = DateTime.Today, Qty = 10 });
            events.Add(new Booking { Title = "Ask CEO", EventDate = DateTime.Today, Qty = 10 });
            return View(events);
        }
    }
}
