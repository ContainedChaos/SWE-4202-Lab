using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_9__Accounts_
{
    public class Account
    {
        string accountNo;
        string accountName;
        public double balance;

        public string AccountNo
        {
            get { return accountNo; }
            set { accountNo = value; }
        }
        public string AccountName
        {
            get { return accountName; }
            set { accountName = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
    }

    public class CurrentAccount : Account
    {
        const int serviceCharge = 100;
        const string accountPrefix = "100";
        static int accNo = 1234;

        public string getNextAccount()
        {
            accNo += 5;
            return accountPrefix + accNo;
        }

        public double Balance (double balance)
        {
            return balance - serviceCharge;
        }

        public string Deets ()
        {
            return "----------------------Current Account Details---------------------------";
        }
    }

    public class SavingsAccount : Account
    {
        double interestRate;
        double monthlyDepositAmount;
        const string accountPrefix = "200";
        static int accNo = 2345;

        public double InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }

        public double MonthlyDepositAmount
        {
            get { return monthlyDepositAmount; }
            set { monthlyDepositAmount = value; }
        }

        public string getNextAccount()
        {
            accNo += 5;
            return accountPrefix + accNo;
        }

        public double Balance()
        {
            return (monthlyDepositAmount + (monthlyDepositAmount * (interestRate / 100)));
        }

        public string Deets()
        {
            return "-------------------------Savings Account Details-------------------------";
        }
    }

    public class LoanAccount : Account
    {
        double interestRate;
        double amount;
        const string accountPrefix = "900";
        static int accNo = 3456;

        public double InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }

        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public string getNextAccount()
        {
            accNo += 5;
            return accountPrefix + accNo;
        }

        public double Balance (double amount)
        {
            return balance - ((interestRate / 100) * amount);
        }

        public string Deets()
        {
            return "-------------------------Loan Account Details-------------------------";
        }
    }

    public class MonthlyDepositScheme : Account
    {
        double interestRate;
        double monthlyDepositAmount;
        const string accountPrefix = "300";
        static int accNo = 4567;

        public double InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }

        public double MonthlyDepositAmount
        {
            get { return monthlyDepositAmount; }
            set { monthlyDepositAmount = value; }
        }

        public string getNextAccount()
        {
            accNo += 5;
            return accountPrefix + accNo;
        }

        public double Balance()
        {
            return (monthlyDepositAmount + (monthlyDepositAmount * (interestRate / 100)));
        }

        public string Deets()
        {
            return "-------------------------MDS Account Details-------------------------";
        }
    }

    public class TwoYearMDS : MonthlyDepositScheme
    {
        double maximuminterest;

        public double MaximumInterest
        {
            get { return maximuminterest; }
            set { maximuminterest = value; }
        }

        public string Deets()
        {
            return "-------------------------Two year MDS Account Details-------------------------";
        }
    }

    public class FiveYearMDS : MonthlyDepositScheme
    {
        double maximuminterest;

        public double MaximumInterest
        {
            get { return maximuminterest; }
            set { maximuminterest = value; }
        }

        public string Deets()
        {
            return "-------------------------Five year MDS Account Details-------------------------";
        }
    }

    public class InitialDepositMDS : MonthlyDepositScheme
    {
        double maximuminterest;
        double initialDepositAmount;

        public double MaximumInterest
        {
            get { return maximuminterest; }
            set { maximuminterest = value; }
        }

        public double InitialDepositAmount
        {
            get { return initialDepositAmount; }
            set { initialDepositAmount = value; }
        }

        public double Balance(double interestRate, double initialDepositAmount)
        {
            return (initialDepositAmount + (initialDepositAmount * (interestRate / 100)));
        }

        public string Deets()
        {
            return "-------------------------Initial Deposit MDS Account Details-------------------------";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Current Account

            Console.WriteLine("Enter Current Account name and balance: ");
            string c_name = Console.ReadLine();
            double c_bal = Convert.ToDouble(Console.ReadLine());

            CurrentAccount c_acc = new CurrentAccount();
            c_acc.AccountName = c_name;
            c_acc.balance = c_bal;

            Console.WriteLine(c_acc.Deets());
            Console.WriteLine("Name: " + c_acc.AccountName);
            Console.WriteLine("Balance: " + c_acc.Balance(c_bal));
            Console.WriteLine("Account No: " + c_acc.getNextAccount());

            //Savings Account

            Console.WriteLine("\nEnter Savings Account name, interest rate and monthly deposit amount: ");
            string s_name = Console.ReadLine();
            double s_int = Convert.ToDouble(Console.ReadLine());
            double s_dep = Convert.ToDouble(Console.ReadLine());

            SavingsAccount s_acc = new SavingsAccount();
            s_acc.AccountName = s_name;
            s_acc.InterestRate = s_int;
            s_acc.MonthlyDepositAmount = s_dep;

            Console.WriteLine(s_acc.Deets());
            Console.WriteLine("Name: " + s_acc.AccountName);
            Console.WriteLine("Balance: " + s_acc.Balance());
            Console.WriteLine("Account No: " + s_acc.getNextAccount());

            //Loan Account

            Console.WriteLine("\nEnter Loan Account name, loan amount, interest rate and deposit amount : ");
            string l_name = Console.ReadLine();
            double l_bal = Convert.ToDouble(Console.ReadLine());
            double l_int = Convert.ToDouble(Console.ReadLine());
            double l_amount = Convert.ToDouble(Console.ReadLine());

            LoanAccount l_acc = new LoanAccount();
            l_acc.AccountName = l_name;
            l_acc.balance = l_bal;
            l_acc.InterestRate = l_int;
            l_acc.Amount = l_amount;

            Console.WriteLine(l_acc.Deets());
            Console.WriteLine("Name: " + l_acc.AccountName);
            Console.WriteLine("Remaining loan: " + l_acc.Balance(l_amount));
            Console.WriteLine("Account No: " + l_acc.getNextAccount());

            //2 Year MDS

            Console.WriteLine("\nEnter 2 Year MDS account name, interest rate, monthly deposit amount and maximum interest: ");
            string ty_name = Console.ReadLine();
            double ty_int = Convert.ToDouble(Console.ReadLine());
            double ty_dep = Convert.ToDouble(Console.ReadLine());
            double ty_maxint = Convert.ToDouble(Console.ReadLine());

            TwoYearMDS ty_mds = new TwoYearMDS();
            ty_mds.AccountName = ty_name;
            ty_mds.InterestRate = ty_int;
            ty_mds.MonthlyDepositAmount = ty_dep;
            ty_mds.MaximumInterest = ty_maxint;

            Console.WriteLine(ty_mds.Deets());
            Console.WriteLine("Name: " + ty_mds.AccountName);

            if (ty_mds.Balance() > (ty_mds.MonthlyDepositAmount + ty_mds.MaximumInterest))
            {
                ty_mds.balance = ty_mds.MonthlyDepositAmount + ty_mds.MaximumInterest;
                Console.WriteLine("Balance: " + ty_mds.balance);
            }

            else
            {
                Console.WriteLine("Balance: " + ty_mds.Balance());
            }

            Console.WriteLine("Account No: " + ty_mds.getNextAccount());

            //5 Year MDS

            Console.WriteLine("\nEnter 5 Year MDS account name, interest rate, monthly deposit amount and maximum interest: ");
            string fy_name = Console.ReadLine();
            double fy_int = Convert.ToDouble(Console.ReadLine());
            double fy_dep = Convert.ToDouble(Console.ReadLine());
            double fy_maxint = Convert.ToDouble(Console.ReadLine());

            FiveYearMDS fy_mds = new FiveYearMDS();
            fy_mds.AccountName = fy_name;
            fy_mds.InterestRate = fy_int;
            fy_mds.MonthlyDepositAmount = fy_dep;
            fy_mds.MaximumInterest = fy_maxint;

            Console.WriteLine(fy_mds.Deets());
            Console.WriteLine("Name: " + fy_mds.AccountName);

            if (fy_mds.Balance() > (fy_mds.MonthlyDepositAmount + fy_mds.MaximumInterest))
            {
                fy_mds.balance = fy_mds.MonthlyDepositAmount + fy_mds.MaximumInterest;
                Console.WriteLine("Balance: " + fy_mds.balance);
            }

            else
            {
                Console.WriteLine("Balance: " + fy_mds.Balance());
            }

            Console.WriteLine("Account No: " + fy_mds.getNextAccount());

            //Initial Deposit MDS

            Console.WriteLine("Enter Initial Deposit MDS account name, interest rate, initial deposit and maximum interest: ");
            string id_name = Console.ReadLine();
            double id_int = Convert.ToDouble(Console.ReadLine());
            double id_dep = Convert.ToDouble(Console.ReadLine());
            double id_maxint = Convert.ToDouble(Console.ReadLine());

            InitialDepositMDS id_mds = new InitialDepositMDS();
            id_mds.AccountName = id_name;
            id_mds.InterestRate = id_int;
            id_mds.InitialDepositAmount = id_dep;
            id_mds.MonthlyDepositAmount = id_maxint;

            Console.WriteLine(id_mds.Deets());
            Console.WriteLine("Name: " + id_mds.AccountName);

            if (id_mds.Balance() > (id_mds.MonthlyDepositAmount + id_mds.MaximumInterest))
            {
                id_mds.balance = id_mds.MonthlyDepositAmount + id_mds.MaximumInterest;
                Console.WriteLine("Balance: " + id_mds.balance);
            }

            else
            {
                Console.WriteLine("Balance: " + id_mds.Balance());
            }

            Console.WriteLine("Account No: " + id_mds.getNextAccount());

            Console.ReadKey();
        }
    }
}
