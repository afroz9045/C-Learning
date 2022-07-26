namespace PartialClass
{
    public partial class PartialClassDemo
    {
        private string _firstName;
        private string _lastName;

        public string FirstName {
            set
            {
                _firstName = value;
            }
            get
            {
                return _firstName;
            }
        }
        
        public string LastName { get => _lastName; set => _lastName = value; }
        
    }
}
