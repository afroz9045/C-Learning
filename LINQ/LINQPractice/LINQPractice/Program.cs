
Console.WriteLine("Numerical data:");
int[] age = { 23, 98, 34, 33, 48, 47, 38, 28, 40, 65, 12, 16, 18, 10 };
var a = from i in age
        where i > 20
        orderby i descending
        select i;

foreach (int item in a)
{
    Console.WriteLine(item);
}

string[] FriendsNames = { "Syed Zaki Ahmed", "Syed Ibrahim", "Shazeb mehdi", "Taha hussian jamal", "Mohd Asif", "Sharfuddin" };


Console.WriteLine("\nString array data:");
var friendsQuery = from name in FriendsNames orderby name select name;
foreach (var name in friendsQuery)
{
    Console.WriteLine(name);
}

Console.WriteLine("\nFriends name who have 'a' in their names:");
var friendsQuery1 = from name in FriendsNames
                    where name.Contains("a") 
                    select name;
foreach (var name in friendsQuery1)
{
    Console.WriteLine(name);
}

Console.WriteLine("\nFriends names who's names is starts with 'S':");
var friendsQuery2 = from name in FriendsNames
                    where name.StartsWith("S")
                    select name;


foreach (var name in friendsQuery2)
{
    Console.WriteLine(name);
}

Console.WriteLine("\nFriends names ends with 'jamal'");
var friendsQuery3 = from name in FriendsNames
                    where name.EndsWith("jamal")
                    select name;

foreach (var name in friendsQuery3)
{
    Console.WriteLine(name);
}


Console.WriteLine("LINQ for list collection:");

Console.WriteLine("\n\nWith Query syntax:");
List<int> list = new List<int>() {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16};
// Query syntax:
var ListQuery = from number in list
                where number % 2 == 0
                select number;

foreach (var num in ListQuery)
{
    Console.WriteLine(num);
}

// Method syntax:
Console.WriteLine("\n With method syntax:");
var methodSyntax = list.Where(num => num % 2 == 0);

foreach (var num in methodSyntax)
{
    Console.WriteLine(num);
}
