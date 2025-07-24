using _9_EFOnlineCourseDB.Context;
using _9_EFOnlineCourseDB.Entities;
using _9_EFOnlineCourseDB.Managers;
using _9_EFOnlineCourseDB.Repositories;
using System.CodeDom;

namespace _9_EFOnlineCourseDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                AppDBContext db = new AppDBContext();
                StudentRepository sRepo = new StudentRepository(db);
                StudentManager sManager = new StudentManager(sRepo);

                Student std = new Student();
                std.Name = "Ahmet";
                std.BirthDate = DateOnly.Parse("10.10.1985");
                std.TCKimlikNo = "12343a32";
                sManager.Create(std);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
