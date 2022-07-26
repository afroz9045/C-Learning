using WithdrawValidation;
Console.WriteLine("Enter first number:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number:");
int num2 = Convert.ToInt32(Console.ReadLine());

//Divide by zero exception
try
{
    int result = num1 / num2;
    Console.WriteLine($"Division result is: {result}");
}
catch (DivideByZeroException dbz)
{

    Console.WriteLine("You cannot divide a number by zero!!");
    Console.WriteLine(dbz.Message);
}

//Index out of range exception
try
{
    int[] numbers = new int[3];
    numbers[0] = 1;
    numbers[1] = 2;
    numbers[2] = 3;
    numbers[3] = 4;

    foreach (var number in numbers)
    {
        Console.WriteLine(numbers);
    }
}
catch (IndexOutOfRangeException i)
{
    Console.WriteLine("Index out of range, range exceeded!");
    Console.WriteLine((i.Message));
}
finally { 
Console.WriteLine("\nRemaining statement 1");
Console.WriteLine("Remaining statement 2");
Console.WriteLine("Remaining statement 3");
}

Console.WriteLine("\n Withdraw function");
Withdraw.DoWithdraw();