namespace SealedExampleLib
{
    public class Sealed
    {

    }
    public sealed class BaseClass
    {
        public void show1()
        {
            Console.WriteLine("Method of base class");
        }
    }
    public class DerivedClass //:BaseClass  //This wont be inherit because of sealed
    {
        public void show2()
        {
            Console.WriteLine("Method of derived class");
        }
    }
}