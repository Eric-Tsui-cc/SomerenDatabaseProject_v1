using System;

namespace SomerenModel
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Number { get; set; } // StudentNumber, e.g. 474791
        public string RoomNumber { get; set; }
        public int TelePhoneNumber { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}