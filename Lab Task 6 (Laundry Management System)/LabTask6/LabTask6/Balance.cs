using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask6
{
    public class Balance
    {
        public static int balance = 0;

        public Balance (int price)
        {
            balance += price;
        }
    }
}
