using System;
using System.Collections.Generic;
using System.Linq;

/*
 * Print all students from group number 2. Use a LINQ query. Order the students by FirstName.
 */

class StudentsByGroup
{
    static void Main()
    {
        List<Student> studList = StudentsList.studentsList;
        var studentQry =
            from student in studList
            where student.GroupNumber == 2
            orderby student.FirstName
            select student;

        Console.WriteLine("*************** STUDENTS WITH GROUP NUMBER = 2 ***********");
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
