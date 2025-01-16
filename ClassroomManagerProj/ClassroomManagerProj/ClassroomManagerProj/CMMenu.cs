namespace ClassroomManagerProj
{
    public partial class CMMenu : Form
    {
        ClassModel classModel = new ClassModel();
        public CMMenu()
        {
            InitializeComponent();
        }

        private void TeacherButton_Click(object sender, EventArgs e)
        {
            TeachersMenu teacherMenu = new TeachersMenu(classModel.GetTeachersList());
            teacherMenu.ShowDialog();
            classModel.SaveToFile();
        }

        private void StudentButton_Click(object sender, EventArgs e)
        {
            StudentMenu studentMenu = new StudentMenu(classModel.GetStudentsList());
            studentMenu.ShowDialog();
            classModel.SaveToFile();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        private void ClassButton_Click(object sender, EventArgs e)
        {

        }

        private void SubjectButton_Click(object sender, EventArgs e)
        {

        }
    }
}
