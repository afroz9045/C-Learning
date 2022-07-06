using ConstructorLib;
using ConstructorOverloadingLib;
using StaticConstructorLib;

ConstructorPractice Afroz = new ConstructorPractice(3606,"Mohd Afroz Khan",23);
ConstructorPractice Parwez = new ConstructorPractice(3607,"mujawiz parvez",24);


Console.WriteLine(Parwez.GetEmpId());
Console.WriteLine(Afroz.GetEmpId());

Console.WriteLine(Parwez.GetEmpName());
Console.WriteLine(Afroz.GetEmpName());

Console.WriteLine(Parwez.GetAge());
Console.WriteLine(Afroz.GetAge());

ConstructorOverload name = new ConstructorOverload();
name = new ConstructorOverload("Afroz","Khan");
name = new ConstructorOverload("Mohd","Afroz","Khan");

StaticConstructor person = new StaticConstructor();
StaticConstructor person1 = new StaticConstructor();
person.GetDetails();