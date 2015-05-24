using System;
using System.Collections.Generic;

/*
 * Create a class Student with properties FirstName, LastName, Age, FacultyNumber, Phone, 
 * Email, Marks (IList<int>), GroupNumber.
 */

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string FacultyNumber { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public IList<int> Marks { get; set; }
    public int GroupNumber { get; set; }
}