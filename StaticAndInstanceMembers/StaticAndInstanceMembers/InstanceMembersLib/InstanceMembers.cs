namespace InstanceMembersLib
{
    public class InstanceMembers
    {
        public int RollNumber;
        public string FirstName;
        public string LastName;
        public static string SchoolName = "Shangrila English High School";
        //int Standard;

        public void FullName()
        {
            Console.WriteLine($"Full name is: {this.FirstName} {this.LastName}");
        }
    }
}