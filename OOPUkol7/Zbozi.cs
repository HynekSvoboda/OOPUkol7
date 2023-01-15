using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPUkol7
{
    internal class Zbozi
    {
        string nazev;
        int cena;
        DateTime datumvyroby;
        int minimalnitrvanlivost;

        public Zbozi(string nazev, int cena, DateTime datummvyroby, int minimalnitrvanlivost)
        {
            this.nazev = nazev;
            this.cena = cena;
            this.datumvyroby = datummvyroby;
            this.minimalnitrvanlivost = minimalnitrvanlivost;
        }

        public bool SplnujeTrvan()
        {
            TimeSpan rozdil = DateTime.Today - datumvyroby;
            if (rozdil.TotalDays<minimalnitrvanlivost) return true;
            else return false;
        }
        public virtual double CenaSDPH()
        {
            return cena*1.21;
        }
        public override string ToString()
        {
          if(SplnujeTrvan())  return string.Format("{0} s cenou {1} s datumem výroby {2}\ns cenou s DPH\n{3} a splňuje min trvanlivost", nazev, cena, datumvyroby.ToShortDateString(), CenaSDPH());
          else return string.Format("{0} s cenou {1} s datumem výroby\n{2} s cenou s DPH\n{3} a nesplňuje min trvanlivost", nazev, cena, datumvyroby.ToShortDateString(), CenaSDPH());
        }
    }
}
