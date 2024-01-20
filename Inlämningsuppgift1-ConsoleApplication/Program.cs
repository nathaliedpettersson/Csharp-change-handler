using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift1_ConsoleApplication

{

    public class Växel
    {
        public int FemHundraLappar { get; }
        public int HundraLappar { get; }
        public int FemtioLappar { get; }
        public int TjugoLappar { get; }
        public int TioKronor { get; }
        public int FemKronor { get; }
        public int EnKronor { get; }

        public Växel(decimal växel)
        {
            FemHundraLappar = (int)(växel / 500);
            växel %= 500;

            HundraLappar = (int)(växel / 100);
            växel %= 100;

            FemtioLappar = (int)(växel / 50);
            växel %= 50;

            TjugoLappar = (int)(växel / 20);
            växel %= 20;

            TioKronor = (int)(växel / 10);
            växel %= 10;

            FemKronor = (int)(växel / 5);
            växel %= 5;

            EnKronor = (int)(växel / 1);
            växel %= 1;

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int pris = 0;
            int inbetalt = 0;

            Console.WriteLine("Bestäm pris på produkten du vill köpa:");
            pris = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Skriv in hur mycket du betalar in:");
            inbetalt = Convert.ToInt32(Console.ReadLine());

            decimal växel = inbetalt - pris;
            

            if (växel < 0)
            {
                Console.WriteLine("Du har betalat in för lite pengar.");
            } else
            {
                Växel tillbaka = new Växel(växel);

                Console.WriteLine("Växel tillbaka:");

                if (tillbaka.FemHundraLappar > 0)
                Console.WriteLine($"{tillbaka.FemHundraLappar} Femhundralappar");

                if (tillbaka.HundraLappar > 0)
                Console.WriteLine($"{tillbaka.HundraLappar} Hundralappar");

                if (tillbaka.FemtioLappar > 0)
                Console.WriteLine($"{tillbaka.FemtioLappar} Femtiolappar");

                if (tillbaka.TjugoLappar > 0)
                Console.WriteLine($"{tillbaka.TjugoLappar} Tjugolappar");

                if (tillbaka.TioKronor > 0)
                Console.WriteLine($"{tillbaka.TioKronor} Tiokronor");

                if (tillbaka.FemKronor > 0)
                Console.WriteLine($"{tillbaka.FemKronor} Femkronor");

                if (tillbaka.EnKronor > 0)
                Console.WriteLine($"{tillbaka.EnKronor} Enkronor");

                
            }

            Console.ReadLine();
        }
    }
}
