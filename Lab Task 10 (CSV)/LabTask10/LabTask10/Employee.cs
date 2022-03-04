using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LabTask10
{
    public class Employee
    {
        public string ID;
        public string firstName;
        public string lastName;
        public string Hire_Date;
        public string Salary;

        public string getInfo()
        {
            return ID + "\t\t" + firstName + "\t\t" + lastName;
        }
    }
}
