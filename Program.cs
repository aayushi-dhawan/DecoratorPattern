using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza pizzaObj = new AmericanPizza();
            pizzaObj = new Cheese(pizzaObj);
            pizzaObj.GetCost();

            IPizza pizzaEu = new EuropeanPizza();
            pizzaEu = new Cheese(pizzaEu);
            pizzaEu = new Olives(pizzaEu);
            pizzaEu.GetCost();
        }
    }
}
