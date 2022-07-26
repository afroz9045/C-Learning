using AbstractionExample;
using AbstractClassesLib;
using AbstractPropertyLib;

Abstraction ali = new Abstraction(3606,"Ali",15000);
ali.ShowEmployeeDetails();

Student anas = new Student();
Console.WriteLine("\nAbstract classes Example");
anas.FirstName = "Anas";
anas.LastName = "Qureshi";
anas.Age = 20;
anas.phoneNumber= 1234567890;
anas.RollNo = 8727;
anas.Fees = 5000;
anas.ShowDetails();

Console.WriteLine("-------------------------------");

Teacher asad = new Teacher();
asad.FirstName = "Asad";
asad.LastName = "shaik";
asad.Age = 25;
asad.phoneNumber = 73325973697;
asad.Qualification = "Masters in cs";
asad.Salary = 35000;
asad.ShowDetails();
asad.PrintName();

ChildImplementation implementChild = new ChildImplementation();
implementChild.Id = 3606;
Console.WriteLine(implementChild.Id);