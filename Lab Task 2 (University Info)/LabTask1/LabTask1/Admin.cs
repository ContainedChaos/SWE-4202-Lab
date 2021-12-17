using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask1
{
    internal class Admin
    {
        public string Name;
        public string ID;
        public string design;
        public string salary;

        public string getInfo()
        {
            string AdminInfo = ID + "\t" + Name + "\t" + design + "\t" + salary;
            return AdminInfo;
        }
    }
}
