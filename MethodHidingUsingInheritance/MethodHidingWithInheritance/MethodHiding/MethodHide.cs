namespace MethodHiding
{
    public class Parent
    {
        public void show()
        {
            Console.WriteLine("Parent class method");
        }
    }
    public class Child:Parent
    {
        public void show()
        {
            Console.WriteLine("child class method");
        }
    }
    public class Employee
    {
        public void PrintFullName()
        {
            Console.WriteLine("Employee");
        }
    }
    public class PartTimeEmployee : Employee
    {
        public new void PrintFullName()
        {
            Console.WriteLine("PTE");
        }
    }
    public class fullTimeEmployee : Employee
    {
        public new void PrintFullName()
        {
            Console.WriteLine("FTE");
        }
    }
}