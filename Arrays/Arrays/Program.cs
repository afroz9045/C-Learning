// See https://aka.ms/new-console-template for more information
//This is first approach of declaring an array
string[] FriendsNames = new string[4];
FriendsNames[0] = "Syed Zaki Ahmed";
FriendsNames[1] = "Syed Ibrahim";
FriendsNames[2] = "Taha Jamal";
FriendsNames[3] = "Shazeb mehdi";

Console.WriteLine("Friends:");
foreach (var friend in FriendsNames)
{
    Console.WriteLine(friend);
}

//This is an another approach for declaring an array

string[] BrotherNames = { "Firdoz khan", "Shabaz khan", "Fahad khan", "Sarfaraz khan" };
Console.WriteLine("\n\n\n");
Console.WriteLine("Brothers:");
foreach (var brother in BrotherNames)
{
    Console.WriteLine(brother);
}

//Types of Arrays
int[,] arr = new int[3, 4]
{
    {12,373,736,98},
    {74,87,90,365},
    {73,87,98,23}
};
Console.WriteLine("\n\nMulti dimentional array");
//Console.WriteLine(arr[1,2]);

int[,] arr1 = {
    {176,30,6,8},
    {4,7,100,65},
    {7,7,8,2}
};

//for (int i = 0; i < arr1.GetLength(0); i++)
//{
//    for (int j = 0; j < arr1.GetLength(1); j++)
//    {
//        Console.Write(arr1[i,j]+" ");
//    }
//    Console.WriteLine();
//}

foreach (int item in arr)
{
    Console.WriteLine(item);
}