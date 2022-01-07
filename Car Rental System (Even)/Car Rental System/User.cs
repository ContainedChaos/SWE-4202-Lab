using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_System
{
    public class User
    {
        private int ID;
        private string Name;
        private string Address;
        private string Destination;

        public List <Car> rentedCar = new List <Car>(); 

        public void setID (int ID)
        { this.ID = ID; }

        public int getID ()
        { return this.ID; }
        
        public void setName (string Name)
        { this.Name = Name; }

        public string getName ()
        { return this.Name; }

        public void setAddress (string Address)
        { this.Address = Address; }

        public string getAddress ()
        { return this.Address; }

        public void setDestination (string Destination)
        { this.Destination = Destination; }

        public string getDestination ()
        { return this.Destination; }

        //public void addCar (string CarName)
        //{
        //    car.Add(CarName);
        //}

    }
}
