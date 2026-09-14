using System;
using System.Collections.Generic;
using System.Text;

namespace WebaruhazTermek
{
    internal class Termek
    {
        public string Nev { get; set; }

        private int egysegar;
        private int keszlet;
        public int Egysegar
        {
            get { return egysegar; }
            set { 
                if (value < 1) 
                {
                    egysegar = 1; 
                }
            else
                {
                    egysegar = value;
                }
}
        }

        public int Keszlet
        {
            get { return keszlet; }
            set {
                if (value <= 0)
                {
                    keszlet = 0;
                }
                else
                {
                    keszlet = value;
                }
            }
        }

        public Termek(string nev, int egysegar, int keszlet)
        {
            Nev = nev;
            Egysegar = egysegar;
            Keszlet = keszlet;
        }
    }
}
