using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[]
            {
                new Student("Ivan","Petrov",23),
                new Student("Asen","Iliev",18),
                new Student("Qnko","Milenov",25),
                new Student("Boqn","Peev",20),
                new Student("Milena","Boykova",17),
                new Student("Anna","Andreeva",24),
                new Student("Ilian","Iliev",26)

            };

            IEnumerable<Student> firstNameStudents =
                from first in students
                where first.FirstName.CompareTo(first.LastName) < 0
                select first;

            Console.WriteLine("By First Name :");
            foreach (var item in firstNameStudents)
            {
                Console.WriteLine(item);
            }

            ////////////////////////////////////////////////////////////////////
            ///
            IEnumerable<Student> ageStudents =
                from age in students
                where age.Age >= 18 && age.Age <= 24
                select age;

            Console.WriteLine("\nBy Age :");
            foreach (var item in ageStudents)
            {
                Console.WriteLine(item);
            }

            /////////////////////////////////////////////////////////////////////
            ///
            IOrderedEnumerable<Student> orderByName = students.OrderByDescending(student => student.FirstName).ThenByDescending(student => student.LastName);

            Console.WriteLine("\nBy Names : ");
            foreach (var item in orderByName)
            {
                Console.WriteLine(item);
            }

            IEnumerable<Student> orderByNameLinq =
                from student in students
                orderby student.FirstName descending, student.LastName descending
                select student;

            Console.WriteLine("\nBy Names LINQ : ");
            foreach (var item in orderByNameLinq)
            {
                Console.WriteLine(item);
            }

            //////////////////////////////////////////////////////////////////////////
            ///
            int[] array = new int[] { 2, 4, 7, 21, 34, 42, 47, 49 };

            IEnumerable<int> numbers = array.Where(number => number % 3 == 0 && number % 7 == 0);

            Console.WriteLine("\nNumbers :");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            IEnumerable<int> numbersLinq =
                from number in array
                where number % 3 == 0 && number % 7 == 0
                select number;

            Console.WriteLine("\nNumbers LINQ :");
            foreach (var item in numbersLinq)
            {
                Console.WriteLine(item);
            }
        }
    }
}
