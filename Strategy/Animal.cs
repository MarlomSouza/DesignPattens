using System;

namespace Strategy
{
    public class Animal
    {
        public string Name { get; set; }
        public double Height { get; set; }
        public int weight { get; set; }
        public string FavFood { get; set; }
        public double Speed { get; set; }
        public string Sound { get; set; }
        public Flys FlyingType;

        public void FlyingAbility(Flys flyingAbility){
            FlyingType = flyingAbility;
        }

        public void IsFlying(){
            Console.WriteLine($"{Name} {FlyingType.Fly()}");
        }

    }
}