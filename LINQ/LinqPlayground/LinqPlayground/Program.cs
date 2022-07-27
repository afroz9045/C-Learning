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
                                    select new { student.First, Name = student.First + " " + student.Last, Average = student.Scores.Values.Average() };

            var qualifiedStudent = qualifiedStudents.FirstOrDefault();

            Console.Write($"\n\t\tTop performer is: {qualifiedStudent?.Name} with average of {qualifiedStudent?.Average}\n\n");


            //// First OR Default
            //var firstStudent = students.FirstOrDefault();
            //Console.WriteLine($"{firstStudent?.First} {firstStudent?.Last}");

            Console.WriteLine("");
            foreach (var student in studentsQuery)
            {
                Console.WriteLine($"{student.First} {student.Last} {student.Scores.Values.Average()}");
            }
            Console.WriteLine(studentsQuery.Count());



            var studentMaxMarksInMath = from maxMathMarks in students
                                        orderby maxMathMarks.Scores["Maths"] descending
                                        select new { Name = maxMathMarks.First + " " + maxMathMarks.Last ,HighestMathMarks = maxMathMarks.Scores["Maths"] };
            var mathTopperMarks = 0;
            Console.WriteLine("\n\n\nMaths Topper:\n");
            foreach (var maxMarks in studentMaxMarksInMath)
            {
                if (maxMarks.HighestMathMarks>= mathTopperMarks)
                {
                    mathTopperMarks = maxMarks.HighestMathMarks;
                }
                else
                {
                    break;
                }
                Console.WriteLine($"{maxMarks.Name} {mathTopperMarks}");
            }
            var studentMaxMarksInBio = from maxBioMarks in students
                                       orderby maxBioMarks.Scores["Bio"] descending
                                       select new { Name = maxBioMarks.First + " " + maxBioMarks.Last, HighestBioMarks = maxBioMarks.Scores["Bio"] };
            var bioTopperMarks = 0;
            Console.WriteLine("\n\n\nBio Topper:\n");
            foreach (var maxMarks in studentMaxMarksInBio)
            {
                if (maxMarks.HighestBioMarks >= bioTopperMarks)
                {
                    bioTopperMarks = maxMarks.HighestBioMarks;
                }
                else
                {
                    break;
                }
                Console.WriteLine($"{maxMarks.Name} {bioTopperMarks}");
            }
        }


        public static IEnumerable<Student> GetStudentsWithQuerySyntax(int rowCount, int pageIndex)
        {
            var skipRows = (pageIndex - 1) * rowCount;
            return (from student in students
                    let average = student.Scores.Values.Average()
                    orderby average descending
                    select student).Skip(skipRows).Take(rowCount);
        }

        public static IEnumerable<Student> GetStudentsWithMethodSyntax(int rowCount, int pageIndex)
        {
            var skipRows = (pageIndex - 1) * rowCount;
            return students.OrderBy(st => st.First).OrderBy(st => st.Last).MySkip(skipRows).MyTake(rowCount);
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
