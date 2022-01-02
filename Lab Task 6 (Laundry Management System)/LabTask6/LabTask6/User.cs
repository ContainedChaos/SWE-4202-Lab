using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask6
{
    public class User
    {
        public int ID;
        public string Name;
        public string Address;

        public User (int ID, string Name, string Address)
        {
            this.ID = ID;
            this.Name = Name;
            this.Address = Address;
        }
    }
}
