using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment
{
    public class Flat
    {
        public Tenant Owner { get; set; }
        public List<Tenant> Tenants { get; set; }
        public int Area { set; get; }
        public int rooms { set; get; }

        public Flat(List<Tenant> tenants, int area)
        {
            Tenants = tenants;
            Area = area;
            Owner = Tenants[0];
        }
    }
}
