using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LabTask10
{

    public partial class Form1 : Form
    {
        public List<Employee> Employees = new List<Employee>();
        public Form1()
        {
            InitializeComponent();

            using (var reader = new StreamReader(@"D:\SOFTWARE\employees.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    Employee emp = new Employee();
                    emp.ID = values[0];
                    emp.firstName = values[1];
                    emp.lastName = values[2];
                    emp.Hire_Date = values[5];
                    emp.Salary = values[7];

                    Employees.Add(emp);

                    EmployeeListBox.Items.Add(emp.getInfo());
                }
            }
        }



        private void SearchButton_Click(object sender, EventArgs e)
        {
            string id = SearchIDBox.Text;
            bool flag = false;
            string time = DateTime.Now.ToString();

            foreach (Employee emp in Employees)
            {
                if (emp.ID == id)
                {
                    flag = true;

                    NameLabel.Text = "Name: " + emp.firstName + " " + emp.lastName;
                    IDLabel.Text = "ID: " + emp.ID;
                    HireDateLabel.Text = "Hiring Date: " + emp.Hire_Date;
                    SalaryLabel.Text = "Salary: " + emp.Salary;

                    using (StreamWriter write = File.AppendText(@"E:\ASUS\Documents\employee.txt"))
                    {
                        write.WriteLine(time + "\t" + emp.ID + "\t" + "Found" + "\t\t" + emp.firstName + "\t" + emp.lastName + "\t" + emp.Salary + "\t" + "\n");
                        write.Close();
                        return;
                    }
                }
            }

            if (!flag)
            {
                MessageBox.Show("Employee not found.");

                using (StreamWriter write = File.AppendText(@"E:\ASUS\Documents\employee.txt"))
                {
                    write.WriteLine(time + "\t" + SearchIDBox.Text + "\t" + "Not found" + "\n");
                    write.Close();
                }
            }
        }
    }
}
