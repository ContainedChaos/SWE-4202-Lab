using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask8
{
    public class CurrentAccount: Account
    {
        public string AccType = "Current Account";
        public static string AccNo = "1234";
        public const string AccSuffix = "300";
        public double MinBal = 500;

        public CurrentAccount (string Name, string Address, string Contact, double IniAmount)
        {
            this.Name = Name;
            this.Address = Address;
            this.Contact = Contact;
            this.IniAmount = IniAmount;
            Balance = IniAmount;
            AccNo += 5;
            AccNoForUse = AccNo + AccSuffix; 
        }

        public List <Transaction> CA_trans = new List <Transaction>();
    }
}
