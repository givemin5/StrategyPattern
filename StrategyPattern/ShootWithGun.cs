using System;

namespace StrategyPattern
{
    class ShootWithGun : IShoot
    {
        public void Shoot()
        {
            Console.Write("我有槍");
        }
    }

    class NoShoot : IShoot
    {
        public void Shoot()
        {
            Console.WriteLine("我沒有鎗");
        }
    }
}