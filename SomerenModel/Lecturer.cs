using System.Security.Claims;

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
        public Lecturer() { }
        public Lecturer(int number, string firstName, string lastName, string phoneNumber, int @age, string roomNumber)
        {
            Number = number;
            FirstName = firstName;
            LastName = lastName;
            RoomNumber = roomNumber;
            PhoneNumber = phoneNumber;
            Age = @age;
        }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}