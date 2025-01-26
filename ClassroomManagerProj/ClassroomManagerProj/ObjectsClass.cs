using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            return string.Format($"{Name},{Age},{Address}");
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
            return string.Format($"{Salutation},{Name},{SubjectSpeciality},{YearsOfService}"); ;
        }

        public string GetSalutation() { return Salutation; }
        public string GetName() { return Name; }
        public string GetSubject() { return SubjectSpeciality; }
        public int GetYears() { return YearsOfService; }
    }
    public class AClass
    {
        private string Name;
        Teacher ClassTeacher;
        List<Student> StudentsInClass;

        public AClass(string theName, Teacher theClassTeacher)
        {
            Name = theName;
            ClassTeacher = theClassTeacher;
            StudentsInClass = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            StudentsInClass.Add(student);
        }
        public string GetAsString()
        {
            return string.Format($"{Name},{ClassTeacher},{StudentsInClass}");
        }
        public string GetName() { return Name; }
        public Teacher GetTeacher() { return ClassTeacher; }
        public List<Student> GetStudentsInClass() {  return StudentsInClass; }
    }
}
