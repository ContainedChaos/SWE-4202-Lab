using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask2
{
    internal class User
    {
        public string Name;
        public int ID;
        public string Address;

        public List <int> books = new List <int> ();
 
        public User()
        {

        }
        public User (int ID, string Name, string Address)
        {
            this.ID = ID;
            this.Name = Name;
            this.Address = Address;
        }

        public void addBook (int ID)
        {
            books.Add(ID);
        }
    }
}
