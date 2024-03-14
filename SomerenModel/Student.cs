using System;

namespace SomerenModel
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Number { get; set; } 
        public string RoomNumber { get; set; }
        public string TelePhoneNumber { get; set; }
        public string Class { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}