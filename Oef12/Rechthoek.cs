using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef12
{
    internal class Rechthoek
    {
        private double lengte;
        private double breedte;

        public Rechthoek(double lengte, double breedte)
        {
            this.lengte = lengte;
            this.breedte = breedte;
        }

        public double BerekenOppervlakte()
        {
            return lengte * breedte;
        }

        public double BerekenOmtrek()
        {
            return 2 * (lengte + breedte);
        }

        public string ToonInformatie()
        {
            return $"Rechthoek: Lengte = {lengte}, Breedte = {breedte}, Oppervlakte = {BerekenOppervlakte()}, Omtrek = {BerekenOmtrek()}";
        }
    }
}
