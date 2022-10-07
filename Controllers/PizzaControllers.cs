using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using practica4to.Models;
using practica4to.Services;
using Microsoft.AspNetCore.Mvc;


namespace practica4to.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PizzaControllers : ControllerBase
    {
        public PizzaControllers()
        {


        }

            [HttpGet]
            public ActionResult<List<Pizza>> GetAll() => PizzaService.GetAll();

            [HttpGet("{id}")]
            public ActionResult<Pizza> Get (int id)
            {
                var Pizza = PizzaService.Get(id);
                if(Pizza == null)
                    return NotFound();

                    return Pizza;
                
            }


            [HttpPost]
            public IActionResult Create (Pizza pizza)
            {
                PizzaService.Add(pizza); 
                return CreatedAtAction(nameof(Create),new {id = pizza},pizza);
            }


            [HttpDelete("{id}")]
            public IActionResult Delete(int id)
            {
                var pizza = PizzaService.Get(id);
                if(pizza is null)
                return NotFound();

                PizzaService.Delete(id);

                return NoContent();
            }




        
    }
}