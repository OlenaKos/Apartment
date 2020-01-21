using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment
{
    public class Tenant
    {
        public string LastName { set; get; }
        public string FirstName { set; get; }

        public Tenant(string name, string surname)
        {
            LastName = name;
            FirstName = surname;
        }

    }
}
