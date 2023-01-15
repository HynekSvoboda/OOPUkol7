using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPUkol7
{
    internal class Produkt : Zbozi
    {
        bool lzezlevnit;
        public Produkt(string nazev, int cena, DateTime datummvyroby, int minimalnitrvanlivost, bool lzezlevnit) : base(nazev, cena, datummvyroby, minimalnitrvanlivost)
        {
            this.lzezlevnit = lzezlevnit;   
        }

        public override double CenaSDPH()
        {
            if (lzezlevnit && !SplnujeTrvan()) return base.CenaSDPH() * 0.6;
            return base.CenaSDPH();
        }
    }
}
