using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask4
{
    internal class StudyBook: Book
    {
        public string ISBN;
        public string Genre;
        public StudyBook (int ID, string Title, string Author, string Publisher, int Quantity, string ISBN, string Genre)
        {
            this.ID = ID;
            this.Title = Title;
            this.Author = Author;
            this.Publisher = Publisher;
            this.Quantity = Quantity;
            this.ISBN = ISBN;
            this.Genre = Genre;
        }

        public string getInfo()
        {
            string StudyBookInfo = ID + "\t" + Title + "\t" + Author + "\t" + ISBN + "\t" + Quantity;
            return StudyBookInfo;
        }

        //public void BorrowStudyBook(int ID)
        //{
        //    foreach (StudyBook studyBook in studyBooks)
        //    {
        //        if (ID == this.ID)
        //        {
        //            this.Quantity = Quantity - 1;
        //        }
        //    }
        //}

    }
}
