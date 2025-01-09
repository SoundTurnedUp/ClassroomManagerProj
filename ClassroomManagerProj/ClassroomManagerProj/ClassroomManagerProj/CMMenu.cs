namespace ClassroomManagerProj
{
    public partial class CMMenu : Form
    {
        private List<Student> StudentsList = new List<Student>();
        public CMMenu()
        {
            InitializeComponent();
        }

        private void TeacherButton_Click(object sender, EventArgs e)
        {

        }

        private void StudentButton_Click(object sender, EventArgs e)
        {
            StudentMenu studentMenu = new StudentMenu(StudentsList);
            studentMenu.ShowDialog();
            StudentsList = studentMenu.GetStudentList();
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
