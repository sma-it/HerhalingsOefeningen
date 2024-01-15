using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef10
{
    internal class Bankrekening
    {
        private string rekeningnummer;
        private double saldo;

        public string Eigenaar { get; private set; }

        public Bankrekening(string reknr, string eigenaar, double beginsaldo = 0.0)
        {
            rekeningnummer = reknr;
            Eigenaar = eigenaar;
            saldo = beginsaldo;
        }

        public void Storten(double bedrag)
        {
            if (bedrag > 0)
            {
                saldo += bedrag;
            }
        }

        public bool Opnemen(double bedrag)
        {
            if (bedrag > 0 && saldo >= bedrag)
            {
                saldo -= bedrag;
                return true;
            }
            return false;
        }

        public double ToonSaldo()
        {
            return saldo;
        }
    }
}
