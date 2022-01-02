using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask6
{
    public class Order
    {
        public static int OrderID = 0;
        public int OrderIDforUse;
        public int shirtQuant;
        public int pantQuant;
        public int suitQuant;
        public int sheetQuant;
        public string Status;
        public int Amount;
        public int UserID;
        public string shirtCond, pantCond, suitCond, sheetCond;

        public Order (int shirtQuant, int pantQuant, int suitQuant, int sheetQuant, int UserID, int Amount)
        {
            OrderID += 1;
            this.OrderIDforUse = OrderID;
            this.shirtQuant = shirtQuant;
            this.pantQuant = pantQuant;
            this.suitQuant = suitQuant;
            this.sheetQuant = sheetQuant;
            this.UserID = UserID;
            this.Amount = Amount;
        }

        public string getOrderInfo()
        {
            string OrderInfo = "Type\tQuantity\tTo_Do\n....................................................................................................................\nShirt\t" + shirtQuant + "\t" + shirtCond + "\nPant\t" + pantQuant + "\t" + pantCond + "\nSuit\t" + suitQuant + "\t" + suitCond + "\nSheet\t" + sheetQuant + "\t" + sheetCond + "\nAmount: " + Amount;
            return OrderInfo;
        }
    }


}
