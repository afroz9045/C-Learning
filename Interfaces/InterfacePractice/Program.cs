using InterfaceLib;
using InterfaceInheritanceLib;
using ExplicitInterfaceImplementation;
PartTimeEmployees pte =  new PartTimeEmployees();
pte.show();
pte.Print();
pte.Print1();
pte.Print2();

I3 i = pte;

i.Print();
i.Print1();
i.Print2();

//Explicit e = new Explicit();
//((EI1)e).show();
//((EI2)e).show();

EI1 ei1 = new Explicit();
ei1.show();
EI2 ei2 = new Explicit();
ei2.show();
