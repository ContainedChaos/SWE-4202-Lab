using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pharmacy_Dependencies;

namespace Lab_Task_5__Pharmacy_Management_System_
{
    public partial class MfgDateBox : Form
    {
        List<Medicine> medicines = new List<Medicine>();
        public MfgDateBox()
        {
            InitializeComponent();
        }

        Sales sale = new Sales();

        private void AddMedBox_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(MedIDBox.Text);
            string Name = MedNameBox.Text;
            string Symptom = SymptomBox.Text;
            int Price = Convert.ToInt32(MedPriceBox.Text);
            string ExpDate = ExpDateBox.Text;
            int Quantity = Convert.ToInt32(MedQuantityBox.Text);

            Medicine dummy_medicine = new Medicine(ID, Name, Symptom, Price, ExpDate, Quantity);
            medicines.Add(dummy_medicine);

            MessageBox.Show("Medicine has been added successfully!");


        }

        private void SellMedOnClick_Click(object sender, EventArgs e)
        {
            int sellmedID = Convert.ToInt32(SellMedIDBox.Text);
            int sellquant = Convert.ToInt32(SellMedQuantityBox.Text);

            foreach (Medicine medicine in medicines)
            {
                if (medicine.ID == sellmedID)
                {
                    if (medicine.Quantity < sellquant)
                    {
                        MessageBox.Show("Quantity is less than required.");
                        return;
                    }

                    medicine.Quantity = medicine.Quantity - sellquant;

                    MessageBox.Show("Medicine has been sold.");
                    
                    sale.Balance = sale.Balance + (medicine.Price * sellquant);
                }
            }
        }

        private void ShowStockOnClick_Click(object sender, EventArgs e)
        {
            int showstockid = Convert.ToInt32(ShowStockMedIDBox.Text);

            foreach (Medicine medicine in medicines)
            {
                if (medicine.ID == showstockid)
                {
                    StockCheckLabel.Text = "Quantity: " + medicine.Quantity.ToString();
                }
            }

           

        }

        private void AccountCheckOnClick_Click(object sender, EventArgs e)
        {
            int iniBal = Convert.ToInt32(InitialBalanceBox.Text);

            ShowBalanceLabel.Text = "Balance: " + (iniBal + sale.Balance); 
 


        }

    }
}
