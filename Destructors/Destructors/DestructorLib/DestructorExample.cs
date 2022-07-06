namespace DestructorLib
{
    public class DestructorExample
    {
        public string Name;
        public int Age;

        public  DestructorExample(string Name,int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
        public void GetDetails()
        {
            Console.WriteLine(this.Name);
            Console.WriteLine(this.Age);
        }
        ~DestructorExample()
        {
            Console.WriteLine("Destructor invoked");
        }
    }
}