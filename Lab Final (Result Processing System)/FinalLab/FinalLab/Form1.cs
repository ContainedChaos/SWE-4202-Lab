using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FinalLab
{
    public partial class Form1 : Form
    {
        public List <Student> students = new List <Student> ();

        public Form1()
        {
            InitializeComponent();

            StudentListBox.Items.Add("Name\t\t\tID");

            using (var reader = new StreamReader(@"D:\SOFTWARE\SWE4201MarkSheet (1).csv"))
            {
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    Student std = new Student();
                    std.ID = values[0];
                    std.Name = values[1];

                    std.Attd = values[2];
                    std.quiz[0] = values[3];
                    std.quiz[1] = values[4];
                    std.quiz[2] = values[5];
                    std.quiz[3] = values[6];
                    std.Mid = values[7];
                    std.Final = values[8];
                    std.Viva = values[9];

                    students.Add(std);

                    StudentListBox.Items.Add(std.getInfo());
                }
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string id = SearchResultTB.Text;

            var student = from stud in students
                          select stud;


            foreach(var std in student)
            {
                if (std.ID == id)
                {
                    std.getGrade();

                    AttendLabel.Text = "Attendance: " + std.Attd.ToString();
                    QuizTotal.Text = "Quiz Total: " + std.quizTotal.ToString();
                    MidLabel.Text = "Mid: " + std.Mid.ToString();
                    FinalLabel.Text = "Final: " + std.Final.ToString();
                    VivaLabel.Text = "Viva: " + std.Viva.ToString();
                    TotalLabel.Text = "Total: " + std.Total.ToString();
                    GradeLabel.Text = "Grade: " + std.grade.ToString();
                    PercentLabel.Text = "Percentage: " + std.percentage.ToString("#.##") + "%";
                    Quiz1Label.Text = "Quiz 1: " + std.quiz[0];
                    Quiz2Label.Text = "Quiz 2: " + std.quiz[1];
                    Quiz3Label.Text = "Quiz 3: " + std.quiz[2];
                    Quiz4Label.Text = "Quiz 4: " + std.quiz[3];
                }
            }
        }
    }
}
