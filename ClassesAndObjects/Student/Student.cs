namespace StudentLib
{
    public class Student
    {
        string StudentName;
        string RollNumber;
        int Standard;
        int Age;

        public void SetRollNumber(string studentName,string rollNumber,int standard,int age)
        {
            this.StudentName = studentName;
            this.RollNumber = rollNumber;
            this.Standard = standard;
            this.Age = age;
        }
        public string GetRollNumber()
        {
            return this.RollNumber;
        }
        public void GetStudentDetails()
        {
            Console.WriteLine($"Student name is {StudentName} roll number is {RollNumber} standard is {Standard} age is {Age} ");
        }
    }
}