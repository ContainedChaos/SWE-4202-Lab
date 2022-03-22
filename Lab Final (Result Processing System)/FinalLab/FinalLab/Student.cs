using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLab
{
    public class Student
    {
        public string ID;
        public string Name;
        public string[] quiz = new string[4];
        public string Attd;
        public string Mid;
        public string Final;
        public string Viva;
        public int quizTotal;
        public int Total;
        public double percentage;
        public string grade;

        public string getInfo()
        {
            return ID + "\t\t" + Name;
        }

        public void getGrade()
        {
            Array.Sort(quiz);
            quizTotal = Convert.ToInt32(quiz[1]) + Convert.ToInt32(quiz[2]) + Convert.ToInt32(quiz[3]);
            Total = Convert.ToInt32(quizTotal) + Convert.ToInt32(Final) + Convert.ToInt32(Mid) + Convert.ToInt32(Viva) + Convert.ToInt32(Attd);
            percentage = (Convert.ToDouble(Total) / 300.0) * 100.0;

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
        }
    }
}
