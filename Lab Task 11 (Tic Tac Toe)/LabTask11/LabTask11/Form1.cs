using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTask11
{
    public partial class Form1 : Form
    {
        bool turn = true;
        int turn_count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;

            b.Enabled = false;
            turn_count++;
            WinState();
        }

        private void WinState()
        {
            bool win = false;

            if ((a1.Text == a2.Text) && (a2.Text == a3.Text) && (!a1.Enabled))
                win = true;
            else if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && (!b1.Enabled))
                win = true;
            else if ((c1.Text == c2.Text) && (c2.Text == c3.Text) && (!c1.Enabled))
                win = true;


            else if ((a1.Text == b1.Text) && (b1.Text == c1.Text) && (!a1.Enabled))
                win = true;
            else if ((a2.Text == b2.Text) && (b2.Text == c2.Text) && (!a2.Enabled))
                win = true;
            else if ((a3.Text == b3.Text) && (b3.Text == c3.Text) && (!a3.Enabled))
                win = true;


            else if ((a1.Text == b2.Text) && (b2.Text == c3.Text) && (!a1.Enabled))
                win = true;
            else if ((a3.Text == b2.Text) && (b2.Text == c1.Text) && (!c1.Enabled))
                win = true;

            if (win)
            {
                DisableButtons();
                String winner = "";

                if (turn)
                    winner = "O";
                else
                    winner = "X";

                MessageBox.Show(winner + " wins!");
            }

            else
            {
                if (turn_count == 9)
                    MessageBox.Show("Draw!");
            }
        }

        private void DisableButtons()
        {
                foreach (Control c in Controls)
                {
                    try
                    {

                        Button b = (Button)c;
                        b.Enabled = false;
                    }

                    catch { }
                }

                ResetButton.Enabled = true;
            }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            turn = true;

            turn_count = 0;

                foreach (Control c in Controls)
                {
                    try
                    {
                        Button b = (Button)c;
                        b.Enabled = true;
                        b.Text = "";
                    }

                    catch { }
                }

            ResetButton.Text = "Reset";
            
        }
    }
    }

