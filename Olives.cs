using System;

namespace DecoratorPattern
{
    public class Olives : Condiment
    {
        public Olives(IPizza pizza): base(pizza)
        {
            
        }

        public override void GetCost()
        {
            base.GetCost();
            Console.WriteLine("Olives Cost");
        }
    }
}