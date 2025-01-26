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
            string ageText = textBoxAge.Text;
            string address = textBoxAddress.Text;
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(ageText) || string.IsNullOrWhiteSpace(address))
            {
                errorLabel.Text = "Fields cannot be empty";
                errorLabel.ForeColor = Color.Red;
                errorLabel.Visible = true;
                return;
            }

            if (!int.TryParse(ageText, out int age))
            {
                errorLabel.Text = "Age must be a valid number";
                errorLabel.ForeColor= Color.Red;
                errorLabel.Visible = true;
                return;
            }

            errorLabel.Visible = false;

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