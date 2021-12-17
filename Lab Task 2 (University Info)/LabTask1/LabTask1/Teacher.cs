using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask1
{
    internal class Teacher
    {
        public string Name;
        public string ID;
        public string dept;
        public string design;
        public string salary;

        public string getInfo2()
        {
            string TeacherInfo = ID + "\t" + Name + "\t" + dept + "\t" + design + "\t" + salary;
            return TeacherInfo;
        }
    }
}
