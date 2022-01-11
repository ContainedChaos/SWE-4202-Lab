using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public class Booking
    {
        public static int bookID = 0;
        public int bookIDforuse;
        public int userID;
        public string Status = "Pending";
        public int Amount;
        public string roomType;
        public string RoomNo;

        public Booking (int userID, int Amount, string roomType)
        {
            this.userID = userID;
            this.Amount = Amount;
            this.roomType = roomType;
            bookID += 1;
            bookIDforuse = bookID;
        }

        public string getInfo()
        {
            string info = roomType + "\t" + "\t" + RoomNo + "\t" + "\t" + Amount;
            return info;
        }

    }
}
