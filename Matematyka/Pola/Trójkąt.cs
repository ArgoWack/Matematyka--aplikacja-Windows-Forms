using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace Matematyka.Pola
{
            /*
                one option would be to write your own struct Number that has a single double field
                you'd write all the operator overloads
            */
            class Trójkąt
            {
                // zmienne
                public double Bok1;
                public double Bok2;
                public double Bok3;
                public double Wysokość1;
                public double Wysokość2;
                public double Wysokość3;
                public double Kąt12;
                public double Kąt13;
                public double Kąt23;
                public double Obwód;
                public double Pole;
                public Trójkąt()
                {
                }

                public static void Wylicz_dane(Trójkąt trójkąt)
                {

                    for (int i = 0; i < 2; i++)
                    {

                        List<double> BOK1 = new List<double>();
                        BOK1.Add(Technical.Other_Methods.NULL_INFINITY(trójkąt.Bok1));
                        BOK1.Add(Technical.Other_Methods.NULL_INFINITY(trójkąt.Pole * 2 / trójkąt.Wysokość1));
                        if (trójkąt.Kąt12 != 0)
                        {
                            BOK1.Add(Technical.Other_Methods.NULL_INFINITY(trójkąt.Pole * 2 / (trójkąt.Bok2 * Math.Sin(Technical.Other_Methods.Kąt_na_radiany(trójkąt.Kąt12)))));
                        }
                        if (trójkąt.Kąt13 != 0)
                        {
                            BOK1.Add(Technical.Other_Methods.NULL_INFINITY(trójkąt.Pole * 2 / (trójkąt.Bok3 * Math.Sin(Technical.Other_Methods.Kąt_na_radiany(trójkąt.Kąt13)))));
                        }
                        if (trójkąt.Kąt13 == trójkąt.Kąt23 && Technical.Other_Methods.If_not_zero_of_two(trójkąt.Kąt13, trójkąt.Kąt23))
                        {
                            BOK1.Add(Technical.Other_Methods.NULL_INFINITY(trójkąt.Bok2));
                        }
                        if (trójkąt.Kąt12 == trójkąt.Kąt23 && Technical.Other_Methods.If_not_zero_of_two(trójkąt.Kąt12, trójkąt.Kąt23))
                        {
                            BOK1.Add(Technical.Other_Methods.NULL_INFINITY(trójkąt.Bok3));
                        }
                        if (trójkąt.Kąt12 == 60 && trójkąt.Kąt13 == 60 && trójkąt.Kąt23 == 60)
                        {
                            BOK1.Add(Technical.Other_Methods.NULL_INFINITY(trójkąt.Bok2));
                            BOK1.Add(Technical.Other_Methods.NULL_INFINITY(trójkąt.Bok3));
                            BOK1.Add(Technical.Other_Methods.NULL_INFINITY(2 * Math.Sqrt(trójkąt.Pole / Math.Sqrt(3))));
                        }
                        BOK1.Sort();
                        BOK1.Reverse();
                        trójkąt.Bok1 = BOK1[0];

                        List<double> BOK2 = new List<double>();
                        BOK2.Add(Technical.Other_Methods.NULL_INFINITY(trójkąt.Bok2));
                        BOK2.Add(Technical.Other_Methods.NULL_INFINITY(trójkąt.Pole * 2 / trójkąt.Wysokość2));
                        if (trójkąt.Kąt12 != 0)
                        {
                            BOK2.Add(Technical.Other_Methods.NULL_INFINITY(trójkąt.Pole * 2 / (trójkąt.Bok1 * Math.Sin(Technical.Other_Methods.Kąt_na_radiany(trójkąt.Kąt12)))));
                        }
                        if (trójkąt.Kąt23 != 0)
                        {
                            BOK2.Add(Technical.Other_Methods.NULL_INFINITY(trójkąt.Pole * 2 / (trójkąt.Bok3 * Math.Sin(Technical.Other_Methods.Kąt_na_radiany(trójkąt.Kąt23)))));
                        }
                        if (trójkąt.Kąt12 == trójkąt.Kąt13 && Technical.Other_Methods.If_not_zero_of_two(trójkąt.Kąt12, trójkąt.Kąt13))
                        {
                            BOK2.Add(Technical.Other_Methods.NULL_INFINITY(trójkąt.Bok3));
                        }
                        if (trójkąt.Kąt13 == trójkąt.Kąt23 && Technical.Other_Methods.If_not_zero_of_two(trójkąt.Kąt13, trójkąt.Kąt23))
                        {
                            BOK2.Add(Technical.Other_Methods.NULL_INFINITY(trójkąt.Bok1));
                        }
                        if (trójkąt.Kąt12 == 60 && trójkąt.Kąt13 == 60 && trójkąt.Kąt23 == 60)
                        {
                            BOK2.Add(Technical.Other_Methods.NULL_INFINITY(trójkąt.Bok1));
                            BOK2.Add(Technical.Other_Methods.NULL_INFINITY(trójkąt.Bok3));
                        }
                        BOK2.Sort();
                        BOK2.Reverse();
                        trójkąt.Bok2 = BOK2[0];

                        List<double> BOK3 = new List<double>();
                        BOK3.Add(Technical.Other_Methods.NULL_INFINITY(trójkąt.Bok3));
                        BOK3.Add(Technical.Other_Methods.NULL_INFINITY(trójkąt.Pole * 2 / trójkąt.Wysokość3));
                        if (trójkąt.Kąt13 != 0)
                        {
                            BOK3.Add(Technical.Other_Methods.NULL_INFINITY(trójkąt.Pole * 2 / (trójkąt.Bok1 * Math.Sin(Technical.Other_Methods.Kąt_na_radiany(trójkąt.Kąt13)))));
                        }
                        if (trójkąt.Kąt23 != 0)
                        {
                            BOK3.Add(Technical.Other_Methods.NULL_INFINITY(trójkąt.Pole * 2 / (trójkąt.Bok2 * Math.Sin(Technical.Other_Methods.Kąt_na_radiany(trójkąt.Kąt23)))));
                        }
                        if (trójkąt.Kąt12 == trójkąt.Kąt23 && Technical.Other_Methods.If_not_zero_of_two(trójkąt.Kąt12, trójkąt.Kąt23))
                        {
                            BOK3.Add(Technical.Other_Methods.NULL_INFINITY(trójkąt.Bok1));
                        }
                        if (trójkąt.Kąt12 == trójkąt.Kąt13 && Technical.Other_Methods.If_not_zero_of_two(trójkąt.Kąt12, trójkąt.Kąt13))
                        {
                            BOK3.Add(Technical.Other_Methods.NULL_INFINITY(trójkąt.Bok2));
                        }
                        if (trójkąt.Kąt12 == 60 && trójkąt.Kąt13 == 60 && trójkąt.Kąt23 == 60)
                        {
                            BOK3.Add(Technical.Other_Methods.NULL_INFINITY(trójkąt.Bok1));
                            BOK3.Add(Technical.Other_Methods.NULL_INFINITY(trójkąt.Bok2));
                        }
                        BOK3.Sort();
                        BOK3.Reverse();
                        trójkąt.Bok3 = BOK3[0];

                        List<double> WYSOKOŚĆ1 = new List<double>();
                        WYSOKOŚĆ1.Add(Technical.Other_Methods.NULL_INFINITY(trójkąt.Wysokość1));
                        WYSOKOŚĆ1.Add(Technical.Other_Methods.NULL_INFINITY(trójkąt.Pole * 2 / trójkąt.Bok1));
                        WYSOKOŚĆ1.Sort();
                        WYSOKOŚĆ1.Reverse();
                        trójkąt.Wysokość1 = WYSOKOŚĆ1[0];

                        List<double> WYSOKOŚĆ2 = new List<double>();
                        WYSOKOŚĆ2.Add(Technical.Other_Methods.NULL_INFINITY(trójkąt.Wysokość2));
                        WYSOKOŚĆ2.Add(Technical.Other_Methods.NULL_INFINITY(trójkąt.Pole * 2 / trójkąt.Bok2));
                        WYSOKOŚĆ2.Sort();
                        WYSOKOŚĆ2.Reverse();
                        trójkąt.Wysokość2 = WYSOKOŚĆ2[0];

                        List<double> WYSOKOŚĆ3 = new List<double>();
                        WYSOKOŚĆ3.Add(Technical.Other_Methods.NULL_INFINITY(trójkąt.Wysokość3));
                        WYSOKOŚĆ3.Add(Technical.Other_Methods.NULL_INFINITY(trójkąt.Pole * 2 / trójkąt.Bok3));
                        WYSOKOŚĆ3.Sort();
                        WYSOKOŚĆ3.Reverse();
                        trójkąt.Wysokość3 = WYSOKOŚĆ3[0];

                        List<double> KAT12 = new List<double>();
                        KAT12.Add(Technical.Other_Methods.NULL_INFINITY(trójkąt.Kąt12));
                        KAT12.Add(Math.Asin(Technical.Other_Methods.NULL_INFINITY(trójkąt.Pole * 2 / (trójkąt.Bok1 * trójkąt.Bok2))) * 180 / Math.PI);
                        if (Technical.Other_Methods.If_not_zero_of_two(trójkąt.Kąt13, trójkąt.Kąt23))
                        {
                            KAT12.Add(180 - (trójkąt.Kąt13 + trójkąt.Kąt23));
                        }
                        if (Technical.Other_Methods.If_not_zero_of_two(trójkąt.Bok1, trójkąt.Bok2))
                        {
                            if (trójkąt.Bok1 == trójkąt.Bok2 && trójkąt.Bok2 == trójkąt.Bok3)
                            {
                                KAT12.Add(60);
                            }
                        }
                        KAT12.Sort();
                        KAT12.Reverse();
                        trójkąt.Kąt12 = KAT12[0];

                        List<double> KAT13 = new List<double>();
                        KAT13.Add(Technical.Other_Methods.NULL_INFINITY(trójkąt.Kąt13));
                        KAT13.Add(Math.Asin(Technical.Other_Methods.NULL_INFINITY(trójkąt.Pole * 2 / (trójkąt.Bok1 * trójkąt.Bok3))) * 180 / Math.PI);
                        if (Technical.Other_Methods.If_not_zero_of_two(trójkąt.Kąt12, trójkąt.Kąt23))
                        {
                            KAT13.Add(180 - (trójkąt.Kąt12 + trójkąt.Kąt23));
                        }
                        if (Technical.Other_Methods.If_not_zero_of_two(trójkąt.Bok1, trójkąt.Bok2))
                        {
                            if (trójkąt.Bok1 == trójkąt.Bok2 && trójkąt.Bok2 == trójkąt.Bok3)
                            {
                                KAT13.Add(60);
                            }
                        }
                        KAT13.Sort();
                        KAT13.Reverse();
                        trójkąt.Kąt13 = KAT13[0];

                        List<double> KAT23 = new List<double>();
                        KAT23.Add(Technical.Other_Methods.NULL_INFINITY(trójkąt.Kąt23));
                        KAT23.Add(Math.Asin(Technical.Other_Methods.NULL_INFINITY(trójkąt.Pole * 2 / (trójkąt.Bok2 * trójkąt.Bok3))) * 180 / Math.PI);
                        if (Technical.Other_Methods.If_not_zero_of_two(trójkąt.Kąt12, trójkąt.Kąt13))
                        {
                            KAT23.Add(180 - (trójkąt.Kąt12 + trójkąt.Kąt13));
                        }
                        if (Technical.Other_Methods.If_not_zero_of_two(trójkąt.Bok1, trójkąt.Bok2))
                        {
                            if (trójkąt.Bok1 == trójkąt.Bok2 && trójkąt.Bok2 == trójkąt.Bok3)
                            {
                                KAT23.Add(60);
                            }
                        }
                        KAT23.Sort();
                        KAT23.Reverse();
                        trójkąt.Kąt23 = KAT23[0];

                        List<double> OBWÓD = new List<double>();
                        OBWÓD.Add(Technical.Other_Methods.NULL_INFINITY(trójkąt.Obwód));
                        OBWÓD.Add(Technical.Other_Methods.NULL_INFINITY(trójkąt.Bok1 + trójkąt.Bok2 + trójkąt.Bok3));
                        OBWÓD.Sort();
                        OBWÓD.Reverse();
                        trójkąt.Obwód = OBWÓD[0];

                        //Console.WriteLine(Math.Asin(0.5) * 180 / Math.PI);//30
                        //Console.WriteLine(Math.Sin(Kąt_na_radiany(30)));//0,5

                        List<double> POLE = new List<double>();
                        double Parametr = (Technical.Other_Methods.NULL_INFINITY(trójkąt.Obwód)) / 2;
                        POLE.Add(Technical.Other_Methods.NULL_INFINITY(trójkąt.Pole));
                        POLE.Add(Technical.Other_Methods.NULL_INFINITY(Math.Sqrt(Parametr * (Parametr - Technical.Other_Methods.NULL_INFINITY(trójkąt.Bok1)) * 
                          (Parametr - Technical.Other_Methods.NULL_INFINITY(trójkąt.Bok2)) * (Parametr - Technical.Other_Methods.NULL_INFINITY(trójkąt.Bok3)))));
                        POLE.Add(Technical.Other_Methods.NULL_INFINITY(((trójkąt.Bok1) * trójkąt.Wysokość1) / 2));
                        POLE.Add(Technical.Other_Methods.NULL_INFINITY(((trójkąt.Bok2) * trójkąt.Wysokość2) / 2));
                        POLE.Add(Technical.Other_Methods.NULL_INFINITY(((trójkąt.Bok3) * trójkąt.Wysokość3) / 2));
                        POLE.Add(Technical.Other_Methods.NULL_INFINITY((trójkąt.Bok1 * trójkąt.Bok2) / 2) * Math.Sin(Technical.Other_Methods.Kąt_na_radiany(trójkąt.Kąt12)));
                        POLE.Add(Technical.Other_Methods.NULL_INFINITY((trójkąt.Bok1 * trójkąt.Bok3) / 2) * Math.Sin(Technical.Other_Methods.Kąt_na_radiany(trójkąt.Kąt13)));
                        POLE.Add(Technical.Other_Methods.NULL_INFINITY((trójkąt.Bok2 * trójkąt.Bok3) / 2) * Math.Sin(Technical.Other_Methods.Kąt_na_radiany(trójkąt.Kąt23)));
                        if (trójkąt.Kąt12 == 60 && trójkąt.Kąt13 == 60 && trójkąt.Kąt23 == 60)
                        {
                            POLE.Add(Technical.Other_Methods.NULL_INFINITY(Math.Pow(trójkąt.Bok1, 2) * Math.Sqrt(3) / 4));
                        }
                        POLE.Sort();
                        POLE.Reverse();
                        trójkąt.Pole = POLE[0];
                    }
                }
                public static void Charakterystyka(Trójkąt trójkąt)
                {
                    if (trójkąt.Kąt12 == trójkąt.Kąt13 || trójkąt.Kąt12 == trójkąt.Kąt23 || trójkąt.Kąt13 == trójkąt.Kąt23)
                    {
                        Console.WriteLine("Jest to trójkąt równoramienny");
                    }
                    if (trójkąt.Kąt12 == 60 && trójkąt.Kąt13 == 60 && trójkąt.Kąt23 == 60)
                    {
                        Console.WriteLine("Jest to trójkąt równoboczny");
                    }
                    if (trójkąt.Kąt12 < 90 && trójkąt.Kąt13 < 90 && trójkąt.Kąt23 < 90)
                    {
                        Console.WriteLine("Jest to trójkąt ostrokątny");
                    }
                    if (trójkąt.Kąt12 == 90 || trójkąt.Kąt13 == 90 || trójkąt.Kąt23 == 90)
                    {
                        Console.WriteLine("Jest to trójkąt prostokątny");
                    }
                    if (trójkąt.Kąt12 > 90 || trójkąt.Kąt13 > 90 || trójkąt.Kąt23 > 90)
                    {
                        Console.WriteLine("Jest to trójkąt rozwartokątny");
                    }

                for (int i = 1; i < 100; i++)
                    {
                        if ((trójkąt.Bok1 == 3*i || trójkąt.Bok2 == 3 * i || trójkąt.Bok3 == 3 * i) && (trójkąt.Bok1 == 4 * i || trójkąt.Bok2 == 4 * i || trójkąt.Bok3 == 4 * i)
                                                                                          && (trójkąt.Bok1 == 5 * i || trójkąt.Bok2 == 5 * i || trójkąt.Bok3 == 5 * i))
                        {
                            Console.WriteLine("Jest to trójkąt egipski");
                        }
                    }

                }
            }
    
}
