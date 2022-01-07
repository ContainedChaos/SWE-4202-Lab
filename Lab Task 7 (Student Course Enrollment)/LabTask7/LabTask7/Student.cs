using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask7
{
    public class Student: Participant
    {
        public string School;

        public Student (string Name, int Reg, string Contact, string Email, string School) : base (Name, Reg, Contact, Email)
        {
            this.School = School;
        }
    }
}
