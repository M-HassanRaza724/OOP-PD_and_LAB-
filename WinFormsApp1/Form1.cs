namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BindingSource CourseBindingSource = new BindingSource();

        private void CourseManagement_Load(object sender, EventArgs e)
        {

        CourseBindingSource.DataSource = CourseCRUD.GetAllCourses();
            dataGridView1.DataSource = CourseBindingSource;
            MessageBox.Show("Data Loaded Successfully");

        }




        // Ensure there is only one InitializeComponent method

    }
}
