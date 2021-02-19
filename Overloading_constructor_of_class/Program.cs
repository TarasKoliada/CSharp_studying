using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_constructor_of_class
{
   public class Student
    {
        public Student(string lastName, DateTime birthday)
        {
            _lastName = lastName;
            _birthday = birthday;
        }
        public Student(string firstName, string middleName, string lastName, DateTime birthday)
        {
            _firstName = firstName;
            _middleName = middleName;
            _lastName = lastName;
            _birthday = birthday;
        }
        public Student(Student student)
        {
            _firstName = student._firstName;
            _middleName = student._middleName;
            _lastName = student._lastName;
            _birthday = student._birthday;
        }
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private DateTime _birthday;
        public void Print()
        {
            Console.WriteLine($" FirstName: {_firstName}\n MiddleName: {_middleName}\n LastName: {_lastName}\n Birthday: {_birthday}\n\n");
        }
        public void setlastName(string lastName)
        {
            _lastName = lastName;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student stud1 = new Student("Taras", "Koliada", "Olehovych", new DateTime(2003, 7, 3));
            stud1.Print();

            Student stud2 = new Student(stud1);//переміщаємо данні про студента 1 в студента 2, але в методі setlastName змінюємо фамілію завдяки конструктору який приймає обєкт класу студент
            stud2.setlastName("Ivanov");
            stud2.Print();
        }
    }
}
