using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Student
    {
        public Guid id;
        public string FirstName;
        public string MiddleName;
        public string LastName;
        public int age;
        public int group;
        public void Print()
        {
            Console.WriteLine($"Student id: {id}");
            Console.WriteLine($"First name: {FirstName}");
            Console.WriteLine($"Middle name: {MiddleName}");
            Console.WriteLine($"Last name: {LastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Group: {group}");
        }
    }
    class Program
    {
        static Student GetStudent()
        {
            var student = new Student();
            student.id = Guid.NewGuid();
            student.FirstName = "Jack";
            student.MiddleName = "Vorobenko";
            student.LastName = "Olegovich";
            student.age = 17;
            student.group = 12;
            return student;
        }
        static void Main(string[] args)
        {
            var FirstStudent = GetStudent();
            FirstStudent.Print();
        }
    }
}
