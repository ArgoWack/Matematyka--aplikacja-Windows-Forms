using System;
using System.Collections.Generic;
using System.Text;

namespace Matematyka.Pola
{
    class Wielokąt_foremny
    {
        public double Bok;//a
        public double Promień_okręgu_wpisanego;//r
        public double Promień_okręgu_opisanego;//R
        public double Pole;
        public double Obwód;
        public double Ilość_boków;//n
        public double Kąt;
        public double Suma_miar_kątów_wewnętrznych;

        public Wielokąt_foremny()
        {

        }
        public Wielokąt_foremny(double Bok,double Promień_okręgu_wpisanego, double Promień_okręgu_opisanego, double Pole, double Obwód, double Kąt,
            double Ilość_ścian, double Suma_miar_kątów_wewnętrznych)
        {
            this.Bok = Bok;
            this.Promień_okręgu_wpisanego = Promień_okręgu_wpisanego;
            this.Promień_okręgu_opisanego = Promień_okręgu_opisanego;
            this.Pole = Pole;
            this.Obwód = Obwód;
            this.Kąt = Kąt;
            this.Ilość_boków = Ilość_boków;
            this.Suma_miar_kątów_wewnętrznych = Suma_miar_kątów_wewnętrznych;
        }

        public static void Wylicz_dane(Wielokąt_foremny wielokąt_foremny)
        {
            for (int i = 0; i < 2; i++)
            {
                double cotangens = 1 / Math.Tan(wielokąt_foremny.Ilość_boków);
                //public double Kąt;
                //public double Suma_miar_kątów_wewnętrznych;
                wielokąt_foremny.Suma_miar_kątów_wewnętrznych = Math.Max(wielokąt_foremny.Suma_miar_kątów_wewnętrznych, (wielokąt_foremny.Ilość_boków-2)*180);

                wielokąt_foremny.Kąt = Math.Max(wielokąt_foremny.Kąt, Technical.Other_Methods.NULL_INFINITY(360 / wielokąt_foremny.Ilość_boków));

                wielokąt_foremny.Ilość_boków = Math.Max(wielokąt_foremny.Ilość_boków, Technical.Other_Methods.NULL_INFINITY(360 / wielokąt_foremny.Kąt));

                wielokąt_foremny.Obwód = Math.Max(wielokąt_foremny.Obwód, wielokąt_foremny.Ilość_boków* wielokąt_foremny.Bok);

                //Bok - a
                List<double> BOK = new List<double>();
                BOK.Add(Technical.Other_Methods.NULL_INFINITY(wielokąt_foremny.Bok));
                BOK.Add(Technical.Other_Methods.NULL_INFINITY(2*Math.Sqrt(wielokąt_foremny.Pole/(wielokąt_foremny.Ilość_boków* cotangens))));
                BOK.Sort();
                BOK.Reverse();
                wielokąt_foremny.Bok = BOK[0];

                //Promień_okręgu_wpisanego - r
                List<double> PROMIEŃ_OKRĘGU_WPISANEGO = new List<double>();
                PROMIEŃ_OKRĘGU_WPISANEGO.Add(Technical.Other_Methods.NULL_INFINITY(wielokąt_foremny.Promień_okręgu_wpisanego));
                PROMIEŃ_OKRĘGU_WPISANEGO.Add(Technical.Other_Methods.NULL_INFINITY((wielokąt_foremny.Bok/2)* cotangens));
                PROMIEŃ_OKRĘGU_WPISANEGO.Add(Technical.Other_Methods.NULL_INFINITY(2*wielokąt_foremny.Pole/(wielokąt_foremny.Ilość_boków*wielokąt_foremny.Bok)));
                PROMIEŃ_OKRĘGU_WPISANEGO.Sort();
                PROMIEŃ_OKRĘGU_WPISANEGO.Reverse();
                wielokąt_foremny.Promień_okręgu_wpisanego = PROMIEŃ_OKRĘGU_WPISANEGO[0];

              //Promień_okręgu_opisanego - R
                List<double> PROMIEŃ_OKRĘGU_OPISANEGO = new List<double>();
                PROMIEŃ_OKRĘGU_OPISANEGO.Add(Technical.Other_Methods.NULL_INFINITY(wielokąt_foremny.Promień_okręgu_opisanego));
                PROMIEŃ_OKRĘGU_OPISANEGO.Add(Technical.Other_Methods.NULL_INFINITY(wielokąt_foremny.Bok/(2*Math.Sin(Technical.Other_Methods.Kąt_na_radiany(Math.PI/wielokąt_foremny.Ilość_boków)))));
                PROMIEŃ_OKRĘGU_OPISANEGO.Sort();
                PROMIEŃ_OKRĘGU_OPISANEGO.Reverse();
                wielokąt_foremny.Promień_okręgu_opisanego = PROMIEŃ_OKRĘGU_OPISANEGO[0];


                List<double> POLE = new List<double>();
                POLE.Add(Technical.Other_Methods.NULL_INFINITY(wielokąt_foremny.Pole));
                //cotangens=Math.PI/2 - Math.Atan(x)
                POLE.Add(Technical.Other_Methods.NULL_INFINITY((wielokąt_foremny.Ilość_boków/4)* Math.Pow(wielokąt_foremny.Bok,2)*(cotangens)));
                POLE.Add(Technical.Other_Methods.NULL_INFINITY(wielokąt_foremny.Ilość_boków / 4) * wielokąt_foremny.Bok*
                         Math.Sqrt(4*Math.Pow(wielokąt_foremny.Promień_okręgu_opisanego, 2)-Math.Pow(wielokąt_foremny.Bok, 2)));
                POLE.Add(Technical.Other_Methods.NULL_INFINITY(wielokąt_foremny.Ilość_boków/(2* wielokąt_foremny.Bok *wielokąt_foremny.Promień_okręgu_wpisanego)));
                POLE.Sort();
                POLE.Reverse();
                wielokąt_foremny.Pole = POLE[0];
            }
        }
    }
}
