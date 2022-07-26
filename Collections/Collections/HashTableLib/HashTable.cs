using System.Collections;
namespace HashTableLib
{
    public class HashTable
    {
        public static void CreateHashTable()
        {
            Hashtable ht = new Hashtable()
            {
                {"name","Mohd Afroz Khan"},
                {"Age", 23 },
                {"Designation","Software Engineer" }
            };
            //ht.Add("name","Mohd Afroz Khan");
            //ht.Add("Age", 23);
            //ht.Add("Designation","Software Engineer");

            Console.WriteLine(ht["name"]);
            Console.WriteLine(ht["Age"]);
            Console.WriteLine(ht["Designation"]);
            Hashtable dn = new Hashtable()
            {
                {"Old dotnet","dotnet framework"},
                {"latest dotnet","dotnet core"}
            };
            Console.WriteLine(dn.Contains("old dotnet")); // It returns false as 'o' case is small
            Console.WriteLine(dn.Contains("Old dotnet")); // It returns true

            Console.WriteLine(dn.ContainsValue("dotnet core")); // It returns true
            //dn.Clear();// It will clear the hash table
            Console.WriteLine(dn.Count);
        }
    }
}