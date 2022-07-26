using GenericsCollection;
using GenericClassLib;

//Collection c = new Collection();
int[] Numbers = {99,60,65,34};
string[] Names = { "Afroz", "Ibrahim", "Zaki", "Asif" };
Collection.ShowArray(Numbers);
Console.WriteLine("\nString array:");
Collection.ShowArray(Names/*&&This is not acceptable here*/);
Console.WriteLine("\nDecimal array:");
double[] PointNumbers = { 77.9, 88.87, 93.99 };
Collection.ShowArray(PointNumbers);

Console.WriteLine("type check:");
Console.WriteLine(Collection.Check(8, 8));

Console.WriteLine("Generic class Example");
GenericClassPractice<string> gcString = new GenericClassPractice<string>("fkdlg");
GenericClassPractice<int> gcInt = new GenericClassPractice<int>(86);
Console.WriteLine(gcString.getBox()); 
Console.WriteLine(gcInt.getBox()); 