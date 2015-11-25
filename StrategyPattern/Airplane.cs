using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    abstract class Airplane
    {
        internal IFlyBehavior _fly;
        internal IShoot _shoot;
        public abstract void Display();

        public void Fly()
        {
            _fly.Fly();
        }

        public void Shoot()
        {
            _shoot.Shoot();
        }
    }
}
