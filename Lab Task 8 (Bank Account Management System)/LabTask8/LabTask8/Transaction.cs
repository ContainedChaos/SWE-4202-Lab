using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask8
{
    public class Transaction
    {
        public string AccNo;
        public string Type;
        public double Amount;

        public Transaction(string AccNo, double Amount)
        {
            this.AccNo = AccNo;
            this.Amount = Amount;
        }

        public string getInfo()
        {
            return Type + "\t" + Amount;
        }
    }
}
