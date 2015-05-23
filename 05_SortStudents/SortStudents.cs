using System;
using System.Collections.Generic;
using System.Linq;

/*
 * Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students
 * by first name and last name in descending order. Rewrite the same with LINQ query syntax.
 */

class SortStudents
{
    static void Main()
    {
        List<Student> studList = StudentsList.studentsList;

        IEnumerable<Student> orderedStudList =
            studList
            .OrderByDescending(student => student.FirstName)
            .ThenByDescending(student => student.LastName);

        Console.WriteLine("* STUDENTS ORDERED BY FIRST&LAST NAME IN DESC. ORDER USING EXTENSION METHODS *");
        foreach (Student student in orderedStudList)
        {
            Console.WriteLine("First name: {0}", student.FirstName);
            Console.WriteLine("Last name: {0}", student.LastName);
            Console.WriteLine("Age: {0}", student.Age);
            Console.WriteLine("Faculty number: {0}", student.FacultyNumber);
            Console.WriteLine("Phone: {0}", student.Phone);
            Console.WriteLine("Email: {0}", student.Email);
            Console.WriteLine("Marks: {0}", String.Join(", ", student.Marks.ToArray()));
            Console.WriteLine("Group Number: {0}", student.GroupNumber);
            Console.WriteLine("=========================================");
        }

        
        var studentQry =
            from student in studList
            orderby student.FirstName descending, student.LastName descending
            select student;

        Console.WriteLine("* STUDENTS ORDERED BY FIRST&LAST NAME IN DESC. ORDER USING LINQ QUERY *");
        foreach (Student student in studentQry)
        {
            Console.WriteLine("First name: {0}", student.FirstName);
            Console.WriteLine("Last name: {0}", student.LastName);
            Console.WriteLine("Age: {0}", student.Age);
            Console.WriteLine("Faculty number: {0}", student.FacultyNumber);
            Console.WriteLine("Phone: {0}", student.Phone);
            Console.WriteLine("Email: {0}", student.Email);
            Console.WriteLine("Marks: {0}", String.Join(", ", student.Marks.ToArray()));
            Console.WriteLine("Group Number: {0}", student.GroupNumber);
            Console.WriteLine("=========================================");
        }
    }
}