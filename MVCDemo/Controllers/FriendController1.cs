using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;
using MVCDemo.Service;

namespace MVCDemo.Controllers
{
    public class FriendController1 : Controller
    {
        public IActionResult Index()

        {
            List<Friend> PFriends = FriendServices.GetAll();
            return View();
        }
        public IActionResult Details(int id)
        {
            Friend P = FriendServices.Get(id);
            return View(P);
        }


        public IActionResult List(int id)
        {
            List<Friend> Friends = FriendServices.GetAll();

            //Pizza P = PizzaService.Get(id);
            return View(Friends);
            //List<Pizza> Pizzas = PizzaService.GetAll();

            //return View(Pizzas);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        //public IActionResult Create(Pizza p)
        //{
        //    PizzaService.Add(p);
        //    return RedirectToAction("List");
        //}
        public IActionResult Create(int id, string name, string place)
        {
            Friend f = new Friend { FriendId = id, FriendName = name, Place=place }; ;
            FriendServices.Add(f);
            return RedirectToAction("List");
        }


        public IActionResult Delete(int id)
        {
            Friend f = FriendServices.Get(id);
            if (f != null)
                return View(f);
            else
                return RedirectToAction("List");
        }
        [HttpPost]
        public IActionResult Delete(Friend f)
        {

            FriendServices.Delete(f.FriendId);
            return RedirectToAction("List");

        }


        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update(int id, string name, string place)
        {
            Friend f= new Friend { FriendId = id, FriendName = name, Place = place };
            FriendServices.Update(f);
            return RedirectToAction("List");
        }
    }
}

