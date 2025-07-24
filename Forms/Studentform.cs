using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _9_EFOnlinecourseDB.Context;
using _9_EFOnlinecourseDB.Entities;
using _9_EFOnlinecourseDB.Managers;
using _9_EFOnlinecourseDB.Repositories;

namespace _9_EFOnlinecourseDB.Forms
{
    public partial class Studentform : Form
    {
        private readonly StudentManager _studentManager;
        private readonly StudentRepository _studentRepository;

        public Studentform()
        {
            //readonly bir değişkeni sadece ilk oluşturulduğunda ya da constructor içerisinde değer ataması yapılabilir. Böylece sınıfı içerisinde başka bir yerde değerinin değiştirilmesi engellenmiş olur.

            InitializeComponent();
            var db = new AppDBContext();
            _studentRepository = new StudentRepository(db);
            _studentManager = new StudentManager(_studentRepository);

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedStudent != null)

                {
                    //guncelleme
                    selectedStudent.Name= txtAd.Text;
                    selectedStudent.SurName= txtSoyad.Text;
                    selectedStudent.TCKimlikNo=txtTc.Text;
                    selectedStudent.Birthdate= DateOnly.Parse(txtDTarihi.Text);

                    _studentManager.Update(selectedStudent);
                    GetAllStudents();
                    MessageBox.Show("Güncelleme Başarılı");

                }
                else
                {
                    Student s = new Student()
                    {
                        Birthdate = DateOnly.Parse(txtDTarihi.Text),
                        Name = txtAd.Text,
                        SurName = txtSoyad.Text,
                        TCKimlikNo = txtTc.Text

                    };
                    _studentManager.Create(s);

                    GetAllStudents();
                    MessageBox.Show("Kayıt işlemi gerçekleşmiştir.");

                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void GetAllStudents()
        {
            lstListe.Items.Clear();
            _studentManager.GetAll()?.ForEach(x => lstListe.Items.Add(x));
        }



        private void Studentform_Load(object sender, EventArgs e)
        {
            GetAllStudents();
           
        }

        Student? selectedStudent;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedStudent = (Student?)lstListe.SelectedItem;

            if (selectedStudent != null)
            {
                txtAd.Text = selectedStudent.Name;
                txtSoyad.Text = selectedStudent.SurName;
                txtTc.Text = selectedStudent.TCKimlikNo;
                txtDTarihi.Text = selectedStudent.Birthdate.ToString();
            }
        }

        
            
            

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                //seçilen birşey varsa:
                if (lstListe.SelectedIndex!=-1)
                {
                    DialogResult result=MessageBox.Show("Silmek istedipinizden emin misiniz?","SİLME İŞLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        _studentManager.DeleteByID(selectedStudent?.ID ?? Guid.Empty);
                        GetAllStudents() ;
                        MessageBox.Show("Silme işlemi başarılı");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
