using System;

namespace WpfApp.Model
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person()
        {
            FirstName = "One";
            LastName = "Two";
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
