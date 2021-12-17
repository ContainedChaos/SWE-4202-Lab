using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTask2
{
    public partial class Form1 : Form
    {
        List<User> users = new List<User>();
        List<Book> books = new List<Book>();

        private bool userExists (int id)
        {
            foreach (User user in users)
            {
                if (user.ID == id)
                    return true;
            }
            return false;
        }

        private bool bookExists (int id)
        {
            foreach (Book book in books)
            {
                if (book.ID == id)
                    return true;
            }
            return false;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void AddUserOnClick_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(UserIDBox.Text);
            string Name = UserNameBox.Text;
            string Address = UserAddressBox.Text;

            User dummy_user = new User(ID, Name, Address);
            
            users.Add(dummy_user);

            MessageBox.Show("User has been added successfully!");
        }

        private void AddBookOnClick_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(BookIDBox.Text);
            string Name = BookNameBox.Text;
            string Author = BookAuthorBox.Text;
            string Publisher = PublisherBox.Text;
            int Quantity = Convert.ToInt32(QuantityBox.Text);

            if (Quantity < 0)
            {
                MessageBox.Show("Quantity cannot be negative.");
                return;
            }

            Book dummy_book = new Book(ID, Name, Author, Publisher, Quantity);

            books.Add(dummy_book);
                     
            MessageBox.Show("Book has been added succesfully!");
        }

        private void ShowStudentOnClick_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(UserIDShowTextBox.Text);

            User dummy = new User();

            bool flag = false;
            foreach (User user in users)
            {
                if (user.ID == id)
                {
                    flag = true;
                    dummy = user;
                    break;
                }
            }

            if (flag == false)
            {
                MessageBox.Show("User could not be found!");
            }

            UserListBox.Items.Clear();

            for (int i = 0; i < dummy.books.Count; i++)
            {
                int id_book = dummy.books[i];
                
                for (int j = 0; j < books.Count; j++)
                {
                    if (books[j].ID == id_book)
                    {
                        UserListBox.Items.Add(books[j].history());
                    }
                }
            }
        }

        private void ShowBookOnClick_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(BookIDShowTextBox.Text);
            bool flag = false;

            foreach (Book book in books)
            {
                if (book.ID == id)
                {
                    flag = true;
                    BookIDLabel.Text = "ID:" + " " + book.ID.ToString();
                    BookNameLabel.Text = "Name:" + " " + book.Name;
                    BookAuthorLabel.Text = "Author:" + " " + book.Author;
                    PublisherLabel.Text = "Publisher:" + " " + book.Publisher;
                    QuantityLabel.Text = "Quantity:" + " " + book.Quantity;
                }
            }

            if (flag == false)
            {
                MessageBox.Show("Book could not be found.");
            }
        }

        private void BorrowBookOnClick_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(UserIDBorrowBox.Text);
            int bookID = Convert.ToInt32(BookIDBorrowBox.Text);

            if (bookExists(bookID) && userExists(userID))
            {
                foreach (Book book in books)
                {
                    if (book.ID == bookID)
                    {
                        if (book.Quantity < 1)
                        {
                            MessageBox.Show("Not enough items in stock.");
                            break;
                        }
                        book.Quantity -= 1;

                        foreach (User user in users)
                        {
                            if (user.ID == userID)
                            {
                                user.books.Add(bookID);
                                MessageBox.Show("Book has been added to the user.");
                            }
                        }
                        break;
                    }
                }
            }

            else
                MessageBox.Show("Invalid Input.");

        }
    }
}
