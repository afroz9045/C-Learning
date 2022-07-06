namespace ConstructorInheritanceLib
{
    public class DerivedConstructorClass:BaseConstuctorClass
    {
        public DerivedConstructorClass() : base("This is a message from derived class passed to base class constructor")
        {
            Console.WriteLine("This is a derived class constructor");
        }
    }
}
