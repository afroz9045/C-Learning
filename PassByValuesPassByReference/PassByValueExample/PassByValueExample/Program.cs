// See https://aka.ms/new-console-template for more information
using PassByValueLib;
using PassByReferenceLib;
using PassByOutLib;

//Pass by value example
Console.WriteLine("Pass by value example:");
PassByValue pv = new PassByValue();
int num = 20;
Console.WriteLine(num);
Console.WriteLine(pv.passByVal(num));
Console.WriteLine(num);

//Pass by reference example
Console.WriteLine("\nPass by Reference example:");
PassByReference pr = new PassByReference();
int Num = 30;
Console.WriteLine(Num);
Console.WriteLine(pr.PassByRef(ref Num));
Console.WriteLine(Num);

//Pass by out
Console.WriteLine("\nPass by out");
int value ;
Console.WriteLine(PassByout.PassByOut(out value));
Console.WriteLine(value);

Console.WriteLine("Pass by value another example:");
int sum;
int product;
int number1 = 10;
int number2 =20;

PassByout.CalculateUsingOut(number1, number2, out sum, out product);
