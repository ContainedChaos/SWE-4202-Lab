using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask8
{
    public class Account
    {
        public string Name;
        public string Address;
        public string Contact;
        public double IniAmount;
        public double Balance = 0;
        public string AccNoForUse;

        public virtual void Withdraw(double Amount)
        {
            Balance -= Amount;
        }

        public virtual void Deposit (double Amount)
        {
            Balance += Amount;
        }
    }
}
