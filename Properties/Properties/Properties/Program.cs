using PropertiesLib;
using AutoImplementPropertyLib;
using StaticPropertyLib;
Student ibrahim = new Student();
ibrahim.StdId = 10;
if (ibrahim.StdId > 0)
{
    Console.WriteLine(ibrahim.StdId);
}

ibrahim.Name = "Syed Ibrahim";
if (ibrahim.Name != "")
{
    Console.WriteLine(ibrahim.Name);
}

ibrahim.FatherName = "syed mudasir";
if(ibrahim.FatherName != "")
{
    Console.WriteLine(ibrahim.FatherName);
}
//ibrahim.SubjectTotalMarks = 80; //This gives error as this is read only
Console.WriteLine(ibrahim.SubjectTotalMarks);

Account ibrahimAccount = new Account();
Console.WriteLine(ibrahimAccount.AccountNumber);
Account afrozAccount = new Account();
Console.WriteLine(afrozAccount.AccountNumber);
Account afrozAccount2 = new Account();
Console.WriteLine(afrozAccount2.AccountNumber);

University._UnivesityName = "Jntuh";
Console.WriteLine(University._UnivesityName);
