using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class PassengerAirplane : Airplane
    {
        public override void Display()
        {
            Console.WriteLine("我是一般飛機");
        }

        public override void Shoot()
        {
            Console.WriteLine("我沒有鎗");
        }
    }
}
