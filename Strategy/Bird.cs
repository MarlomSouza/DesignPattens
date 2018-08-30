namespace Strategy
{
    public class Bird : Animal
    {
        public Bird(string name)
        {
            Name = name;
            FlyingType = new ItFlys();
        }
    }
}