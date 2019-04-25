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
    public partial class FormTeacher : Form
    {
        public FormTeacher()
        {
            InitializeComponent();
        }

        UniversityContext db = DbSingleTone.GetInstance();
        private void TeacherFill()
        {//DataGridViewe öğretmenler ile ilgili Id,İsim ve Soyisim alanlarını aktarıyoruz.
            dgvTeacher.DataSource = db.Teachers.Select(x => new
            {
                x.ID,
                x.Name,
                x.Surname
            }).ToList();
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {//Yeni öğretmen ekliyoruz.
            Teacher teacher = new Teacher();
            teacher.Name = tbName.Text;
            teacher.Surname = tbSurname.Text;
            db.Teachers.Add(teacher);
            db.SaveChanges();
            TeacherFill();
        }

        private void FormTeacher_Load(object sender, EventArgs e)
        {
            TeacherFill();
        }
    }
}
