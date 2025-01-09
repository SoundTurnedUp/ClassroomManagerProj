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
    public partial class StudentMenu : Form
    {
        private readonly List<Student> StudentsList;
        public StudentMenu(List<Student> TheStudents)
        {
            StudentsList = TheStudents;
            InitializeComponent();
        }
        public List<Student> GetStudentList() { return StudentsList; }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            int age = int.Parse(textBoxAge.Text);
            string address = textBoxAddress.Text;

            Student student = new Student(name, age, address);
            StudentsList.Add(student);
            DisplayStudents();

            textBoxName.Clear();
            textBoxAge.Clear();
            textBoxAddress.Clear();
        }
        private void DisplayStudents()
        {
            studentsListBox.Items.Clear();
            foreach (Student student in StudentsList)
            {
                studentsListBox.Items.Add(student.GetName());
            }
        }

        private void StudentMenu_Load(object sender, EventArgs e)
        {
            DisplayStudents();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
