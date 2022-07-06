namespace InheritanceLib
{
    public class VisitingEmployees : Employees
    {
        public int VisitingSalary;
        public int VisitingHours;
    }
    public class PermenantEmployees : Employees
    {
        public int PermanantSalary;
        public int PermenantHours;
    }
    public class Employees
    {
        public int EmpId;
        public string EmpName;
        public int EmpAge;
        public int EmpContactNo;

        public void show()
        {
            Console.WriteLine("This is a method of base class");
        }
    }
}