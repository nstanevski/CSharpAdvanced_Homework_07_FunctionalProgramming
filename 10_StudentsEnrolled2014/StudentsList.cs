using System;
using System.Collections.Generic;

/*
 * Create a List<Student> with sample students.
 */

class StudentsList
{
    public static List<Student> studentsList = new List<Student>(){

            new Student(){ 
                FirstName ="Ivan", LastName = "Angelov",
                Age = 22, FacultyNumber="893014",
                Phone="02 89333444", Email = "ivan@abv.bg", 
                Marks = new List<int>(){2, 6, 4, 5, 3, 3},
                GroupNumber = 2},

            new Student(){ 
                FirstName ="Peter", LastName = "Petrov",
                Age = 23, FacultyNumber="891023", 
                Phone="+359233444", Email = "peter@abc.com", 
                Marks = new List<int>(){3, 3, 4, 2, 3, 3},
                GroupNumber = 3},

                new Student(){ 
                FirstName ="Georgi", LastName = "Georgiev",
                Age = 21, FacultyNumber="891533", 
                Phone="0873456144", Email = "gosho@xyz.com", 
                Marks = new List<int>(){6, 6, 5, 6, 6, 6},
                GroupNumber = 1},

                new Student(){ 
                FirstName ="Maria", LastName = "Marinova",
                Age = 27, FacultyNumber="991514", 
                Phone="+3592452224", Email = "maria@abv.com", 
                Marks = new List<int>(){4, 6, 5, 6, 6, 6},
                GroupNumber = 1},

                new Student(){ 
                FirstName ="Stoyanka", LastName = "Alieva",
                Age = 26, FacultyNumber="851533", 
                Phone="0823456144", Email = "stoyanka@abv.bg", 
                Marks = new List<int>(){2, 6, 5, 6, 2, 6},
                GroupNumber = 2},

                new Student(){ 
                FirstName ="Dragan", LastName = "Draganov",
                Age = 41, FacultyNumber="855533", 
                Phone="0853456144", Email = "dragan@abv.bg", 
                Marks = new List<int>(){3, 5, 2, 2, 5, 5},
                GroupNumber = 1},

                new Student(){ 
                FirstName ="Milan", LastName = "Milanov",
                Age = 26, FacultyNumber="841533", 
                Phone="+359 28888888", Email = "milan@miladinov.com", 
                Marks = new List<int>(){2, 3, 4, 5, 6, 2},
                GroupNumber = 3},
        };
}