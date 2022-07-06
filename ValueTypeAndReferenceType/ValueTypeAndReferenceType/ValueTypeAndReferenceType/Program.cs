using ValueTypeAndReferenceTypeExample;

//Console.WriteLine(ValueAndReferenceType.x+15); 
//Console.WriteLine(ValueAndReferenceType.y);
Console.WriteLine();
Console.WriteLine("Struct example");

Employee e = new Employee();
e.Salary = 5000;
e.Age = 23;

Employee e1 = e;
Employee e2 = e;
e.Age = 24;

Console.WriteLine($"e age is : {e.Age}");
Console.WriteLine($"e1 age is :{e1.Age}");
Console.WriteLine($"e2 age is :{e2.Age}");

//This is ReferenceEqualityComparer type example
ValueAndReferenceType Reftype = new ValueAndReferenceType();
Reftype.Age = 23;
Reftype.Salary = 20000;

ValueAndReferenceType Reftype1 = Reftype;
ValueAndReferenceType Reftype2 = Reftype;

Console.WriteLine($"Reftype object age before changing is:{Reftype.Age}");
Reftype.Age = 24;
Console.WriteLine($"Reftype object age after changing is:{Reftype.Age}");

Console.WriteLine($"Reftype 1 age is {Reftype1.Age}");
Console.WriteLine($"Reftype 2 age is {Reftype2.Age}");