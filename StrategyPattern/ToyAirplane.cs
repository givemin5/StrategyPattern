using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class ToyAirplane : Airplane
    {
        public ToyAirplane()
        {
            _fly = new NoFly();
            _shoot = new NoShoot();
        }

        public override void Display()
        {
            Console.WriteLine("我是玩具飛機");
        }
    }
}
