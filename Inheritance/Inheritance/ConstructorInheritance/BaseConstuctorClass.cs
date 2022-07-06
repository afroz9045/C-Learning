namespace ConstructorInheritanceLib
{
    public class BaseConstuctorClass
    {
        public BaseConstuctorClass()
        {
            Console.WriteLine("This is a base class constructor");
        }
        public BaseConstuctorClass(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}