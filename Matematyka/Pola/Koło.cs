using System;
using System.Collections.Generic;

namespace Matematyka.Pola
{
    class Koło
    {
        public double Promień;
        public double Pole;
        public double Obwód;

        public Koło()
        {

        }

        public static void Wylicz_dane(Koło koło)
        {
            for (int i = 0; i < 2; i++)
            {
                koło.Pole = Math.Max(Math.PI * koło.Promień * koło.Promień, koło.Pole);
                koło.Obwód = Math.Max(2 * Math.PI * koło.Promień, koło.Obwód);
                koło.Promień = Math.Max(Math.Sqrt(koło.Pole / Math.PI), koło.Obwód / (2 * Math.PI));
            }
        }
    }
}
