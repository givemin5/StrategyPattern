using System;

namespace StrategyPattern
{
    class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("我會飛");
        }
    }

    class NoFly : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("我不會飛");
        }
    }
}