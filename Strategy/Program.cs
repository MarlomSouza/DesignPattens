using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Animal cachorro = new Dog("zeus");
            cachorro.IsFlying();

            Animal bird = new Bird("biru biru");
            bird.IsFlying();

            cachorro.FlyingAbility(new ItFlys());
            cachorro.IsFlying();
        }
    }
}
