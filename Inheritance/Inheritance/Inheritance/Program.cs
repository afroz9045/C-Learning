using InheritanceLib;
using TypesOfInheritance;
using ConstructorInheritanceLib;
class Program
{
    public static void Main(string[] args)
    {
        PermenantEmployees ibrahim = new PermenantEmployees();
        ibrahim.EmpId = 3909;

        VisitingEmployees raju = new VisitingEmployees();
        raju.EmpId = 3030;

        Console.WriteLine(ibrahim.EmpId);
        ibrahim.show();
        Console.WriteLine(raju.EmpId);

        DerivedClass dc = new DerivedClass();
        dc.show1();
        DerivedClass1 dc1 = new DerivedClass1();
        dc1.show2();

        Console.WriteLine("----------------Constructor Inheritance----");
        DerivedConstructorClass dcc = new DerivedConstructorClass();
    }
}