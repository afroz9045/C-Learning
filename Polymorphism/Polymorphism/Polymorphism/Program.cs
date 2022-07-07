using MethodOverloadingLib;
using OperatorOverloading;
using MethodOverridingLib;

Parent o = new Parent();
o.Add();
o.Add(10, 10);
o.Add("Afroz","khan");
o.Add(5.3f, 8.9f);

OperatorOverload operate = new OperatorOverload();
operate.str = "Mohd";
operate.num = 20;

OperatorOverload operate1 = new OperatorOverload();
operate1.str = "Mohammed";
operate1.num = 100;

ParentExample pe = new ChildExample();
ParentExample pe1 = new ParentExample();
pe.print();
pe1.print();