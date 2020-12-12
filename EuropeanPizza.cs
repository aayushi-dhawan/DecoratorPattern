using System;

namespace DecoratorPattern
{
    public class EuropeanPizza : IPizza
    {
        public void GetCost()
        {
            Console.WriteLine("European Pizza");
        }
    }

}