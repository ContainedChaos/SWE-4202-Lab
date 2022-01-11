using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public class User
    {
        private int ID;
        private string Name;
        private string Address;
        private string Contact;

        public int getID () { return this.ID; }
        public string getName () { return this.Name; }
        public string getAddress () { return this.Address; }
        public string getContact () { return this.Contact; } 

        public User (int ID, string Name, string Address, string Contact)
        {
            this.ID = ID;
            this.Name = Name;
            this.Address = Address;
            this.Contact = Contact;
        }
    }
}
