using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Fighter : Airplane
    {
        public override void Display()
        {
            Console.Write("我是戰鬥機");
        }

        public override void Shoot()
        {
            Console.Write("我有槍");
        }
    }
}
