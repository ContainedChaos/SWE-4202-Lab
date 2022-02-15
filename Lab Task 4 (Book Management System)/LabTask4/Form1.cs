using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTask4
{
    public partial class Form1 : Form
    {
        List<StudyBook> studyBooks = new List<StudyBook>();
        List<ResearchArticle> articles = new List<ResearchArticle>();

        public Form1()
        {
            InitializeComponent();
        }

        private void AddStudyBookOnClick_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(StudyBookIDBox.Text);
            string Title = StudyBookTitleBox.Text;
            string Author = StudyBookAuthorBox.Text;
            string Publisher = StudyBookPubBox.Text;
            int Quantity = Convert.ToInt32(StudyBookQuantityBox.Text);
            string ISBN = ISBNBox.Text;
            string Genre = GenreBox.Text;

            StudyBook dummy_book = new StudyBook(ID, Title, Author, Publisher, Quantity, ISBN, Genre);
            studyBooks.Add(dummy_book);

            MessageBox.Show("Study Book has been added successfully!");
        }

        private void AddArticleOnClick_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(ArticleIDBox.Text);
            string Title = ArticleTitleBox.Text;
            string Author = ArticleAuthorBox.Text;
            string Publisher = ArticlePubBox.Text;
            int Quantity = Convert.ToInt32(ArticleQuantityBox.Text);
            string DOI = DOIBox.Text;
            string PublishDate = PubDateBox.Text;
            string Journal = TypeBox.Text;

            ResearchArticle dummy_book = new ResearchArticle(ID, Title, Author, Publisher, Quantity, DOI, PublishDate, Journal);
            articles.Add(dummy_book);

            MessageBox.Show("Research Article has been added successfully!");
        }

        private void ShowStudyBooksOnClick_Click(object sender, EventArgs e)
        {
            StudyBookList.Items.Clear();
            for (int i = 0; i < studyBooks.Count; i++)
            {
                StudyBookList.Items.Add(studyBooks[i].getInfo());
            }
        }

        private void ShowArticlesOnClick_Click(object sender, EventArgs e)
        {
            ResearchArticleList.Items.Clear();
            for (int i = 0; i < articles.Count; i++)
            {
                ResearchArticleList.Items.Add(articles[i].getInfo());
            }
        }

        private void BorrowStudyBookOnClick_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(StudyBookBorrowBox.Text);
            
                foreach (StudyBook studyBook in studyBooks)
                {
                    if (ID == studyBook.ID)
                    {
                        studyBook.Quantity -= 1;
                    }
                }
        }

        private void BorrowArticleOnClick_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(ArticleBorrowBox.Text);

            foreach (ResearchArticle article in articles)
            {
                if (ID == article.ID)
                {
                    article.Quantity -= 1;
                }
            }
        }
    }
}
