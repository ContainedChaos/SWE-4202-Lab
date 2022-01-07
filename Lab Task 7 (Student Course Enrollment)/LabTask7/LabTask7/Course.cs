using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask7
{
    public class Course
    {
        public string Title;
        public string Level;
        public int Fee;
        public string Date;

        public Course(string Title, int Fee)
        {
            this.Title = Title;
            this.Fee = Fee;
        }

    }
}
