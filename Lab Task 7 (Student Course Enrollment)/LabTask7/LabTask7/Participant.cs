using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask7
{
    public class Participant
    {
        public string Name;
        public int Reg;
        public string Contact;
        public string Email;
        public string Level;

        public List <Course> EnrolledCourses = new List <Course> ();

        public Participant(string Name, int Reg, string Contact, string Email)
        {
            this.Name = Name;
            this.Reg = Reg;
            this.Contact = Contact;
            this.Email = Email;
        }

        public Participant()
        {

        }

        public virtual double getFee ()
        {
            double totalFee = 0;

            foreach (Course course in EnrolledCourses)
            {
                totalFee = totalFee + course.Fee;
            }

            return totalFee;
        }

    }
}
