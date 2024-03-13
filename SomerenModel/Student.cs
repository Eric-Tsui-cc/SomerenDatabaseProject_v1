using System;

namespace SomerenModel
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Number { get; set; } // StudentNumber, e.g. 474791
        public string Class { get; set; }
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