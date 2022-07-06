using ProtectedAccessLib;
namespace PublicAccessLib
{
    public class publicAccess: ProtectedAccess
    {
        internal static string name = "Mohd afroz khan";
        public static void Show()
        {
            Console.WriteLine(name);
            Console.WriteLine("This is a public method");
            Console.WriteLine(ProtectedAccess.age);
        }
    }
}