namespace MethodOverridingLib
{
    public class ParentExample
    {
        public virtual void print()
        {
            Console.WriteLine("This is a method of parent class");
        }
    }
    public class ChildExample: ParentExample
    {
        public override void print()
        {
            Console.WriteLine("This is a method of child class");
        }
    }
}