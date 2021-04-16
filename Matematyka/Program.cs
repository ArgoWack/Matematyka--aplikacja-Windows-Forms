using System;
using System.Collections.Generic;

namespace Matematyka
{
    class Program
    {
        static void Main(string[] args)
        {
            int wybor_zewnętrzny = Technical.Exceptions_handling.Exceptions_int(1, 4,
                "Wybierz jaka kategoria cię interesuje: 1 - figury 2D, 2 - figury 3D, 3 - artmetyka, 4 - macierze");
            switch (wybor_zewnętrzny)
            {
                case 1:
                    {
                        //Pola/objętości
                        int wybor_wewnętrzny = Technical.Exceptions_handling.Exceptions_int(0, 3,
                            "Wybierz figure która cię interesuje  0 - koło, 1 - trójkąt , 2 - czworokąt, 3 - wielokąt foremny");
                        Console.WriteLine("Jeżeli nie znasz danego parametru to wpisz: 0");
                        switch (wybor_wewnętrzny)
                        {
                            case 0:
                                {//koło

                                    Pola.Koło koło = new Pola.Koło();
                                    koło.Promień = Technical.Exceptions_handling.Exceptions_double_without_limits("Podaj promień");
                                    koło.Pole = Technical.Exceptions_handling.Exceptions_double_without_limits("Podaj pole");
                                    koło.Obwód = Technical.Exceptions_handling.Exceptions_double_without_limits("Podaj obwód");

                                    Pola.Koło.Wylicz_dane(koło);

                                    Console.WriteLine(" Promień wynosi: " + Math.Round(koło.Promień, 3));
                                    Console.WriteLine(" Pole wynosi: " + Math.Round(koło.Pole, 3));
                                    Console.WriteLine(" Obwód wynosi: " + Math.Round(koło.Obwód, 3));
                                    break;
                                }
                            case 1:
                                {// trójkąty
                                    // Można dodać rozpatrywanie okręgu wpisanego, oraz opisanego
                                    // Dodatkowo można ustalić długości odcinków na jakie dzielą wysokości opuszczone na boki (jeżeli wewnątrz)

                                    Pola.Trójkąt trójkąt = new Pola.Trójkąt();

                                    trójkąt.Bok1 = Technical.Exceptions_handling.Exceptions_double_without_limits("Podaj pierwszy bok");
                                    trójkąt.Bok2 = Technical.Exceptions_handling.Exceptions_double_without_limits("Podaj drugi bok");
                                    trójkąt.Bok3 = Technical.Exceptions_handling.Exceptions_double_without_limits("Podaj trzeci bok");

                                    trójkąt.Wysokość1 = Technical.Exceptions_handling.Exceptions_double_without_limits("Podaj wysokość padającą na bok pierwszy");
                                    trójkąt.Wysokość2 = Technical.Exceptions_handling.Exceptions_double_without_limits("Podaj wysokość padającą na bok drugi");
                                    trójkąt.Wysokość3 = Technical.Exceptions_handling.Exceptions_double_without_limits("Podaj wysokość padającą na bok trzeci");
                                    
                                    trójkąt.Kąt12 = Technical.Exceptions_handling.Exceptions_double_without_limits("Podaj kąt między bokiem pierwszym, a drugim (w stopniach): ");
                                    trójkąt.Kąt13 = Technical.Exceptions_handling.Exceptions_double_without_limits("Podaj kąt między bokiem pierwszym, a trzecim (w stopniach): ");
                                    trójkąt.Kąt23 = Technical.Exceptions_handling.Exceptions_double_without_limits("Podaj kąt między bokiem drugim, a trzecim (w stopniach): ");

                                    trójkąt.Pole = Technical.Exceptions_handling.Exceptions_double_without_limits("Podaj pole");

                                    trójkąt.Obwód = Technical.Exceptions_handling.Exceptions_double_without_limits("Podaj obwód");

                                    Pola.Trójkąt.Wylicz_dane(trójkąt);
                                    Pola.Trójkąt.Charakterystyka(trójkąt);

                                    Console.WriteLine(" Pierwszy bok wynosi: " + Math.Round(trójkąt.Bok1, 3));
                                    Console.WriteLine(" Drugi bok wynosi: " + Math.Round(trójkąt.Bok2, 3));
                                    Console.WriteLine(" Trzeci bok wynosi: " + Math.Round(trójkąt.Bok3, 3));
                                    Console.WriteLine(" Wysokość padającą na bok pierwszy wynosi: " + Math.Round(trójkąt.Wysokość1, 3));
                                    Console.WriteLine(" Wysokość padającą na bok drugi wynosi: " + Math.Round(trójkąt.Wysokość2, 3));
                                    Console.WriteLine(" Wysokość padającą na bok trzeci wynosi: " + Math.Round(trójkąt.Wysokość3, 3));
                                    Console.WriteLine(" Kąt między bokiem pierwszym, a drugim wynosi: " + Math.Round(trójkąt.Kąt12, 3));
                                    Console.WriteLine(" Kąt między bokiem pierwszym, a trzecim wynosi: " + Math.Round(trójkąt.Kąt13, 3));
                                    Console.WriteLine(" Kąt między bokiem drugim, a trzecim wynosi: " + Math.Round(trójkąt.Kąt23, 3));
                                    Console.WriteLine(" Pole wynosi: " + Math.Round(trójkąt.Pole, 3));
                                    Console.WriteLine(" Obwód wynosi: " + Math.Round(trójkąt.Obwód, 3));

                                    break;
                                }
                            case 2:
                                {//czworokąty 
                                    break;
                                }
                            case 3:
                                {// wielokąt_foremny
                                    // Poprawić promienie

                                    Pola.Wielokąt_foremny wielokąt_foremny = new Pola.Wielokąt_foremny();

                                    wielokąt_foremny.Bok = Technical.Exceptions_handling.Exceptions_double_without_limits("Podaj długość boku: ");
                                    wielokąt_foremny.Ilość_boków = Technical.Exceptions_handling.Exceptions_double_without_limits("Podaj ilość ścian: ");
                                    wielokąt_foremny.Promień_okręgu_wpisanego = Technical.Exceptions_handling.Exceptions_double_without_limits("Podaj promień koła wpisanego w wielokąt: ");
                                    wielokąt_foremny.Promień_okręgu_opisanego = Technical.Exceptions_handling.Exceptions_double_without_limits("Podaj promień koła opisanego na wielokącie: ");
                                    wielokąt_foremny.Suma_miar_kątów_wewnętrznych = Technical.Exceptions_handling.Exceptions_double_without_limits("Podaj sume miar kątów wewnętrznych: ");
                                    wielokąt_foremny.Pole = Technical.Exceptions_handling.Exceptions_double_without_limits("Podaj pole");
                                    wielokąt_foremny.Obwód = Technical.Exceptions_handling.Exceptions_double_without_limits("Podaj obwód");

                                    Pola.Wielokąt_foremny.Wylicz_dane(wielokąt_foremny);

                                    Console.WriteLine(" Długość boku wynosi: " + Math.Round(wielokąt_foremny.Bok, 3));
                                    Console.WriteLine(" Ilość ścian wynosi: " + Math.Round(wielokąt_foremny.Ilość_boków, 3));
                                    Console.WriteLine(" Promień koła wpisanego w wielokąt wynosi: " + Math.Round(wielokąt_foremny.Promień_okręgu_wpisanego, 3));
                                    Console.WriteLine(" Promień koła opisanego w wielokąt wynosi: " + Math.Round(wielokąt_foremny.Promień_okręgu_opisanego, 3));
                                    Console.WriteLine(" Suma miar kątów wewnętrznych:: " + Math.Round(wielokąt_foremny.Suma_miar_kątów_wewnętrznych, 3));
                                    Console.WriteLine(" Pole wynosi: " + Math.Round(wielokąt_foremny.Pole, 3));
                                    Console.WriteLine(" Obwód wynosi: " + Math.Round(wielokąt_foremny.Obwód, 3));

                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("błąd 1");
                                    break;
                                }
                        }
                        break;
                    }
                case 2:
                    {
                        //objętości
                        int wybor_wewnętrzny = Technical.Exceptions_handling.Exceptions_int(0, 3, "Wybierz jaka kategoria cię interesuje: 0 - kula , 1 - prostopadłościan ," +
                                                                                                  " 2 - ostrosłup, 3 - stożek");
                        switch (wybor_wewnętrzny)
                        {
                            case 0:
                                {//kula

                                    break;
                                }
                            case 1:
                                {// prostopadłościan

                                    break;
                                }
                            case 2:
                                {// ostrosłup

                                    break;
                                }
                            case 3:
                                {// stożek

                                        break;
                                }
                            default:
                                {
                                    Console.WriteLine("błąd 2");
                                    break;
                                }
                        }
                        break;
                    }
                case 3:
                    {
                        //artmetyka
                        int wybor_wewnętrzny = Technical.Exceptions_handling.Exceptions_int(0, 3, "Wybierz jaka kategoria cię interesuje: 0 - NWD/NWW , 1 - dzielenie z resztą" +
                                                                                                  "2 - funkcja liniowa, 3 - funkcja kwadratowa");
                        switch (wybor_wewnętrzny)
                        {
                            case 0:
                                {//NWD/NWW
                                    Artmetyka.Artmetyka artmetyka = new Artmetyka.Artmetyka();

                                    artmetyka.Liczba_pierwsza = Technical.Exceptions_handling.Exceptions_double_without_limits("Podaj pierwszą liczbe");
                                    artmetyka.Liczba_druga = Technical.Exceptions_handling.Exceptions_double_without_limits("Podaj drugą liczbe");

                                    Artmetyka.Artmetyka.NWD(artmetyka);

                                    Console.WriteLine(" NWD wynosi: " + Math.Round(artmetyka.Nwd, 3));
                                    Console.WriteLine(" NWW wynosi: " + Math.Round(artmetyka.Nww, 3));
                                    break;
                                }
                            case 1:
                                {//dzielenie z resztą

                                    break;
                                }
                            case 2:
                                {//funkcja liniowa

                                        break;
                                }
                            case 3:
                                {//funkcja kwadratowa

                                        break;
                                }
                            default:
                                {
                                    Console.WriteLine("błąd 3");
                                    break;
                                }
                        }
                        break;
                    }
                    case 4:
                    {
                        //macierze
                        int number_of_matrices = Technical.Exceptions_handling.Exceptions_int(1, 2,
                        "Napisz czy chcesz wprowadzic jedna - 1, czy dwie -2 tabele");
                        int Rows1 = Technical.Exceptions_handling.Exceptions_uint_without_limits("Podaj ilość rzędów dla macierzy1");
                        int Columns1 = Technical.Exceptions_handling.Exceptions_uint_without_limits("Podaj ilość kolumn dla macierzy1");
                        double[,] table1 = new double[Rows1, Columns1];
                        for (int i = 0; i < Rows1; i++)
                        {
                            for (int j = 0; j < Columns1; j++)
                            {
                                table1[i, j] = Technical.Exceptions_handling.Exceptions_double_Table2D(i, j, "Wstaw liczbe dla a");
                            }
                        }

                        if (number_of_matrices == 2)
                        {
                            int Rows2 = Technical.Exceptions_handling.Exceptions_uint_without_limits("Podaj ilość rzędów dla macierzy2");
                            int Columns2 = Technical.Exceptions_handling.Exceptions_uint_without_limits("Podaj ilość kolumn dla macierzy2");
                            double[,] table2 = new double[Rows2, Columns2];
                            for (int i = 0; i < Rows2; i++)
                            {
                                for (int j = 0; j < Columns2; j++)
                                {
                                    table2[i, j] = Technical.Exceptions_handling.Exceptions_double_Table2D(i, j, "Wstaw liczbe dla b");
                                }
                            }

                            int Inner_Choice = Technical.Exceptions_handling.Exceptions_int(0, 4,
                                "Wybierz jedną spośród dostepnych opcji na macierzach: \n odejmowanie - 0 \n dodawanie - 1 \n Mnożenie macierzy - 2\n Iloczyn Hadamarda - 3 \n Iloczyn Kroneckera - 4 \n");
                            switch (Inner_Choice)
                            {
                                case 0:
                                    {
                                        //działa
                                        Macierze._2_matrixes_operations.Matrices_substraction(Rows1, Columns1, Rows2, Columns2, table1, table2);
                                        break;
                                    }
                                case 1:
                                    {
                                        //działa
                                        Macierze._2_matrixes_operations.Matrices_adding(Rows1, Columns1, Rows2, Columns2, table1, table2);
                                        break;
                                    }
                                case 2:
                                    {
                                        // Działa
                                        Macierze._2_matrixes_operations.Matrices_multiplication(Rows1, Columns1, Rows2, Columns2, table1,
                                            table2);
                                        break;
                                    }
                                case 3:
                                    {
                                        Macierze._2_matrixes_operations.Hadamard_product(Rows1, Columns1, Rows2, Columns2, table1, table2);
                                        // Działa

                                        break;
                                    }
                                case 4:
                                    {
                                        Macierze._2_matrixes_operations.Kronecker_product(Rows1, Columns1, Rows2, Columns2, table1, table2);
                                        // Działa
                                        break;
                                    }
                                default:
                                    {
                                        // działa
                                        Console.WriteLine("Błędne dane");
                                        break;
                                    }
                            }
                        }
                        else
                        {
                            int Outer_Choice = Technical.Exceptions_handling.Exceptions_int(0, 7,
                                "Wybierz jedną spośród dostepnych opcji na macierzach: \n Liczenie wyznacznika - 0 \n Transpozycja - 1 " +
                                "\n Liczenie śladu - 2 \n Mnożenie macierzy przez skalar - 3 \n operacje elementarne -4 " +
                                "\n liczenie macierzy odwrotnej -5 \n charakterystyka macierzy - 6 \n potęgowanie macierzy - 7 \n");
                            switch (Outer_Choice)
                            {

                                case 0:
                                    {
                                        // działa dla 0,1,2,3
                                        Macierze.Single_matrix_operations.Det(Rows1, Columns1, table1);
                                        break;
                                    }
                                case 1:
                                    {
                                        // działa
                                        Macierze.Single_matrix_operations.Transposition(Rows1, Columns1, table1);
                                        break;
                                    }
                                case 2:
                                    {
                                        // działa
                                        Macierze.Single_matrix_operations.Trace(Rows1, Columns1, table1);
                                        break;
                                    }
                                case 3:
                                    {
                                        // działa
                                        Macierze.Single_matrix_operations.Multiplication_scalar(Rows1, Columns1, table1);
                                        break;
                                    }
                                case 4:
                                    {
                                        // do sprawdzenia
                                        Macierze.Single_matrix_operations.Elementary_operations(Rows1, Columns1, table1);
                                        break;
                                    }
                                case 5:
                                    {
                                        // Nie działa
                                        // liczenie macierzy odwrotnej - Brak
                                        Console.WriteLine("Liczenie macierzy odwrotnej: \n");
                                        break;
                                    }
                                case 6:
                                    {
                                        // Działa
                                        Macierze.Single_matrix_operations.Matrices_characteristic(Rows1, Columns1, table1);
                                        break;
                                    }
                                case 7:
                                    {
                                        // Działa
                                        Macierze.Single_matrix_operations.Matrices_powering(Rows1, Columns1, table1);
                                        break;
                                    }
                                default:
                                    {
                                        // działa
                                        Console.WriteLine("Błędne dane");
                                        break;
                                    }
                            }
                        }
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("błąd 1 - d");
                        break;
                    }
            }
            Console.ReadLine();
        }
    }
}
