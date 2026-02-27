using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Group
    {
        public string Name { get; set; }
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }

        public override string ToString()
        {
            return $"Group {Name} has teacher {Teacher.ToString()}";
        }
    }
}
