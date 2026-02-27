using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Teacher : Person
    {
        protected int teacherId;

        public Teacher(string firstName, string lastName, int Id)
            : base(firstName, lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.teacherId = Id;
        }
    }
}
