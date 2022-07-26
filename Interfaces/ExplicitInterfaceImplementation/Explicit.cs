namespace ExplicitInterfaceImplementation
{
    public interface EI1
    {
        public void show();
    }
    public interface EI2
    {
        public void show();
    }
    public class Explicit : EI1, EI2
    {
        void EI1.show()
        {
            Console.WriteLine("This is a method of EI1");
        }
        void EI2.show()
        {
            Console.WriteLine("This is a method of EI2");
        }
    }
}