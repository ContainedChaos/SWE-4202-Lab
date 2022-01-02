using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTask6
{
    public partial class Form1 : Form
    {
        LMS lms = new LMS();
  
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            int userid = Convert.ToInt32(UserIDBox.Text);
            string name = UserNameBox.Text;
            string address = UserAddressBox.Text;

            User dummy_user = new User(userid, name, address);
            lms.users.Add(dummy_user);

            MessageBox.Show("User account has been created successfully.");

        }

        private void PlaceOrderButton_Click(object sender, EventArgs e)  //both the quantities and to-dos have to be specified for this button to work (specify quantity = 0 if so)
        {
            int userid = Convert.ToInt32(UserIDPOBox.Text);
            int shirtQuant = Convert.ToInt32(ShirtQuantBox.Text);
            int pantQuant = Convert.ToInt32(PantQuantBox.Text);
            int suitQuant = Convert.ToInt32(SuitQuantBox.Text);
            int sheetQuant = Convert.ToInt32(SheetQuantBox.Text);


            int price = 0;

            if (ShirtOrderComboBox.Text == "Wash")
            {
                price += shirtQuant * 5;
            }

            if (ShirtOrderComboBox.Text == "Iron")
            {
                price += shirtQuant * 10;
            }

            if (ShirtOrderComboBox.Text == "Both")
            {
                price += shirtQuant * 15;
            }

            if (PantOrderComboBox.Text == "Wash")
            {
                price += pantQuant * 5;
            }

            if (PantOrderComboBox.Text == "Iron")
            {
                price += pantQuant * 10;
            }

            if (PantOrderComboBox.Text == "Both")
            {
                price += pantQuant * 15;
            }

            if (SuitsOrderComboBox.Text == "Wash")
            {
                price += suitQuant * 5;
            }

            if (SuitsOrderComboBox.Text == "Iron")
            {
                price += suitQuant * 10;
            }

            if (SuitsOrderComboBox.Text == "Both")
            {
                price += suitQuant * 15;
            }

            if (SheetOrderComboBox.Text == "Wash")
            {
                price += sheetQuant * 5;
            }

            if (SheetOrderComboBox.Text == "Iron")
            {
                price += sheetQuant * 10;
            }

            if (SheetOrderComboBox.Text == "Both")
            {
                price += sheetQuant * 15;
            }



            Order order = new Order(shirtQuant, pantQuant, suitQuant, sheetQuant, userid, price);
            order.shirtCond = ShirtOrderComboBox.Text;
            order.pantCond = PantOrderComboBox.Text;
            order.suitCond = SuitsOrderComboBox.Text;
            order.sheetCond = SheetOrderComboBox.Text;

            lms.orders.Add(order);

            MessageBox.Show("Order has been placed successfully. Order ID: " + Order.OrderID + ". Amount: " + order.Amount);
        }

        private void SetStatusButton_Click(object sender, EventArgs e)
        {
            int orderid = Convert.ToInt32(OrderIDSSBox.Text);

            foreach (Order order in lms.orders)
            {
                if (order.OrderIDforUse == orderid)
                {
                    order.Status = OrderStatusComboBox.Text;

                    if (OrderStatusComboBox.Text == "Delivered")
                    {
                        Balance balance = new Balance(order.Amount);
                    }
                }
            }

            MessageBox.Show("Status has been set.");

            CurrBalanceLabel.Text = "Current Balance: " + Balance.balance;
        }

        private void ShowDetailsButton_Click(object sender, EventArgs e)
        {
            int orderid = Convert.ToInt32(OrderIDSeeDeetsBox.Text);

            foreach (Order order in lms.orders)
            {
                if (order.OrderIDforUse == orderid)
                {
                    ShowStatusLabel.Text = "Status: " + order.Status;
                    ShowAmountLabel.Text = "Amount: " + order.Amount.ToString();
                    ShirtQuantityLabel.Text = order.shirtQuant.ToString();
                    PantQuantityLabel.Text = order.pantQuant.ToString();
                    SuitQuantityLabel.Text = order.suitQuant.ToString();
                    SheetQuantityLabel.Text = order.sheetQuant.ToString();
                    ShirtCondLabel.Text = order.shirtCond.ToString();
                    PantCondLabel.Text= order.pantCond.ToString();
                    SuitCondLabel.Text = order.suitCond.ToString();
                    SheetCondLabel.Text = order.sheetCond.ToString();

                    foreach (User user in lms.users)
                    {
                        if (user.ID == order.UserID)
                        {
                            ShowNameLabel.Text = "Name: " + user.Name;
                            ShowAddressLabel.Text = "Address: " + user.Address;
                        }
                    }

                    //OrderDetailsBox.Items.Clear();
                    //for (int i = 0; i < lms.orders.Count; i++)
                    //{
                    //    OrderDetailsBox.Items.Add(lms.orders[i].getOrderInfo());
                    //}
                }
            }
        }
    }
}
