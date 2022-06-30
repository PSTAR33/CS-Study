using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._10
{
    interface IRunnable
    {
        public void Run();
    }

    interface IFlyable
    {
        public void Fly();
    }

    class FlyingCar : IRunnable, IFlyable
    {
        public void Run()
        {
            Console.WriteLine("Car Run!");
        }

        public void Fly()
        {
            Console.WriteLine("Car Fly!");
        }
    }

    internal class _10_7
    {
        static void Main1(string[] args)
        {
            FlyingCar car = new FlyingCar();
            car.Run();
            car.Fly();

            IRunnable runable = car as IRunnable;
            IFlyable flyable = car as IFlyable;

            runable.Run();
            flyable.Fly();
        }
    }
}
