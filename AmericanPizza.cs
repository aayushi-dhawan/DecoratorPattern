using System;

namespace DecoratorPattern
{
    public class AmericanPizza : IPizza
    {
        public void GetCost()
        {
            Console.WriteLine("American Pizza");
        }
    }
}