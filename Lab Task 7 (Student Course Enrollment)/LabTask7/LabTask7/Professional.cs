using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask7
{
    public class Professional: Participant
    {
        public string Org;

        public Professional (string Name, int Reg, string Contact, string Email, string Org) : base (Name, Reg, Contact, Email)
        {
            this.Org = Org;
        }

        public override double getFee()
        {
            double totalFee = 0;

            foreach (Course course in EnrolledCourses)
            {
                totalFee = totalFee + (course.Fee * 1.1);
            }

            return totalFee;
        }
    }
}
