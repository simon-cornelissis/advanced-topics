using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    public class StudentData
    {
        public List<Student> students;

        public StudentData()
        {
            students = new List<Student> {
                new Student { Id= 1,
                              FirstName = "Freddie",
                              LastName = "Fish", Age = 18 },
                new Student { Id= 2,
                              FirstName = "Bill",
                              LastName = "Jones", Age = 21 },
                new Student { Id= 3,
                              FirstName = "Kitty",
                              LastName = "Cat", Age = 19 },
                new Student { Id= 4,
                              FirstName = "Suzy",
                              LastName = "Wan", Age = 20 }
            };
        }

        public List<Student> GetAllStudents()
        {
            return students;
        }
    }



}
