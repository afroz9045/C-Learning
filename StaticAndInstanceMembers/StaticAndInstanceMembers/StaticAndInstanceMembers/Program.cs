using InstanceMembersLib;

InstanceMembers student1 = new InstanceMembers();
Console.WriteLine(student1.RollNumber=25);
InstanceMembers student2 = new InstanceMembers();
Console.WriteLine(student2.RollNumber = 27);

student1.FirstName = "Afroz";
student1.LastName = "Khan";

student2.FirstName = "Shabaz";
student2.LastName = "Khan";

student1.FullName();
student2.FullName();
Console.WriteLine(InstanceMembers.SchoolName);