namespace AbstractClassesLib
{
    public abstract class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;
        public long phoneNumber;
        public abstract void ShowDetails();
        public void PrintName()
        {
            Console.WriteLine("Afroz");
        }
    }
    public class Student : Person
    {
        public int RollNo;
        public int Fees;

        public override void ShowDetails()
        {
            Console.WriteLine($"Student name is {this.FirstName} {this.LastName} ");
            Console.WriteLine($"Student age is {this.Age}");
            Console.WriteLine($"Student phone number {this.phoneNumber}");
            Console.WriteLine($"Student Roll no is: {this.RollNo}");
            Console.WriteLine($"Student fee is {this.Fees}");
        }
    }
    public class Teacher : Person
    {
        public string Qualification;
        public int Salary;
        public override void ShowDetails()
        {
            Console.WriteLine($"Student name is {this.FirstName} {this.LastName} ");
            Console.WriteLine($"Student age is {this.Age}");
            Console.WriteLine($"Student phone number {this.phoneNumber}");
            Console.WriteLine($"Student Roll no is: {this.Qualification}");
            Console.WriteLine($"Student fee is {this.Salary}");
        }
    }

} 
