using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment
{
    class Program
    {
        static void Main(string[] args)
        {
            Tenant pers1 = new Tenant ("Dima", "I");
            Tenant pers2 = new Tenant ("Serg", "Z") ;
            Tenant pers3 = new Tenant("Sasha", "B");
            Tenant pers4 = new Tenant("Serg", "RZ");
            Tenant pers5 = new Tenant("Yulya", "G");
            Tenant pers6 = new Tenant("Olena", "K");
            Tenant pers7 = new Tenant("Ruslan", "M");
            Tenant pers8 = new Tenant("Tanya", "N");

            Flat flat1 = new Flat(new List<Tenant>() { pers1, pers2 }, 46);
            Flat flat2 = new Flat(new List<Tenant>() { pers4, pers3 }, 60);
            Flat flat3 = new Flat(new List<Tenant>() { pers5, pers6, pers7}, 33);
            Flat flat4 = new Flat(new List<Tenant>() { pers8 }, 90);

            HomeFabrica homeFabrica = new HomeFabrica();
            Home home = homeFabrica.CreateHome(new List<Flat>() { flat1, flat2, flat3, flat4 });

            
        }
    }
}
