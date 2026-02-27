using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Person
    {
        protected string lastName;
        protected string firstName;

        public Person(string lastName, string firstName)
        {
            this.lastName = lastName;
            this.firstName = firstName;
        }

        public override string ToString()
        {
            return $"{firstName} {lastName}";
        }
    }
}
