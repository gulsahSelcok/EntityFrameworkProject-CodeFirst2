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
    public partial class FormStudentTeacherRelationship : Form
    {
        public FormStudentTeacherRelationship()
        {
            InitializeComponent();
        }
        UniversityContext db = DbSingleTone.GetInstance();

        private void FormStudentTeacherRelationship_Load(object sender, EventArgs e)
        {
            StudentFill();
            TeacherFill();
            lbStudents.MultiColumn = true;
            lbStudents.SelectionMode = SelectionMode.MultiExtended;
            //DataGrig ekranında çoklu satır seçimi yapabilmek için MultiSelect propertysini true ve selectionModunu FullRowSelect yapmamız gerekir.
        }
        private void StudentFill()
        {
            var students = db.Students.Select(x => new MyEntry
            {
                Fullname=x.Name + " " +x.Surname,
                StudentID=x.ID
            }).ToList();
            lbStudents.DisplayMember= "Fullname";//ListBoxın görünen değerlerine veritabanından aldığımız Fullname değerlerini atıyoruz.
            lbStudents.ValueMember = "StudentID";//ListBoxın üye değerine veritabanından aldığımız öğrenci ıdsini atıyoruz ki üzerinde işlem yapacağımız zaman bu ıd üzerinden işlem yapabilelim.
            lbStudents.DataSource = students;//ListBoxın veri kaynağını veri tabanımızdan çektiğimiz listeyi tutan nesne durumuna getirdik.
            lbStudents.SelectedItems.Clear();
        }
        private void TeacherFill()
        {
            var teachers = db.Teachers.Select(x => new
            {
                Fullname = x.Name + " " + x.Surname,
                TeacherID = x.ID
            }).ToList();
            cbTeacher.DisplayMember = "Fullname";
            cbTeacher.ValueMember = "TeacherID";
            cbTeacher.DataSource = teachers;
        }

        private void btnRelation_Click(object sender, EventArgs e)
        { //Öğretmen ve öğrenci tabloları arasında ilişki kuruluyor.Seçilen öğretmene(1), seçilen öğrenci veya öğrenciler atanıyor(2).
            int selectedTeacherID = Convert.ToInt32(cbTeacher.SelectedValue);//1
            Teacher teacher = db.Teachers.Find(selectedTeacherID);
            foreach (MyEntry item in lbStudents.SelectedItems)//2
            {
                Student studentSelected = db.Students.Find(item.StudentID);
                teacher.students.Add(studentSelected);
            }
            db.SaveChanges();//Değişiklikler kaydedilir.
            lbStudents.SelectedItems.Clear();
            dgvRelation.DataSource = teacher.students.ToList();
        }

        private void cbTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {//Seçilen öğretmen değiştiğinde öğretmenin öğrencileri de değişme işleminin yapıldığı yer.
            //Teacher teacher = cbTeacher.SelectedItem as Teacher;
            //var teacherStudents = db.Teachers.Find(teacher.ID).students.ToList();
            //Alternative way
            int chosenTeacherID = Convert.ToInt32(cbTeacher.SelectedValue);
            Teacher teacher = db.Teachers.Find(chosenTeacherID);
            dgvRelation.DataSource = teacher.students.ToList();
        }
    }
}
