using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class Form1 : Form
    {
        HMS hms = new HMS();

        public Form1()
        {
            InitializeComponent();
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(UserIDBox.Text);
            string Name = UserNameBox.Text;
            string Address = UserAddressBox.Text;
            string Contact = UserContactBox.Text;

            User dummy_user = new User(id, Name, Address, Contact);

            hms.users.Add(dummy_user);

            MessageBox.Show("Account has been created successfully!");
        }

        private void PlaceRequestButton_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(UserIDPOBox.Text);
            string roomType = RoomTypeCB.Text;
            //int duration = dateTimePicker2.Value - dateTimePicker1.Value;
            int duration = Convert.ToInt32(DurationBox.Text);
            int amount = 0;

            if (roomType == "Single")
            {
                amount = 2000 * duration;
            }

            if (roomType == "Double")
            {
                amount = 4000 * duration;
            }

            if (roomType == "Deluxe")
            {
                amount = 6000 * duration;
            }

            if (roomType == "Suite")
            {
                amount = 8000 * duration;
            }

            Booking dummy_booking = new Booking(userID, amount, roomType);

            hms.bookings.Add(dummy_booking);

            MessageBox.Show("Room has been requested. Booking ID: " + Booking.bookID + ". Amount: " + dummy_booking.Amount);
        }

        private void SetStatusButton_Click(object sender, EventArgs e)
        {
            int bookid = Convert.ToInt32(BookIDSSBox.Text);
            string roomno = RoomNumberBox.Text;
            string status = OrderStatusCB.Text;

            foreach (Booking booking in hms.bookings)
            {
                if (bookid == booking.bookIDforuse)
                {
                    booking.Status = status;
                    booking.RoomNo = roomno;
                    hms.balance += booking.Amount;
                }
            }

            MessageBox.Show("Status has been set.");
        }

        private void ShowBalanceButton_Click(object sender, EventArgs e)
        {
            CurrBalanceLabel.Text = "Current Balance: " + hms.balance;
        }

        private void ShowDetailsButton_Click(object sender, EventArgs e)
        {
            RoomDetailsBox.Items.Clear();
            RoomDetailsBox.Items.Add("Type" + "\t" + "\t" + "Room No." + "\t" + "Amount");
            RoomDetailsBox.Items.Add("----------------------------------------------------------------------------");
            int orderid = Convert.ToInt32(OrderIDSeeDeetsBox.Text);

            foreach (Booking booking in hms.bookings)
            {
                if (orderid == booking.bookIDforuse)
                {
                    RoomDetailsBox.Items.Add(booking.getInfo());
                    ShowStatusLabel.Text = "Status: " + booking.Status;

                    foreach (User user in hms.users)
                    {
                        if (booking.userID == user.getID())
                        {
                            ShowNameLabel.Text = "Name: " + user.getName();
                        }
                    }
                }
            }
        }
    }
}
