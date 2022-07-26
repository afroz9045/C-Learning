using System.Collections.Generic;
namespace DictionaryLib
{
    public class Dictionary
    {
        public static void ShowDictionary()
        {
            Dictionary<string, string> friendsFavouriteFood = new Dictionary<string, string>();

            friendsFavouriteFood.Add("Zaki", "Mandi");
            friendsFavouriteFood.Add("Syed Ibrahim", "Biryani");
            friendsFavouriteFood.Add("Shabaz Khan", "Grilled chicken");
            friendsFavouriteFood.Add("Sharfuddin", "Butter chicken");
            friendsFavouriteFood.Add("Asif", "Tandori chicken");

            //Console.WriteLine(friendsFavouriteFood["Sharfuddin"]);

            foreach (KeyValuePair<string, string> item in friendsFavouriteFood)
            {
                Console.WriteLine($"Friend name {item.Key} : favourite food is {item.Value}");
            }

            Console.WriteLine("\nFriends names is:");
            foreach (string key in friendsFavouriteFood.Keys)
            {
                Console.WriteLine($"Friends name are: {key}");
            }

            Console.WriteLine("\nFavourite Food are:");
            foreach (string favFood in friendsFavouriteFood.Values)
            {
                Console.WriteLine($"Food are: {favFood}");
            }

            Employee emp1 = new Employee()
            {
                EmpId = 100,
                Name = "Ali",
                Designation = "Manager",
                Salary = 25000
            };
            Employee emp2 = new Employee()
            {
                EmpId = 101,
                Name = "Asad",
                Designation = "Assistant",
                Salary = 15000
            };
            Employee emp3 = new Employee()
            {
                EmpId = 102,
                Name = "Zain",
                Designation = "Database admin",
                Salary = 22000
            };
            Dictionary<int, Employee> employees = new Dictionary<int, Employee>();
            employees.Add(emp1.EmpId, emp1);
            employees.Add(emp2.EmpId, emp2);
            employees.Add(emp3.EmpId, emp3);

            Console.WriteLine(employees.Count(emp=>emp.Value.Salary>15000));
            Console.WriteLine(employees.Count(emp=>emp.Value.Name.StartsWith("A")));
        }
    }
}