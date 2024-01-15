using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef11
{
    internal class Product
    {
        private string productId;
        private int voorraad;

        public string Naam { get; private set; }
        public double Prijs { get; private set; }

        public Product(string id, string naam, double prijs, int beginvoorraad = 0)
        {
            productId = id;
            Naam = naam;
            Prijs = prijs;
            voorraad = beginvoorraad;
        }

        public void Aanvullen(int aantal)
        {
            voorraad += aantal;
        }

        public bool Verkopen(int aantal)
        {
            if (aantal <= voorraad)
            {
                voorraad -= aantal;
                return true;
            }
            return false;
        }

        public string ToonInformatie()
        {
            return $"Product: {Naam}, ID: {productId}, Prijs: {Prijs}, Voorraad: {voorraad}";
        }
    }
}
