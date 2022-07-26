// See https://aka.ms/new-console-template for more information
using LinqPlayground;


using System;

namespace ConsoleApp1
{
    internal class Program
    {
        // Create a data source by using a collection initializer.
        public static List<Student> students = Student.GetStudents();
        static void Main(string[] args)
        {

            var studentsQuery = GetStudentsWithQuerySyntax(30, 1);
            //var studentsQuery = GetStudentsWithMethodSyntax(3, 2);

            // Projection transformation to string
            //var qualifiedStudents = from student in studentsQuery
            //                        select student.First + " " + student.Last;

            // Projection transformation to annonymous collection.
            var qualifiedStudents = from student in studentsQuery
                                    select new { student.First, Name = student.First + " " + student.Last, Average = student.Scores.Average() };

            var qualifiedStudent = qualifiedStudents.FirstOrDefault();

            Console.Write(qualifiedStudent?.Name + " " + qualifiedStudent?.Average + "\n");


            //// First OR Default
            //var firstStudent = students.FirstOrDefault();
            //Console.WriteLine($"{firstStudent?.First} {firstStudent?.Last}");


            foreach (var student in studentsQuery)
            {
                Console.WriteLine($"{student.First} {student.Last} {student.Scores.Average()}");
            }
            Console.WriteLine(studentsQuery.Count());
        }

        public static IEnumerable<Student> GetStudentsWithQuerySyntax(int rowCount, int pageIndex)
        {
            var skipRows = (pageIndex - 1) * rowCount;
            return (from student in students
                    let average = student.Scores.Average()
                    orderby average descending
                    select student).Skip(skipRows).Take(rowCount);
        }

        public static IEnumerable<Student> GetStudentsWithMethodSyntax(int rowCount, int pageIndex)
        {
            var skipRows = (pageIndex - 1) * rowCount;
            return students.OrderBy(st => st.First).OrderBy(st=>st.Last).MySkip(skipRows).MyTake(rowCount);
        }
    }
    static class StudentExtensions
    {
        public static IEnumerable<Student> MySkip(this IEnumerable<Student> students, int value)
        {
            return students.Skip(value);
        }
        public static IEnumerable<Student> MyTake(this IEnumerable<Student> students, int value)
        {
            return students.Take(value);
        }
    }
}
