namespace SomerenModel
{
    public class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Number { get; set; } // StudentNumber, e.g. 474791
        public int Age { get; set; }
        public int PhoneNumber { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}