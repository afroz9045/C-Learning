namespace StaticPropertyLib
{
    public class University
    {
        static string? UnivesityName;

        public static string _UnivesityName {
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Console.WriteLine("University name can't be empty!");
                }
                UnivesityName = value;
            }
            get
            {
                return UnivesityName;
            } 
        }
    }
}