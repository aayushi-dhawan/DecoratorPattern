using System;

namespace DecoratorPattern
{
    public class Cheese : Condiment
    {
        public Cheese(IPizza pizza): base(pizza)
        {
            
        }

        public override void GetCost()
        {
            base.GetCost();
            Console.WriteLine("Cheese Cost");
        }
        
    }
}