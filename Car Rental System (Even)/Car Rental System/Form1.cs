using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_System
{
    public partial class Form1 : Form
    {
        List <User> users = new List <User> (); 
        List <Car> cars = new List <Car> ();   

        public Form1()
        {
            InitializeComponent();
        }

        private void SaveUserInfo_Click(object sender, EventArgs e)
        {
            User dummy_user = new User ();

            dummy_user.setID (Convert.ToInt32(UserIDBox.Text));
            dummy_user.setName (UserNameBox.Text);
            dummy_user.setAddress (UserAddressBox.Text);
            dummy_user.setDestination (UserDestiBox.Text);

            users.Add (dummy_user);

            MessageBox.Show ("User has been added successfully!");
            
        }

        private void SaveCarInfo_Click(object sender, EventArgs e)
        {
            Car dummy_car = new Car ();

            dummy_car.setName (CarNameBox.Text);
            dummy_car.setModel (CarModelBox.Text);
            dummy_car.setQuantity (Convert.ToInt32(CarQuantiBox.Text));

            cars.Add (dummy_car);

            MessageBox.Show ("Car has been added successfully!");
        }

        private void RentCar_Click(object sender, EventArgs e)
        {
            int userid = Convert.ToInt32(RentUserIDBox.Text);
            string carname = RentCarNameBox.Text;

            foreach (Car car in cars)
            {
                if (carname == car.getName())
                {
                    if (car.getQuantity() == 0)
                    {
                        MessageBox.Show("Car out of stock.");
                        break;
                    }

                    else
                    {
                        car.setQuantity(car.getQuantity() - 1);

                        foreach (User user in users)
                        {
                            if (userid == user.getID())
                            {
                                user.rentedCar.Add(car);

                                MessageBox.Show("Car rented out successfully.");
                            }
                        }
                        break;
                    }

                }
            }


        }

        private void ShowUserHistory_Click(object sender, EventArgs e)
        {

            
        }

        private void ShowCarHistory_Click(object sender, EventArgs e)
        {

        }

        private void ShowUserHistory_Click_1(object sender, EventArgs e)
        {
            int userid = Convert.ToInt32(UserHistoryIDBox.Text);

            foreach (User user in users)
            {
                if (userid == user.getID())
                {
                    ShowUserName.Text = "Name: " + user.getName();
                    ShowUserAddress.Text = "Address: " + user.getAddress();
                    ShowUserDestination.Text = "Destination: " + user.getDestination();

                    foreach (Car car in user.rentedCar)
                    {
                        ShowRentedCar.Text = "Rented Car: " + car.getName();
                    }
                    
                    break;
                }
            }
        }

        private void ShowCarHistory_Click_1(object sender, EventArgs e)
        {
            string carname = CarHistoryNameBox.Text;

            foreach (Car car in cars)
            {
                if (carname == car.getName())
                {
                    ShowCarModel.Text = "Model: " + car.getName();
                    ShowCarQuantity.Text = "Quantity: " + car.getQuantity();
                    break;
                }
            }
        }
    }
}
