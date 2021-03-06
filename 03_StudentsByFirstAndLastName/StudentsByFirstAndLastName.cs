﻿using System;
using System.Collections.Generic;
using System.Linq;

/*
 * Print all students whose first name is before their last name alphabetically. Use a LINQ query.
 */

class StudentsByFirstAndLastName
{
    static void Main()
    {
        List<Student> studList = StudentsList.studentsList;
        var studentQry =
            from student in studList
            where student.FirstName.CompareTo(student.LastName) == -1
            select student;

        Console.WriteLine("*************** STUDENTS WHOSE FIRST NAME PRECEEDS (ALPHABETICALLY) LAST NAME ***********");
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