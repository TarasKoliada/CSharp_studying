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
            this.lastName = lastName;//приклад використання ключового слова this, вказуєм програмі шо звертаємось саме до приватної змінної
            this.birthday = birthday;
        }
        public Student(string firstName, string middleName, string lastName, DateTime birthday)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.birthday = birthday;
        }
        public Student(Student student)
        {
            firstName = student.firstName;
            middleName = student.middleName;
            lastName = student.lastName;
            birthday = student.birthday;
        }

        private string firstName;
        private string middleName;
        private string lastName;
        private DateTime birthday;
        public void Print()
        {
            Console.WriteLine($" FirstName: {firstName}\n MiddleName: {middleName}\n LastName: {lastName}\n Birthday: {birthday}\n\n");
        }
        public void setlastName(string lastName)
        {
            this.lastName = lastName;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student stud1 = new Student("Taras", "Koliada", "Olehovych", new DateTime(2003, 7, 3));
            stud1.Print();

            Student stud2 = new Student(stud1);
            stud2.setlastName("Ivanov");
            stud2.Print();
        }
    }
}