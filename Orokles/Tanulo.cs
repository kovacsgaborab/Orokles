using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    class Tanulo : Ember
    {
        private string osztaly;

        public Tanulo(string nev, int eletkor, string osztaly) : base(nev, eletkor) //meghívjuk az alaposztályt
        {
            
            this.osztaly = osztaly;
        }

        public new void Koszon()
        {
            Console.WriteLine($"Hello, {nev} vagyok, {eletkor} éves, {osztaly}-ban tanulok.");
        }
    }
}
