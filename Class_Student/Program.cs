using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Student
{
    public class Student
    {
        public Guid id;
        public string firstName;
        public string middleName;
        public string lastName;
        public int age;
        public string group;
        public void Print() 
        {
            Console.WriteLine("Student info:");
            Console.WriteLine($"Id: {id}");
            Console.WriteLine($"First Name: {firstName}");
            Console.WriteLine($"Middle Name: {middleName}");
            Console.WriteLine($"Last Name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Group: {group}");
        }
    }
    class Program
    {
        static Student GetStudent()
        {   
            
            Student stud1 = new Student();
            stud1.id = Guid.NewGuid();
            stud1.firstName = "Taras";
            stud1.middleName = "Koliada";
            stud1.lastName = "Olehovych";
            stud1.age = 17;
            stud1.group = "FeP-12";
           
           
            return stud1;
        }
        static void Main(string[] args)
        {
            var firstStudent = GetStudent();
            firstStudent.Print();
            Console.WriteLine();
            var secondStudent = GetStudent();
           
            secondStudent.Print();
        }
    }
}
