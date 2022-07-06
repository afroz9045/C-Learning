namespace ConstructorOverloadingLib
{
    public class ConstructorOverload
    {
        public ConstructorOverload()
        {
            Console.WriteLine("This is a first constructor!");
        }
        public ConstructorOverload(string firstName,string lastName)
        {
            Console.WriteLine($"Full name is {firstName} {lastName}");
        }
        public ConstructorOverload(string firstName,string middleName,string lastName)
        {
            Console.WriteLine($"Full name is {firstName} {middleName} {lastName}");
        }
    }
}