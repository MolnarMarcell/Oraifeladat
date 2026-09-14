using System;
using System.Collections.Generic;
using System.Text;

namespace Raktarkezelo
{
    internal class RaktarElem
    {
        private int dbSzam = 0;
        public string CikkNev { get; set; }

        public static double AfaKulcs = 0.27;

        public void Bevetelezes(int db)
        {
            if (db > 0) {
                dbSzam += db;
                Console.WriteLine("Bevételezés rögzítve.");
            }
            else
            {
                Console.WriteLine("Hibás bevételezés!");
            }
        }

        public void Kiadas(int db)
        {
            if (db > 0 && db <= dbSzam) {
                dbSzam -= db;
                Console.WriteLine("Kiadás rögzítve.");
            }
            else
            {
                Console.WriteLine("Hibás kiadás!");
            }
        }

        public static double BruttoArSzamitas(double nettoAr)
        {
            return nettoAr * (1 + AfaKulcs);
        }

        public RaktarElem(string cikkNev, int dbSzam)
        {
            CikkNev = cikkNev;
            this.dbSzam = dbSzam;
        }

    }
}
