using System;
using System.Collections.Generic;
using System.Linq;

/*
 * Writes the list of students.
 */

class WriteStudentsList
{
    static void Main()
    {
        foreach (Student student in StudentsList.studentsList)
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