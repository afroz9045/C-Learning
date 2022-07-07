using MethodHiding;

//Child child = new Child();
//child.show(); 
//((Parent)child).show();
Parent child = new Child();
child.show();
PartTimeEmployee pte = new PartTimeEmployee();
pte.PrintFullName();
fullTimeEmployee fte = new fullTimeEmployee();
fte.PrintFullName();
Employee emp = new PartTimeEmployee();
emp.PrintFullName();
