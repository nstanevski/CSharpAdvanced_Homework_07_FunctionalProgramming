using System;
using System.Collections.Generic;
using System.Linq;

/*
 * Write a LINQ query that finds the first name and last name of all students 
 * with age between 18 and 24. The query should return only the first name, last name and age. 
 */

class StudentsByAge
{
    static void Main()
    {
        List<Student> studList = StudentsList.studentsList;
        var studentQry =
            from student in studList
            where student.Age >= 18 && student.Age <= 24
            orderby student.Age
            select new { 
                fname = student.FirstName, 
                lname = student.LastName, 
                age = student.Age
            };
            

        Console.WriteLine("*********** NAME AND AGE OF STUDENTS BETWEEN 18 AND 24 YRS. OLD ***********");
        foreach (var  data in studentQry)
        {
            Console.WriteLine("First name: {0}",data.fname);
            Console.WriteLine("Last name: {0}", data.lname);
            Console.WriteLine("Age: {0}", data.age);
            Console.WriteLine("=========================================");
        }
    }
}