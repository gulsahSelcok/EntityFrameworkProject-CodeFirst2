namespace CodeFirst_MtoMRelation
{
    partial class FormStudentTeacherRelationship
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Teacher = new System.Windows.Forms.Label();
            this.Student = new System.Windows.Forms.Label();
            this.dgvRelation = new System.Windows.Forms.DataGridView();
            this.btnRelation = new System.Windows.Forms.Button();
            this.cbTeacher = new System.Windows.Forms.ComboBox();
            this.lbStudents = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelation)).BeginInit();
            this.SuspendLayout();
            // 
            // Teacher
            // 
            this.Teacher.AutoSize = true;
            this.Teacher.Location = new System.Drawing.Point(39, 79);
            this.Teacher.Name = "Teacher";
            this.Teacher.Size = new System.Drawing.Size(47, 13);
            this.Teacher.TabIndex = 1;
            this.Teacher.Text = "Teacher";
            // 
            // Student
            // 
            this.Student.AutoSize = true;
            this.Student.Location = new System.Drawing.Point(39, 132);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(49, 13);
            this.Student.TabIndex = 3;
            this.Student.Text = "Students";
            // 
            // dgvRelation
            // 
            this.dgvRelation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelation.Location = new System.Drawing.Point(264, 49);
            this.dgvRelation.Name = "dgvRelation";
            this.dgvRelation.Size = new System.Drawing.Size(240, 307);
            this.dgvRelation.TabIndex = 4;
            // 
            // btnRelation
            // 
            this.btnRelation.Location = new System.Drawing.Point(54, 304);
            this.btnRelation.Name = "btnRelation";
            this.btnRelation.Size = new System.Drawing.Size(169, 23);
            this.btnRelation.TabIndex = 5;
            this.btnRelation.Text = "ASSOCIATE";
            this.btnRelation.UseVisualStyleBackColor = true;
            this.btnRelation.Click += new System.EventHandler(this.btnRelation_Click);
            // 
            // cbTeacher
            // 
            this.cbTeacher.FormattingEnabled = true;
            this.cbTeacher.Location = new System.Drawing.Point(102, 76);
            this.cbTeacher.Name = "cbTeacher";
            this.cbTeacher.Size = new System.Drawing.Size(121, 21);
            this.cbTeacher.TabIndex = 6;
            this.cbTeacher.SelectedIndexChanged += new System.EventHandler(this.cbTeacher_SelectedIndexChanged);
            // 
            // lbStudents
            // 
            this.lbStudents.FormattingEnabled = true;
            this.lbStudents.Location = new System.Drawing.Point(102, 116);
            this.lbStudents.Name = "lbStudents";
            this.lbStudents.Size = new System.Drawing.Size(120, 173);
            this.lbStudents.TabIndex = 7;
            // 
            // FormStudentTeacherRelationship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.lbStudents);
            this.Controls.Add(this.cbTeacher);
            this.Controls.Add(this.btnRelation);
            this.Controls.Add(this.dgvRelation);
            this.Controls.Add(this.Student);
            this.Controls.Add(this.Teacher);
            this.Name = "FormStudentTeacherRelationship";
            this.Text = "FormStudentTeacherRelationship";
            this.Load += new System.EventHandler(this.FormStudentTeacherRelationship_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Teacher;
        private System.Windows.Forms.Label Student;
        private System.Windows.Forms.DataGridView dgvRelation;
        private System.Windows.Forms.Button btnRelation;
        private System.Windows.Forms.ComboBox cbTeacher;
        private System.Windows.Forms.ListBox lbStudents;
    }
}