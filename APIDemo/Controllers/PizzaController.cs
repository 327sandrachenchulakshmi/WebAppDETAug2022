using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APIDemo.Model;
using APIDemo.Service;

namespace APIDemo.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    //public class PizzaController : ControllerBase
    //{
    //    [HttpGet]
    //    [Route("all")]
    //    public List<Pizza> Get()
    //    {
    //        return PizzaService.GetAll();
    //    }
    //    [HttpGet]
    //    [Route("id")]
    //    public Pizza Get(int id)
    //    {
    //        Pizza p = PizzaService.Get(id);
    //        return p;
    //    }
    [ApiController]
    [Route("[controller]")]
    public class PizzaController : ControllerBase
    {
        public PizzaController()
        {
           
        }
        [HttpGet]
        public ActionResult<List<Pizza>> GetAll() =>
                PizzaService.GetAll();


        [HttpGet("{id}")]
        public ActionResult<Pizza> Get(int id)
        {
            var pizza = PizzaService.Get(id);

            if (pizza == null)
                return NotFound();

            return pizza;
        }
        [HttpPost]
        public IActionResult Create(Pizza pizza)
        {
            PizzaService.Add(pizza);
            return CreatedAtAction(nameof(Create), new { id = pizza.Id }, pizza);
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, Pizza pizza)
        {
            if (id != pizza.Id)
                return BadRequest();

            var existingPizza = PizzaService.Get(id);
            if (existingPizza is null)
                return NotFound();

            PizzaService.Update(pizza);

            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var pizza = PizzaService.Get(id);

            if (pizza is null)
                return NotFound();

            PizzaService.Delete(id);

            return NoContent();
        }

    }
}
