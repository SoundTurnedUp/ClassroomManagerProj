using System;
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

        public ClassModel()
        {

        }
        public List<Student> GetStudentsList() { return studentsList; }
        public List<Teacher> GetTeachersList() { return teachersList; }

        public void SaveToFile()
        {
            StreamWriter writer = new StreamWriter("ClassData.txt");
            writer.WriteLine(studentsList.Count);
            foreach (Student student in studentsList)
            {
                StudentMenu studentMenu = new StudentMenu(studentsList);
                writer.WriteLine(studentMenu.GetAsString());
            }
            writer.WriteLine(teachersList.Count);
            foreach (Teacher teacher in teachersList)
            {
                TeachersMenu teacherMenu = new TeachersMenu(teachersList);
                writer.WriteLine(teacherMenu.GetAsString());
            }
        }
    }
}
