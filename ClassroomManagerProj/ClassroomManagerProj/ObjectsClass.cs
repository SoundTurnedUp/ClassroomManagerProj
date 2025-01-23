﻿using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomManagerProj
{
    public class Student
    {
        private string Name;
        private int Age;
        private string Address;

        public Student(string theName, int theAge, string theAddress)
        {
            Name = theName;
            Age = theAge;
            Address = theAddress;
        }
        public string GetAsString()
        {
            string formattedString = string.Format($"{Name},{Age},{Address}");
            return formattedString;
        }
        public string GetName() { return Name; }
        public int GetAge() { return Age; }
        public string GetAddress() { return Address; }
    }
    public class Teacher
    {
        private string Salutation;
        private string Name;
        private string SubjectSpeciality;
        private int YearsOfService;

        public Teacher(string theSalutation, string theName, string theSubject, int theYears)
        {
            Salutation = theSalutation;
            Name = theName;
            SubjectSpeciality = theSubject;
            YearsOfService = theYears;
        }
        public string GetAsString()
        {
            string formattedString = string.Format($"{Salutation},{Name},{SubjectSpeciality},{YearsOfService}");
            return formattedString;
        }
        public string GetSalutation() { return Salutation; }
        public string GetName() { return Name; }
        public string GetSubject() { return SubjectSpeciality; }
        public int GetYears() { return YearsOfService; }
    }
    public class aClass
    {
        private string Name;
        Teacher ClassTeacher;
        List<Student> StudentsInClass;

        public aClass(string theName, Teacher theClassTeacher, List<Student> theStudentsInClass)
        {
            Name = theName;
            ClassTeacher = theClassTeacher;
            StudentsInClass = theStudentsInClass;
        }
        public void AddStudent(Student student)
        {
            StudentsInClass.Add(student);
        }
    }
}
