using System;

namespace DecoratorPattern
{
    public class Condiment :IPizza
    {
        IPizza pizza;

        public Condiment(IPizza p)
        {
            this.pizza = p;
        }

        public virtual void GetCost()
        {
            this.pizza.GetCost();
            //Console.WriteLine("Base Condiment");
        }
    }
    
}