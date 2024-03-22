namespace SomerenModel
{
    public class Lecturer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Number { get; set; } 
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string RoomNumber { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}