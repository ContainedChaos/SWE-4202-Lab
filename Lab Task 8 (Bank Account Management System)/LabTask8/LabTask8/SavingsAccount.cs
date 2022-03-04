using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask8
{
    public class SavingsAccount: Account
    {
        public string AccType = "Savings Account";
        public static string AccNo = "2345";
        public const string AccSuffix = "314";
        public double WithDrawCharge = 15;
        public int NoOfTrans;

        public SavingsAccount (string Name, string Address, string Contact, double IniAmount)
        {
            this.Name = Name;
            this.Address = Address;
            this.Contact = Contact;
            this.IniAmount = IniAmount;
            Balance = IniAmount;
            AccNo += 5;
            AccNoForUse = AccNo + AccSuffix;
        }

        public override void Withdraw(double Amount)
        {
            Balance -= (Amount + 15);
        }

        public List <Transaction> SA_trans = new List <Transaction>();

    }
}
