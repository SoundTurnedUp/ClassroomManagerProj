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
    public partial class TeachersMenu : Form
    {
        private readonly List<Teacher> TeachersList;
        public TeachersMenu(List<Teacher> theTeachers)
        {
            TeachersList = theTeachers;
            InitializeComponent();
        }
        public List<Teacher> GetTeacherList() { return TeachersList; }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string Salutation = comboBoxSalutation.SelectedItem?.ToString();
            string Name = textBoxName.Text;
            string Subject = comboBoxSubjects.SelectedItem?.ToString();
            string YearsText = textBoxYears.Text;

            if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(YearsText))
            {
                ErrorLabel.Text = "Fields cannot be empty";
                ErrorLabel.ForeColor = Color.Red;
                ErrorLabel.Visible = true;
                return;
            }
            if (!int.TryParse(YearsText, out var YoS))
            {
                ErrorLabel.Text = "Experience must be a valid number of years";
                ErrorLabel.ForeColor = Color.Red;
                ErrorLabel.Visible = true;
                return;
            }

            ErrorLabel.Visible = false;

            Teacher teacher = new Teacher(Salutation, Name, Subject, YoS);
            TeachersList.Add(teacher);
            DisplayTeachers();

            comboBoxSalutation.SelectedIndex = 0;
            textBoxName.Clear();
            comboBoxSubjects.SelectedIndex = 0;
            textBoxYears.Clear();
        }
        public string GetAsString()
        {
            string salutation = comboBoxSalutation.SelectedItem?.ToString();
            string name = textBoxName.Text;
            string subject = comboBoxSubjects.SelectedItem?.ToString();
            string yearsText = textBoxYears.Text;

            string formattedString = $"{salutation}, {name}, {subject}, {yearsText}";
            return formattedString;
        }
        private void DisplayTeachers()
        {
            listViewTeachers.Items.Clear();

            foreach (Teacher teacher in TeachersList)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    teacher.GetSalutation() + " " + teacher.GetName(),
                    teacher.GetSubject(),
                    teacher.GetYears().ToString()
                });

                item.Tag = teacher;
                listViewTeachers.Items.Add(item);
            }
        }
        private void TeachersMenu_Load(object sender, EventArgs e)
        {
            comboBoxSalutation.Items.AddRange(new string[] { "Mr. ", "Sir. ", "Mrs. ", "Miss. ", "Ms. ", "Dr. ", "Prof. " });
            comboBoxSubjects.Items.AddRange(new string[] { "Art", "Biology", "Chemistry", "Computer Science", "Economics", "English", "French", "Geography", "History", "Mathematics", "Music", "Physical Education", "Physics", "Psychology", "Sociology", "Spanish", "Theater" });
            DisplayTeachers();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
