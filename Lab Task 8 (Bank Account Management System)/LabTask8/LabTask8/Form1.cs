using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTask8
{
    public partial class Form1 : Form
    {
        List <SavingsAccount> SA = new List <SavingsAccount> ();
        List <CurrentAccount> CA = new List <CurrentAccount> ();
        List <LoanAccount> LA = new List <LoanAccount> ();
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            string Name = UserNameBox.Text;
            string Address = UserAddressBox.Text;
            string Contact = UserContactBox.Text;
            double IniAmount = Convert.ToDouble(UserIniAmountBox.Text);
            string AccType = AccTypeCB.Text;

            if (AccType == "Current Account")
            {
                CurrentAccount dummy_CA = new CurrentAccount(Name, Address, Contact, IniAmount);
                CA.Add(dummy_CA);
                MessageBox.Show("Current Account has been created.");
                AccountNoLabel.Text = "Account No: " + dummy_CA.AccNoForUse;
            }

            if (AccType == "Savings Account")
            {
                if (IniAmount >= 50000)
                {
                    SavingsAccount dummy_SA = new SavingsAccount(Name, Address, Contact, IniAmount);
                    SA.Add(dummy_SA);
                    MessageBox.Show("Savings Account has been created.");
                    AccountNoLabel.Text = "Account No: " + dummy_SA.AccNoForUse;
                }

                else
                    MessageBox.Show("Deposit amount is less than required. Please try again.");
            }

            if (AccType == "Loan Account")
            {
                LoanAccount dummy_LA = new LoanAccount(Name, Address, Contact, IniAmount);
                LA.Add(dummy_LA);
                MessageBox.Show("Loan Account has been created.");
                AccountNoLabel.Text = "Account No: " + dummy_LA.AccNoForUse;
            }
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            string account = ActionAccNoBox.Text;
            double amount = Convert.ToDouble(ActionAmountBox.Text);

            try
            {
                if (amount < 0)
                {
                    throw new NegativeValueException();
                }
            }
            catch (NegativeValueException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
 

            foreach (SavingsAccount SA in SA)
            {
                if (SA.AccNoForUse == account)
                {
                    if (SA.NoOfTrans >= 5)
                    {
                        MessageBox.Show("You have reached transaction limit.");
                        return;
                    }

                    if ((SA.Balance - (amount + 15)) < 0)
                    {
                        MessageBox.Show("Insufficient balance. Please try again.");
                        return;
                    }

                    SA.Withdraw(amount);
                    SA.NoOfTrans++;
                    Transaction trans = new Transaction(SA.AccNoForUse, amount);
                    trans.Type = "Withdrawal";
                    SA.SA_trans.Add(trans);
                }
            }

            foreach (CurrentAccount CA in CA)
            {
                if (CA.AccNoForUse == account)
                {
                    if (amount > 100000 || ((CA.Balance - amount) < 500))
                    {
                        MessageBox.Show("Transaction unsuccessful due to limits. Please try again.");
                        return;
                    }

                    CA.Withdraw(amount);
                    Transaction trans = new Transaction(CA.AccNoForUse, amount);
                    trans.Type = "Withdrawal";
                    CA.CA_trans.Add(trans);
                }
            }

            foreach (LoanAccount LA in LA)
            {
                if (LA.AccNoForUse == account)
                {
                    MessageBox.Show("You cannot withdraw from a loan account.");
                    return;
                }
            }

            MessageBox.Show("Amount has been withdrawn successfully.");
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            string account = ActionAccNoBox.Text;
            double amount = Convert.ToDouble(ActionAmountBox.Text);

            try
            {
                if (amount < 0)
                    throw new NegativeValueException();
            
            }
            catch (NegativeValueException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


            foreach (SavingsAccount SA in SA)
            {
                if (SA.AccNoForUse == account)
                {
                    if (SA.NoOfTrans >= 5)
                    {
                        MessageBox.Show("You have reached maximum number of transactions.");
                        return;
                    }
                    
                    SA.Deposit(amount);
                    SA.NoOfTrans++;
                    Transaction trans = new Transaction(SA.AccNoForUse, amount);
                    trans.Type = "Deposit";
                    SA.SA_trans.Add(trans);
                }
            }

            foreach (CurrentAccount CA in CA)
            {
                if (CA.AccNoForUse == account)
                {
                    if (amount > 100000)
                    {
                        MessageBox.Show("Transaction unsuccessful due to limits. Please try again.");
                        return;
                    }

                    CA.Deposit(amount);
                    Transaction trans = new Transaction(CA.AccNoForUse, amount);
                    trans.Type = "Deposit";
                    CA.CA_trans.Add(trans);
                }
            }

            foreach (LoanAccount LA in LA)
            {
                if (LA.AccNoForUse == account)
                {
                    if ((LA.Loan - amount) < 0)
                    {
                         MessageBox.Show("Amount is more than remaining loan. Please try again.");
                         return;
                    }

                    if ((LA.Loan - amount) == 0)
                    {
                        MessageBox.Show("Loan has been paid.");
                        LA.Deposit(amount);

                        Transaction dummy_trans = new Transaction(LA.AccNoForUse, amount);
                        dummy_trans.Type = "Deposit";
                        LA.LA_trans.Add(dummy_trans);

                        return;
                    }

                    LA.Deposit(amount);
                    Transaction trans = new Transaction(LA.AccNoForUse, amount);
                    trans.Type = "Deposit";
                    LA.LA_trans.Add(trans);
                }
            }

            MessageBox.Show("Amount has been deposited successfully.");
        }

        private void ShowInfoButton_Click(object sender, EventArgs e)
        {
            string Account = InfoAccNoBox.Text;

            foreach (SavingsAccount SA in SA)
            {
                if (SA.AccNoForUse == Account)
                {
                    ShowNameLabel.Text = "Name: " + SA.Name;
                    ShowAddressLabel.Text = "Address: " + SA.Address;
                    ShowContactLabel.Text = "Contact: " + SA.Contact;
                    ShowBalanceLabel.Text = "Balance: " + SA.Balance.ToString();
                }
            }

            foreach (CurrentAccount CA in CA)
            {
                if (CA.AccNoForUse == Account)
                {
                    ShowNameLabel.Text = "Name: " + CA.Name;
                    ShowAddressLabel.Text = "Address: " + CA.Address;
                    ShowContactLabel.Text = "Contact: " + CA.Contact;
                    ShowBalanceLabel.Text = "Balance: " + CA.Balance.ToString();
                }
            }

            foreach (LoanAccount LA in LA)
            {
                if (LA.AccNoForUse == Account)
                {
                    ShowNameLabel.Text = "Name: " + LA.Name;
                    ShowAddressLabel.Text = "Address: " + LA.Address;
                    ShowContactLabel.Text = "Contact: " + LA.Contact;
                    ShowBalanceLabel.Text = "Loan: " + LA.Loan.ToString();
                }
            }
        }

        private void ShowHistoryButton_Click(object sender, EventArgs e)
        {
            string Acc = HistoryAccNoBox.Text;
            AccountHistoryBox.Items.Clear();
            AccountHistoryBox.Items.Add("Type\t\t" + "Amount");

            foreach (SavingsAccount SA in SA)
            {
                if (Acc == SA.AccNoForUse)
                {
                    foreach (Transaction trans in SA.SA_trans)
                    {
                        AccountHistoryBox.Items.Add(trans.getInfo());
                    }
                }
            }

            foreach (CurrentAccount CA in CA)
            {
                if (Acc == CA.AccNoForUse)
                {
                    foreach (Transaction trans in CA.CA_trans)
                    {
                        AccountHistoryBox.Items.Add(trans.getInfo());
                    }
                }
            }

            foreach (LoanAccount LA in LA)
            {
                if (Acc == LA.AccNoForUse)
                {
                    foreach (Transaction trans in LA.LA_trans)
                    {
                        AccountHistoryBox.Items.Add(trans.getInfo());
                    }
                }
            }

        }
    }
}
