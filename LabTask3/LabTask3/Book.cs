using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask2
{
    internal class Book
    {
        public int ID;
        public string Name;
        public string Author;
        public string Publisher;
        public int Quantity;

        public Book (int ID, string Name, string Author, string Publisher, int Quantity)
        {
            this.ID = ID;
            this.Name = Name;
            this.Author = Author;
            this.Publisher = Publisher;
            this.Quantity = Quantity;
        }
        public string history()
        {
            string bookInfo = ID + "\t" + Name;
            return bookInfo;
        }

       
    }
}
