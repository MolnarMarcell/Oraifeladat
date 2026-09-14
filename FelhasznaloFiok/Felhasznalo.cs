using System;
using System.Collections.Generic;
using System.Text;

namespace FelhasznaloFiok
{
    internal class Felhasznalo
    {
        private string Jelszo = "123456";


        public string Felhasznalonev { get; set; }

        public void JelszoModositas(string regiJelszo, string ujJelszo)
        {
            if (Jelszo == regiJelszo && ujJelszo.Length >= 6)
            {
                Jelszo = ujJelszo;
                Console.WriteLine("Jelszó módosítva!");
            }
            else
            {
                Console.WriteLine("Hibás jelszó vagy nem megfelelő hossz!");
            }
        }
    }
}
