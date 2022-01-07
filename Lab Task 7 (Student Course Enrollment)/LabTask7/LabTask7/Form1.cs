using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTask7
{
    public partial class Form1 : Form
    {
        StudentCourseEnrollment enrollment = new StudentCourseEnrollment();
        Participant participant = new Participant();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddParticipant_Click(object sender, EventArgs e)
        {
            string Name = PartNameBox.Text;
            int Reg = Convert.ToInt32(PartRegBox.Text);
            string Contact = PartContactBox.Text;
            string Email = PartEmailBox.Text;
            string OrgSchool = SchoolOrgBox.Text;

            if (TypeBeginner.Checked && TypeProf.Checked)
            {
                Professional dummy_prof = new Professional(Name, Reg, Contact, Email, OrgSchool);
                dummy_prof.Level = "Beginner";
                StudentComboBox.Items.Add(dummy_prof.Reg);
                viewStudentComboBox.Items.Add(dummy_prof.Reg);
                enrollment.professionals.Add(dummy_prof);
            }

            if (TypeIntermediate.Checked && TypeProf.Checked)
            {
                Professional dummy_prof = new Professional(Name, Reg, Contact, Email, OrgSchool);
                dummy_prof.Level = "Intermediate";
                StudentComboBox.Items.Add(dummy_prof.Reg);
                viewStudentComboBox.Items.Add(dummy_prof.Reg);
                enrollment.professionals.Add(dummy_prof);
            }

            if (TypeAdvanced.Checked && TypeProf.Checked)
            {
                Professional dummy_prof = new Professional(Name, Reg, Contact, Email, OrgSchool);
                dummy_prof.Level = "Advanced";
                StudentComboBox.Items.Add(dummy_prof.Reg);
                viewStudentComboBox.Items.Add(dummy_prof.Reg);
                enrollment.professionals.Add(dummy_prof);
            }

            else if (TypeBeginner.Checked && TypeStudent.Checked)
            {
                Student dummy_student = new Student(Name, Reg, Contact, Email, OrgSchool);
                dummy_student.Level = "Beginner";
                StudentComboBox.Items.Add(dummy_student.Reg);
                viewStudentComboBox.Items.Add(dummy_student.Reg);
                enrollment.students.Add(dummy_student);
            }

            else if (TypeIntermediate.Checked && TypeStudent.Checked)
            {
                Student dummy_student = new Student(Name, Reg, Contact, Email, OrgSchool);
                dummy_student.Level = "Intermediate";
                StudentComboBox.Items.Add(dummy_student.Reg);
                viewStudentComboBox.Items.Add(dummy_student.Reg);
                enrollment.students.Add(dummy_student);
            }

            else if (TypeAdvanced.Checked && TypeStudent.Checked)
            {
                Student dummy_student = new Student(Name, Reg, Contact, Email, OrgSchool);
                dummy_student.Level = "Advanced";
                StudentComboBox.Items.Add(dummy_student.Reg);
                viewStudentComboBox.Items.Add(dummy_student.Reg);
                enrollment.students.Add(dummy_student);
            }

            MessageBox.Show("Participant has been added successfully!");
        }

        private void AddCourse_Click(object sender, EventArgs e)
        {
            string Title = CourseTitleBox.Text;
            int Fee = Convert.ToInt32(CourseFeeBox.Text);

            if (TypeBeginner2.Checked)
            {
                Course dummy_course = new Course(Title, Fee);
                dummy_course.Level = "Beginner";
                CourseComboBox.Items.Add(dummy_course.Title);
                enrollment.courses.Add(dummy_course);
            }

            if (TypeIntermediate2.Checked)
            {
                Course dummy_course = new Course(Title, Fee);
                dummy_course.Level = "Intermediate";
                CourseComboBox.Items.Add(dummy_course.Title);
                enrollment.courses.Add(dummy_course);
            }

            if (TypeAdvanced2.Checked)
            {
                Course dummy_course = new Course(Title, Fee);
                dummy_course.Level = "Advanced";
                CourseComboBox.Items.Add(dummy_course.Title);
                enrollment.courses.Add(dummy_course);
            }

            MessageBox.Show("Course has been added successfully!");
        }

        private void EnrollButton_Click(object sender, EventArgs e)
        {
            int partreg = Convert.ToInt32(StudentComboBox.Text);
            string coursename = CourseComboBox.Text;
            string date = dateTimePicker1.Text;
            
            foreach (Course course in enrollment.courses)
            {
                if (coursename == course.Title)
                {
                    foreach (Student student in enrollment.students)
                    {
                        if (partreg == student.Reg)
                        {
                            if (course.Level == student.Level)
                            {
                                course.Date = date;
                                student.EnrolledCourses.Add(course);
                                CourseFeeLabel.Text = "Course Fee: BDT " + course.Fee;

                                MessageBox.Show("Transaction successful!");
                                break;
                            }

                            else
                            {
                                MessageBox.Show("Participant and Course difficulty levels do not match. Please try again.");
                                break;
                            }
                        }
                    }

                    foreach (Professional professional in enrollment.professionals)
                    {
                        if (partreg == professional.Reg)
                        {
                            if (course.Level == professional.Level)
                            {
                                course.Date = date;
                                professional.EnrolledCourses.Add(course);
                                CourseFeeLabel.Text = "Course Fee: BDT " + (1.1*course.Fee);

                                MessageBox.Show("Transaction successful!");
                                break;
                            }

                            else
                            {
                                MessageBox.Show("Participant and Course difficulty levels do not match. Please try again.");
                                break;
                            }
                        }
                    }
                }
            }    
            

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ShowCourses_Click(object sender, EventArgs e)
        {
            CoursesListBox.Items.Clear();
            CoursesListBox.Items.Add("Course Title\tCourse Level\tCourse Fee\tEnrollment Date");

            foreach (Student student in enrollment.students)
            {
                if (Convert.ToInt32(viewStudentComboBox.Text) == student.Reg)
                {
                    foreach(Course course in student.EnrolledCourses)
                    {
                        CoursesListBox.Items.Add(course.Title + "\t\t" + course.Level + "\t\t"+ course.Fee + "\t\t" + course.Date +"\n");
                    }

                    CoursesListBox.Items.Add("Total Paid: " + student.getFee());
                    break;
                }
            }

            foreach (Professional professional in enrollment.professionals)
            {
                if (Convert.ToInt32(viewStudentComboBox.Text) == professional.Reg)
                {
                    foreach (Course course in professional.EnrolledCourses)
                    {
                        CoursesListBox.Items.Add(course.Title + "\t\t" + course.Level + "\t\t" + course.Fee + "\t\t" + course.Date + "\n");
                    }

                    CoursesListBox.Items.Add("Total Paid: " + professional.getFee());
                    break;
                }
            }
        }
    }
}
  

