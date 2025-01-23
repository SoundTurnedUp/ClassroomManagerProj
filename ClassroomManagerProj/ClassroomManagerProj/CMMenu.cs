namespace ClassroomManagerProj
{
    public partial class CMMenu : Form
    {
        private ClassModel classModel = new ClassModel();

        public CMMenu()
        {
            InitializeComponent();
            classModel.LoadFromFile();
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
            ClassMenu classMenu = new ClassMenu(classModel);
            classMenu.ShowDialog();
        }

        private void SubjectButton_Click(object sender, EventArgs e)
        {

        }
    }
}
