using CodeFirst_MtoMRelation.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirst_MtoMRelation
{
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
        }
        UniversityContext db =DbSingleTone.GetInstance();//Veritabanı bağlantı sağlayacağımız class nesnesi
        private void StudentFill()
        {//DataGridViewe öğrenciler ile ilgili Id,İsim ve Soyisim alanlarını aktarıyoruz.
            dgvStudent.DataSource = db.Students.Select(x => new
            {
                x.ID,
                x.Name,
                x.Surname
            }).ToList();
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {//Yeni öğrenci ekliyoruz.
            Student student = new Student();
            student.Name = tbName.Text;
            student.Surname = tbSurname.Text;
            db.Students.Add(student);//Veritabanındaki Students tablosuna nesnemizi gönderiyoruz.
            db.SaveChanges();//Veritabanına değişiklikleri kaydederç
            StudentFill();//Bilgileri tekrardan yükler.
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {//Form açıldığında ilk önce bu kısımda yer alan şeyler çalışır.
            StudentFill();
        }
    }
}
