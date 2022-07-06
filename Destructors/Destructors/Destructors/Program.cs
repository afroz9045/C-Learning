using DestructorLib;

void ShowOutput()
{
    DestructorExample d = new DestructorExample("Afroz", 23);
    d.GetDetails();
}
ShowOutput();
GC.Collect();
Console.ReadLine();