namespace StaticConstructorLib
{
    public class StaticConstructor
    {
        public static string PersonName;
        public static int PersonAge;

        static StaticConstructor()
        {
            PersonName = "Mohd Yousuf Khan";
            PersonAge = 97;
            Console.WriteLine("Static Constructor invoked");
        }
        public StaticConstructor()
        {
            Console.WriteLine("Default constructor invoked!");
        }
        public void GetDetails()
        {
            Console.WriteLine($"Person name is {PersonName} and age is {PersonAge} ");
        }
    }
}