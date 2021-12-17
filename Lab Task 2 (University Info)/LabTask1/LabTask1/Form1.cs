using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTask1
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        List<Teacher> teachers = new List<Teacher>();
        List<Admin> admins = new List<Admin>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void SaveOnClick_Click(object sender, EventArgs e)
        {
            string ID = StudentIDBox.Text;
            string Name = StudentNameBox.Text;
            string dept = StudentDeptBox.Text;
            string semester = SemesterBox.Text;

            Student dummy_student = new Student();
            dummy_student.ID = ID;
            dummy_student.Name = Name;
            dummy_student.dept = dept;
            dummy_student.semester = semester;

            students.Add(dummy_student);

            MessageBox.Show("Student has been added succesfully!");
        }

        private void ClearOnClick_Click(object sender, EventArgs e)
        {
            StudentIDBox.Text = String.Empty;
            StudentNameBox.Text = String.Empty;
            StudentDeptBox.Text = String.Empty;
            SemesterBox.Text = String.Empty;

            MessageBox.Show("Student info has been cleared!");
        }

        private void ShowStudentListOnClick_Click(object sender, EventArgs e)
        {
            StudentList.Items.Clear();
            //for(int i = 0; i < students.Count; i++)
            //{
            //    StudentList.Items.Add(students[i].getInfo());
            //}

            foreach (Student student in students)
            {
                StudentList.Items.Add(student.getInfo());
            }    
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void StudentDeptBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearOnClick2_Click(object sender, EventArgs e)
        {
            TeacherNameBox.Text = String.Empty;
            TeacherIDBox.Text = String.Empty;
            TeacherDeptBox.Text = String.Empty;
            TeacherDesignBox.Text = String.Empty;
            TeacherSalaryBox.Text = String.Empty;

            MessageBox.Show("Teacher info has been cleared!");
        }

        private void SaveOnClick2_Click(object sender, EventArgs e)
        {
            //string ID = TeacherIDBox.Text;
            //string Name = TeacherNameBox.Text;
            //string dept = TeacherDeptBox.Text;
            //string design = TeacherDesignBox.Text;
            //string salary = TeacherSalaryBox.Text;

            Teacher dummy_teacher = new Teacher();
            dummy_teacher.ID = TeacherIDBox.Text;
            dummy_teacher.Name = TeacherNameBox.Text;
            dummy_teacher.dept = TeacherDeptBox.Text;
            dummy_teacher.design = TeacherDesignBox.Text;
            dummy_teacher.salary = TeacherSalaryBox.Text;

            teachers.Add(dummy_teacher);

            MessageBox.Show("Teacher has been added succesfully!");
        }

        private void ShowOnClick2_Click(object sender, EventArgs e)
        {
            TeacherList.Items.Clear();
            for (int i = 0; i < teachers.Count; i++)
            {
                TeacherList.Items.Add(teachers[i].getInfo2());
            }
        }

        private void TeacherDesignBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TeacherSalaryBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void SaveOnClick3_Click(object sender, EventArgs e)
        {
            string ID = AdminIDBox.Text;
            string Name = AdminNameBox.Text;
            string design = AdminDesignBox.Text;
            string salary = AdminSalaryBox.Text;

            Admin dummy_admin = new Admin();
            dummy_admin.ID = ID;
            dummy_admin.Name = Name;
            dummy_admin.design = design;
            dummy_admin.salary = salary;

            admins.Add(dummy_admin);

            MessageBox.Show("Admin has been added succesfully!");
        }

        private void ClearOnClick3_Click(object sender, EventArgs e)
        {
            AdminNameBox.Text = String.Empty;
            AdminIDBox.Text = String.Empty;
            AdminDesignBox.Text = String.Empty;
            AdminSalaryBox.Text = String.Empty;

            MessageBox.Show("Admin info has been cleared!");
        }

        private void ShowOnClick3_Click(object sender, EventArgs e)
        {
            AdminList.Items.Clear();
            for (int i = 0; i < admins.Count; i++)
            {
                AdminList.Items.Add(admins[i].getInfo());
            }
        }

        private void StudentNameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
