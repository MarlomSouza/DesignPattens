namespace Strategy
{
    public class Dog : Animal
    {
        public Dog(string name)
        {
            Name = name;
            FlyingType = new CantFly();
        }
    }
}