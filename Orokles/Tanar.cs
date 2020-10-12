using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    class Tanar : Ember
    {
        private string szak;
        private bool osztalyfonok;

        public Tanar(string nev, string szak, bool osztalyfonok, int eletkor) : base(nev, eletkor)
        {
            this.szak = szak;
            this.osztalyfonok = osztalyfonok;
        }

        public void Koszon()
        {
            if (osztalyfonok)
            {
                Console.WriteLine($"{nev} vagyok, {szak} tanár, osztályfőnök.");
            }
            else
            {
                Console.WriteLine($"{nev} vagyok, {szak} tanár.");
            }

        }
    }
}
