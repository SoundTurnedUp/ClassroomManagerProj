using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassroomManagerProj
{
    public partial class ClassMenu : Form
    {
        private ClassModel Model;
        private readonly List<AClass> classesList = new List<AClass>();
        public ClassMenu(ClassModel classModel)
        {
            InitializeComponent();
            Model = classModel;
        }

        private void ClassMenu_Load(object sender, EventArgs e)
        {
            foreach (Teacher teacher in Model.GetTeachersList())
            {
                listBoxTeachers.Items.Add($"{teacher.GetSalutation()}{teacher.GetName()}");
            }
            foreach (Student student in Model.GetStudentsList())
            {
                listBoxStudents.Items.Add($"{student.GetName()}");
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxClassName.Text))
            {
                ErrorLabel.Text = "Class name cannot be empty";
                ErrorLabel.ForeColor = Color.Red;
                ErrorLabel.Visible = true;
                return;
            }
            if (listBoxTeachers.SelectedItem == null)
            {
                ErrorLabel.Text = "A teacher must be selected";
                ErrorLabel.ForeColor = Color.Red;
                ErrorLabel.Visible = true;
                return;
            }
            string className = textBoxClassName.Text;
            string? teacher = listBoxTeachers.SelectedItem.ToString();
            string[] teacherData = teacher.Split(' ');
            string teacherSalutation = teacherData[0];
            string teacherName = teacherData[1];

            List<Teacher> teachersList = Model.GetTeachersList();
            Teacher? foundTeacher = null;
            foreach (Teacher t in teachersList)
            {
                if (t.GetSalutation() == teacherSalutation && t.GetName() == teacherName)
                {
                    foundTeacher = t;
                }
            }

            AClass newClass = new AClass(className, foundTeacher);

            foreach (string selectedStudent in listBoxStudents.SelectedItems)
            {
                List<Student> studentsList = Model.GetStudentsList();
                foreach (Student student in studentsList)
                {
                    if (student.GetName() == selectedStudent)
                    {
                        newClass.AddStudent(student);
                    }
                }
            }

            classesList.Add(newClass);
            DisplayClasses();
            textBoxClassName.Clear();
        }
        private void DisplayClasses()
        {
            listBoxClasses.Items.Clear();
            foreach (AClass aClass in classesList)
            {
                listBoxClasses.Items.Add(aClass.GetName());
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
