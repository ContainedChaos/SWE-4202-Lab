using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask4
{
    internal class ResearchArticle: Book
    {
        public string DOI;
        public string PublishDate;
        public string Journal;

        public ResearchArticle(int ID, string Title, string Author, string Publisher, int Quantity, string DOI, string PublishDate, string Journal)
        {
            this.ID = ID;
            this.Title = Title;
            this.Author = Author;
            this.Publisher = Publisher;
            this.Quantity = Quantity;
            this.DOI = DOI;
            this.PublishDate = PublishDate;
            this.Journal = Journal;
        }

        public string getInfo()
        {
            string ArticleInfo = ID + "\t" + Title + "\t" + Author + "\t" + DOI + "\t" + Quantity + "\t" + Journal;
            return ArticleInfo;
        }
    }
}
