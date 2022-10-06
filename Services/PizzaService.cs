using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using practica4to.Models;


namespace practica4to.Services
{
    public class PizzaService
    {
        static List<Pizza> Pizzas {get;}
        static int nextId = 3;

        static PizzaService()
        {
            Pizzas = new List<Pizza>
            {
                new Pizza { Id = 1, Name = "Clasica queso", IsGlutenFree = false },                
                new Pizza { Id = 2, Name = "Clasica queso y jamon", IsGlutenFree = false },
            };

        }
    public static List<Pizza> GetAll()=> Pizzas;

    public static Pizza Get(int id) => Pizzas.FirstOrDefault(p => p.Id == id);




    }
}