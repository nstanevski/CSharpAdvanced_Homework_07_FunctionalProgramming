using System;
using System.Collections.Generic;
using System.Linq;

/*
 * Print all students that have at least one mark Excellent (6). Using LINQ first select them
 * into a new anonymous class that holds { FullName + Marks}.
 */

class ExcellentStudents
{
    static void Main()
    {
        List<Student> studList = StudentsList.studentsList;
        var studentQry =
            from student in studList
            where student.Marks.IndexOf(6)>-1
            orderby student.FirstName
            select new
            {
                FullName = student.FirstName + " "+student.LastName,
                Marks = string.Join(", ", student.Marks.ToArray())
            };


        Console.WriteLine("*********** STUDENTS WITH EXCELLENT MARKS ***********");
        foreach (var data in studentQry)
        {
            Console.WriteLine("Name: {0}", data.FullName);
            Console.WriteLine("Marks: {0}", data.Marks);
            
            Console.WriteLine("=========================================");
        }
    }
}
