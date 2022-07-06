namespace PassByOutLib
{
    public class PassByout
    {
        public static int PassByOut(out int a)
         {
            a = 30;
            return a;
        }
        public static void CalculateUsingOut(int num1,int num2,out int sum,out int product)
        {
            sum = num1 + num2;
            product = num1 * num2;
            Console.WriteLine($"Sum of {num1} and {num2} is {sum}");
            Console.WriteLine($"Product of {num1} and {num2} is {product}");
        }
    }
}