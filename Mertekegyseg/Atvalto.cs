using System;
using System.Collections.Generic;
using System.Text;

namespace Mertekegyseg
{
    internal class Atvalto
    {
        public double Szorzo;
        public static double KmBolMeter(double km)
        {
            return km * 1000;
        }

        public double EgyediAtvaltas(double ertek)
        {
            return ertek * Szorzo;
        }
    }
}
