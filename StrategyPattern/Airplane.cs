using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    abstract class Airplane
    {
        public abstract void Display();

        public void Fly()
        {
            Console.WriteLine("我會飛");
        }

        public abstract void Shoot();


    }
}
