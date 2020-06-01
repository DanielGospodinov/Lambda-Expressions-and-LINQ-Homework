using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>()
            {
                new Student("Plamen", "Georgiev", "103189", "0286332", "plamen@abv.bg", new List<int> {6, 3, 4, 2, 3}, 1),
                new Student("Ivan", "Ivanov", "115106", "5551223", "ivan@gmail.com", new List<int> {3, 2, 2, 6, 3}, 2),
                new Student("Gosho", "Goshov", "106106", "0044213", "gosho@mail.com", new List<int> {5, 2 ,2, 4, 4}, 2),
                new Student("Mitko", "Mitkov", "222213", "0223267", "mitko@gmail.com", new List<int> {6, 6, 6, 2, 2}, 3),
                new Student("Marina", "Marinova", "333606", "088088333", "marina@abv.bg", new List<int> {2, 2, 2, 6, 6}, 2),
                new Student("Krum", "Krumov", "122289", "0686636", "krum@abv.bg", new List<int> {2, 3, 3, 2, 3}, 3),
                new Student("Petko", "Petkov", "111106", "0101223", "petko@gmail.com", new List<int> {6, 6, 6, 6, 6}, 1),
                new Student("Iva", "Ivova", "206206", "0555222", "iva@mail.com", new List<int> {5, 5, 5, 5, 5}, 1),
                new Student("Dimo", "Dimov", "189189", "03338834", "dimo@gmail.com", new List<int> {3, 6, 6, 3, 2}, 2),
                new Student("Krasen", "Petkov", "322300", "088088222", "krasen@abv.bg", new List<int> {2, 3, 2, 6, 3}, 3)
            };

            SelectByGroupAndOrderByNameLinq(list);
            SelectByGroupAndOrderByNameExpresion(list);
            SelectByEmail(list, "abv.bg");
            SelectByPhone(list, "02");
            SelectbyMarks(list, 6, 1,false);
            SelectbyMarks(list, 2, 2,true);
            SelectByYear(list);
        }

        static void Print(IEnumerable<Student> students)
        {
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
        }

        static void SelectByGroupAndOrderByNameLinq(List<Student> students)
        {
            var orderedStudents =
                from student in students
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;

            Console.WriteLine("Students from group number 2 are: (Using LINQ) ");
            Print(orderedStudents);
            Console.WriteLine();
        }

        static void SelectByGroupAndOrderByNameExpresion(List<Student> students)
        {
            var orderedStudents = students.Where(student => (student.GroupNumber == 2)).OrderBy(student => student.FirstName);

            Console.WriteLine("Students from group number 2 are: (Using Expresion) ");
            Print(orderedStudents);
            Console.WriteLine();
        }

        static void SelectByEmail(List<Student> students , String email)
        {
            var orderedStudents =
                from student in students
                where student.Email.Contains(email)
                select student;

            Console.WriteLine($"Students with email in {email} ");
            Print(orderedStudents);
            Console.WriteLine();
        }

        static void SelectByPhone(List<Student> students, String phoneCode)
        {
            var orderedStudents =
                from student in students
                where student.Telephone.StartsWith(phoneCode)
                select student;

            Console.WriteLine("Students with phone in Sofia :");
            Print(orderedStudents);
            Console.WriteLine();
        }

        static void SelectbyMarks(List<Student> students, int mark , int times , bool exp)
        {
            if (exp)
            {
                var orderedStudents =
                from student in students
                where student.Marks.Count(x => x == mark) == times
                select student;

                Console.WriteLine($"Students with Mark {mark} - {times} times");
                Print(orderedStudents);
                Console.WriteLine();
            }
            else
            {
                var orderedStudents =
                from student in students
                where student.Marks.Contains(mark)
                select student;

                Console.WriteLine($"Students with Mark {mark}");
                Print(orderedStudents);
                Console.WriteLine();
            }
        }

        static void SelectByYear(List<Student> students)
        {
            var orderedStudents =
                from student in students
                where student.FN.EndsWith("06")
                select student;

            Console.WriteLine("Students from 2006 : ");
            Print(orderedStudents);
            Console.WriteLine();
        }
}
}
