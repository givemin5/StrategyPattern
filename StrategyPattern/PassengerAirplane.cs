using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class PassengerAirplane : Airplane
    {
        public PassengerAirplane()
        {
              _fly = new FlyWithWings();
             _shoot = new NoShoot();
        }
        public override void Display()
        {
            Console.WriteLine("我是一般飛機");
        }
    }
}
