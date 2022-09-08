using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;
using MVCDemo.Service;

namespace MVCDemo.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> Pizzas = PizzaService.GetAll();

            return View(Pizzas);
        }



        public IActionResult Details(int id)
        {
            Pizza P = PizzaService.Get(id);
            return View(P);
        }


        public IActionResult List(int id)
        {
            List<Pizza> Pizzas = PizzaService.GetAll();
            
            //Pizza P = PizzaService.Get(id);
            return View(Pizzas);
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
        public IActionResult Create(int id, string name,int size,decimal price,bool Isglutenfree)
        {
            Pizza p = new Pizza { Id = id, Name = name, Size = (PizzaSize)size, Price = price, IsGlutenFree = Isglutenfree }; ;
            PizzaService.Add(p);
            return RedirectToAction("List");
        }


        public IActionResult Delete(int id)
        {
            Pizza P = PizzaService.Get(id);
            if (P != null)
                return View(P);
            else
                return RedirectToAction("List");
        }
        [HttpPost]
        public IActionResult Delete(Pizza p)
        {

            PizzaService.Delete(p.Id);
            return RedirectToAction("List");

        }




    }
}
