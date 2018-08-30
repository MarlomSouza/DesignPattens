namespace Strategy
{
    public interface Flys
    {
         string Fly();
    }

    internal class ItFlys : Flys
    {
        public string Fly(){
            return "Flying hight";
        }
    }

    internal class CantFly: Flys{
        public string Fly(){
            return "I can't fly";
        }
    }
}