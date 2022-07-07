namespace MethodOverloadingLib
{
    public class Parent
    {
        public void Add()
        {
            Console.WriteLine("This is method overloading");
        }
        public void Add((float, float) value)
        {
            int a = 20;
            int b = 30;
            int c = a + b;
            Console.WriteLine(c);
        } 
        public void Add(int a,int b)
        {
            Console.WriteLine(a+b);
        }  
        public void Add(float num1,float num2)
        {
            double c = num1 + num2;
            Console.WriteLine(c);
        }
        public void Add(string firstName,string lastName)
        {
            Console.WriteLine($"{firstName} {lastName}");
        }
    }
}