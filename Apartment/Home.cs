using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment
{
    public class Home
    {
        public List<Flat> Flats { get; set; }

        public Home(List<Flat> flats)
        {
            Flats = flats;
        }
    }
}
