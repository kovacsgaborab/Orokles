using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    class Program
    {
        static void Main(string[] args)
        {
            Ember jozef = new Ember("Jozef", 37);
            Tanulo mlazsen = new Tanulo("Mlazsen", 16, "10. A");
            Tanar olga = new Tanar("Olga néni", "Testnevelés", false, 25);
            Tanar stark = new Tanar("Stark úr", "Biofizika", true, 40);

            jozef.Koszon();
            mlazsen.Koszon();
            olga.Koszon();
            stark.Koszon();

            Console.ReadLine();
        }
    }
}
