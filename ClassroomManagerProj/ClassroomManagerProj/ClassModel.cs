﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomManagerProj
{
    public class ClassModel
    {
        private List<Student> studentsList = new List<Student>();
        private List<Teacher> teachersList = new List<Teacher>();
        private List<AClass> classesList = new List<AClass>();

        public List<Student> GetStudentsList() { return studentsList; }
        public List<Teacher> GetTeachersList() { return teachersList; }
        public List<AClass> GetClassesList() { return classesList; }
        public ClassModel()
        {

        }
        
        public void SaveToFile()
        {
            StreamWriter writer = new StreamWriter("ClassData.txt");
            writer.WriteLine(studentsList.Count);
            foreach (Student student in studentsList)
            {
                writer.WriteLine(student.GetAsString());
            }
            writer.WriteLine($"\n{teachersList.Count}");
            foreach (Teacher teacher in teachersList)
            {
                writer.WriteLine(teacher.GetAsString());
            }
            writer.WriteLine($"\n{classesList.Count}");
            foreach (AClass aClass in classesList)
            {
                writer.WriteLine(aClass.GetAsString());
            }
            writer.Close();
        }
        public void LoadFromFile()
        {
            StreamReader reader = new StreamReader("ClassData.txt");
            int numStudents = Convert.ToInt32(reader.ReadLine());
            for (int i = 0; i < numStudents; i++)
            {
                string[] studentInfo = reader.ReadLine().Split(',');
                Student student = new Student(studentInfo[0], int.Parse(studentInfo[1]), studentInfo[2]);
                studentsList.Add(student);
            }
            reader.ReadLine();
            int numTeachers = Convert.ToInt32(reader.ReadLine());
            for (int i = 0; i < numTeachers; i++)
            {
                string[] teacherInfo = reader.ReadLine().Split(',');
                Teacher teacher = new Teacher(teacherInfo[0], teacherInfo[1], teacherInfo[2], int.Parse(teacherInfo[3]));
                teachersList.Add(teacher);
            }
            reader.ReadLine();
            int numClasses = Convert.ToInt32(reader.ReadLine());
            for (int i = 0; i < numClasses; i++)
            {
                string[] classInfo = reader.ReadLine().Split(',');
            }
            reader.Close();
        }
    }
}
