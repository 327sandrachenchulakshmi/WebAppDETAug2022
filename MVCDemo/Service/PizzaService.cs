﻿using MVCDemo.Models;
using System.Xml.Linq;

namespace MVCDemo.Service
{
    public class PizzaService
    {
        static List<Pizza> Pizzas { get; }
        static int nextId = 3;
        static PizzaService()
        {
            Pizzas = new List<Pizza>
                {
                    new Pizza { Id = 1, Name = "Nonveg", Price=20.00M, Size=PizzaSize.    Large, IsGlutenFree = false },
                    new Pizza { Id = 2, Name = "Veggi", Price=15.00M, Size=PizzaSize.Small,     IsGlutenFree = true }
                };
        }

        public static List<Pizza> GetAll() => Pizzas;

        public static Pizza? Get(int id) => Pizzas.FirstOrDefault(p => p.Id == id);

        public static void Add(Pizza pizza)
        {
            pizza.Id = nextId++;
            Pizzas.Add(pizza);
        }

        public static void Delete(int id)
        {
            var pizza = Get(id);
            if (pizza is null)
                return;

            Pizzas.Remove(pizza);
        }

        public static void Update(Pizza pizza)
        {
            var index = Pizzas.FindIndex(p => p.Id == pizza.Id);
            if (index == -1)
                return;

            Pizzas[index] = pizza;
        }
    }
}

    

