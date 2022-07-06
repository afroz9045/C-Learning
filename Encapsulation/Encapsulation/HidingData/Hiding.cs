namespace HidingData
{
    public class Hiding
    {
        string Name;
        int Age;
         
        public void setName(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name should not be empty");
            }
            this.Name = name;

        }
        public void getName()
        {
            if(Name == null)
            {

            }
            Console.WriteLine("Your name is:"+this.Name);
        }
        public void setAge(int age)
        {
            if (age > 0)
            {
                this.Age = age;
            }
            else { 
            Console.WriteLine("Age should not be negative and zero");
            }
        }
        public void getAge()
        {
            if (Age > 0)
            {
                Console.WriteLine("Your age is:" + this.Age);
            }
            else
            {

            }
            
        }
    }
}