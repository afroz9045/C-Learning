namespace methods
{
    internal class Methods
    {
        public void show()
        {
            Console.WriteLine("Welcome to C# programming...");
            Console.WriteLine("Hello!");
        } public static void show1()
        {
            Console.WriteLine("Welcome to C# programming...");
            Console.WriteLine("Hello world!");
        }

        public void AddTwoNumbers(int num1,int num2)
        {
            int result = num1 + num2;
            Console.WriteLine(result);
        }
        public static void NameAndAge(string name,int age)
        {
            Console.WriteLine($"Your name is {name} and age is {age}");
        }
    }
}
