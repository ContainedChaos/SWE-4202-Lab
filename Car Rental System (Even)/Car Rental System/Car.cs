using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_System
{
    public class Car
    {
        private string Name;
        private string Model;
        private int Quantity;

        public void setName (string Name)
        { this.Name = Name; }

        public string getName ()
        { return this.Name; }

        public void setModel (string Model)
        { this.Model = Model; }

        public string getModel ()
        { return this.Model; }

        public void setQuantity (int Quantity)
        { this.Quantity = Quantity; }

        public int getQuantity ()
        { return this.Quantity; }

    }
}
