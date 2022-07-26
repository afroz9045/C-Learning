using System.Collections.Generic;
namespace GenericListLib
{
    public class GenericList
    {
        public static void ShowList()
        {
            List<string> friendsNames = new List<string>();
            friendsNames.Add("Syed Zaki Ahmed");
            friendsNames.Add("Syed Ibrahim");
            friendsNames.Add("Mohd Asif");

            foreach (var names in friendsNames)
            {
                Console.WriteLine(names);
            }
            Employee e1 = new Employee()
            {
                Name = "Asif",
                Age = 24,
                Designation = "SAP ABAP Developer"
            };
            Employee e2 = new Employee()
            {
                Name = "Sharfuddin",
                Age = 22,
                Designation = "Tech support associate"
            };
            Employee e3 = new Employee()
            {
                Name = "Mohd Afroz Khan",
                Age = 23,
                Designation = "Software Engineer"
            };

            List<Employee> empDetails = new List<Employee>();
            empDetails.Add(e1);
            empDetails.Add(e2);
            empDetails.Add(e3);
            Console.WriteLine("\nList of employee type:\n");
            foreach (Employee empData in empDetails)
            {
                Console.WriteLine($"Employee name is: {empData.Name}\nEmployee age is: {empData.Age}\nEmployee designation is: {empData.Designation}\n\n");
            }

            Console.WriteLine(empDetails.Count());
        }
    }
}