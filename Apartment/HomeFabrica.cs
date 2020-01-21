using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment
{
    public class HomeFabrica
    {

        public Home CreateHome(List<Flat> flats)
        {
            Home home = new Home(flats);
            return home;
        }
    }
}
