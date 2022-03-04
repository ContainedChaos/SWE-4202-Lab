using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask8
{
    internal class NegativeValueException: ApplicationException
    {
        public override string Message
        {
            get
            {
                return "Amount cannot be negative. Transaction aborted. Please try again.";
            }
        }
    }
}
