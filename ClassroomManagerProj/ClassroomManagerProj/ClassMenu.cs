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
            string Name = textBoxClassName.Text;
            string Teacher = listBoxTeachers.SelectedItem.ToString();
            if (string.IsNullOrWhiteSpace(Name))
            {
                ErrorLabel.Text = "Class name cannot be empty";
                ErrorLabel.ForeColor = Color.Red;
                ErrorLabel.Visible = true;
                return;
            }

        }
    }
}
