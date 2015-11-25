using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Fighter : Airplane
    {
        public Fighter()
        {
              _fly = new FlyWithWings();
            _shoot = new ShootWithGun();
        }

        public override void Display()
        {
            Console.Write("我是戰鬥機");
        }

        
    }
}
