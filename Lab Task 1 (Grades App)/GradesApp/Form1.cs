using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int attd, mid, final, q1, q2, q3, q4, total;
            string name = NameBox.Text;
            string grade = "";
            attd = Convert.ToInt32(AttendBox.Text);
            mid = Convert.ToInt32(MidBox.Text);
            final = Convert.ToInt32(FinalBox.Text);


            AttdLabel.Text = AttendBox.Text + "/30";
            MidLabel.Text = MidBox.Text + "/75"; 
            FinalLabel.Text = FinalBox.Text + "/150";
            //int quiztotal = q1 + q2 + q3 + q4;
            //QuizLabel.Text = quiztotal.ToString();
            int[] quiz = new int[4];
            quiz[0] = Convert.ToInt32(QuizBox1.Text);
            quiz[1] = Convert.ToInt32(QuizBox2.Text);
            quiz[2] = Convert.ToInt32(QuizBox3.Text);
            quiz[3] = Convert.ToInt32(QuizBox4.Text);

            Array.Sort(quiz);

            int quiztotal = quiz[1] + quiz[2] + quiz[3];
            QuizLabel.Text = quiztotal.ToString() + "/45";
            total = (mid + final + quiztotal + attd);
            TotalLabel.Text = total.ToString() + "/300";
            double percentage = (total / 300.0) * 100.0;

            total = quiztotal + attd + mid + final;


            if (percentage >= 80)
            {
                grade = "A+";
            }
            else if (percentage >= 75 && percentage < 80)
            {
                grade = "A";
            }
            else if (percentage >= 70 && percentage < 75)
            {
                grade = "A-";
            }
            else if (percentage >= 65 && percentage < 70)
            {
                grade = "B+";
            }
            else if (percentage >= 60 && percentage < 65)
            {
                grade = "B";
            }
            else if (percentage >= 55 && percentage < 60)
            {
                grade = "B-";
            }
            else if (percentage >= 50 && percentage < 55)
            {
                grade = "C+";
            }
            else if (percentage >= 45 && percentage < 50)
            {
                grade = "C";
            }
            else if (percentage >= 40 && percentage < 45)
            {
                grade = "D";
            }
            else if (percentage < 40)
            {
                grade = "F";
            }

            GradeLabel.Text = grade.ToString();

            ObtainedLabel.Text = name + " obtained " + percentage.ToString("#.##") + "% marks";
        }

        private void QuizBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
