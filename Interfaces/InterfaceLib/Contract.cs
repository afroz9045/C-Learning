using InterfaceInheritanceLib;
namespace InterfaceLib
{
    public interface IEmployee
    {
        public void show();
    }
    public class PartTimeEmployees : IEmployee,I3
    {
        public void show()
        {
            Console.WriteLine("This is a method of IEmployee interface!!");
        }
        public void Print()
        {
            Console.WriteLine("Print method");
        }
        public void Print1()
        {
            Console.WriteLine("Print1 method");
        }
        public void Print2()
        {
            Console.WriteLine("Print2 method");
        }
    }

}