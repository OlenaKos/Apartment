using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment
{
    public static class Expenses
    {
        public static double priceElectricity = 1;
        public static double priceWater = 20;
        public static double priceSupport = 15;

        public static double CalculateElectricity(Flat flat)
        {
            return priceElectricity * (flat.Tenants.Count * 100 );
        }

        public static double CalculateWater(Flat flat)
        {
            return priceWater * (flat.Tenants.Count * 20);
        }

        public static double CalculateSupport(Flat flat)
        {
            return priceSupport * flat.Area;
        }

        public static double CalculateAll(Flat flat)
        {
            double res = 0;
            res += CalculateElectricity(flat);
            res += CalculateWater(flat);
            res += CalculateSupport(flat);
            return res;
        }

        public static double CalculateAll(List<Flat> flats)
        {
            double res = 0;
            foreach (var flat in flats)
            {
                res += CalculateElectricity(flat);
                res += CalculateWater(flat);
                res += CalculateSupport(flat);
            }

            return res;
        }

        public static int ThrowException()
        {
            int a, u;
            Exception exp = null;
            try
            {
                a = 0;
                u = 6 / a;
            }
            catch (Exception ex)
            {

                throw;// exp = ex;
            }
           // return exp;

            return u;
        }
    }
}
