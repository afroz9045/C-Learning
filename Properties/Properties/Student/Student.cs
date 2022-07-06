namespace PropertiesLib

{
    public class Student
    {
        private int _StdId;
        private string? _Name;
        private string? _FatherName;
        private int _SubjectTotalMarks = 100;

        public int StdId
        {
            get { return _StdId; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Student id can't be zero or negative");
                }
                _StdId = value;
            }
        }

        public string Name
        {
            get { return _Name; }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Name can't be empty or null!");
                }
                _Name = value;
            }
        }
        public string FatherName
        {
            get { return _FatherName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Father name can't be empty or null");
                }
                _FatherName = value;
            }
        }
        public int SubjectTotalMarks
        {
            get { return _SubjectTotalMarks; }
        }
    }
}