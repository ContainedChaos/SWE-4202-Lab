using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask8
{
    public class LoanAccount: Account
    {
        public static string AccNo = "3456";
        public const string AccSuffix = "400";
        public double Loan;

        public LoanAccount (string Name, string Address, string Contact, double IniAmount)
        {
            this.Name = Name;
            this.Address = Address;
            this.Contact = Contact;
            this.IniAmount = IniAmount;
            Loan = IniAmount + (9 / 100) * IniAmount;
            AccNo += 5;
            AccNoForUse = AccNo + AccSuffix;
        }

        public override void Deposit (double Amount)
        {
            Loan -= Amount;
        }

        public List<Transaction> LA_trans = new List<Transaction>();
    }
}
