using System;
using System.Collections.Generic;
using System.Linq;

/*
 * Extract and print the Marks of the students that enrolled in 2014 
 * (the students from 2014 have 14 as their 5-th and 6-th digit in the FacultyNumber)
 */

class StudentsEnrolled2014
{
    static void Main()
    {
        List<Student> studList = StudentsList.studentsList;
        
        var studentQry =
            from student in studList
            where student.FacultyNumber.Substring(4,2).Equals("14")
            orderby student.FirstName
            select student;

        Console.WriteLine("* STUDENTS ENROLLED IN 2014 *");
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