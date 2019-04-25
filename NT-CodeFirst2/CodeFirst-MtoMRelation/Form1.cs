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
{//Bu projede öğrenci ve öğretmen tanımlamaları yapılıyor. Bu tanımlamalardan sonra seçilen öğrencilere seçilen öğretmen atanıyor.Öğretmen ile öğrenci arasında ilişki oluşturuluyor.Bir öğrencinin birden çok öğretmeni olabilir.Bir öğretmenin birden çok öğrencisi olabilir.
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {//Formdan forma geçiş.
            FormStudent frm = new FormStudent();
            frm.Show();
            //this.Hide();
        }

        private void teacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTeacher frm = new FormTeacher();
            frm.Show();
           // this.Hide();
        }

        private void studentTeacherRelationshipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStudentTeacherRelationship frm = new FormStudentTeacherRelationship();
            frm.Show();
            //this.Hide();
        }
    }
}
