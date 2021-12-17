using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask1
{
    internal class Student
    {
        public string Name;
        public string ID;
        public string dept;
        public string semester;

        public string getInfo()
        {
            string studentInfo = ID + "\t" + Name + "\t" + dept + "\t" + semester;
            return studentInfo;
        }
    }
}
