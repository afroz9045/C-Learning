namespace TypesOfInheritance
{
    public class DerivedClass : BaseClass
    {   
        public void show2()
        {
            Console.WriteLine("This is a method of derived class...");
        }

    }
    public class DerivedClass1 : DerivedClass
    {
        public void show3()
        {

        }
    }
}
