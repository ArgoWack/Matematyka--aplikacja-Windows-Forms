﻿using System;
using System.Collections.Generic;

namespace Matematyka.Macierze
{
    class Single_matrix_operations
    {

        // wyznacznik działa dla wymiarów 0-3 tylko, dla >=4  - Brak
        public static void Det(int Rows1, int Columns1, double[,] table1)
        {
            {
                if (Rows1 != Columns1)
                {
                    Console.WriteLine("Macierz nie jest kwadratowa, więc nie da się policzyć jej wyznacznika");
                }
                else
                {
                    double det = 0;
                    switch (Rows1)
                    {
                        case 0:
                            {
                                //pusta
                                Console.WriteLine("wyznacznik nie istnieje");
                                break;
                            }
                        case 1:
                            {
                                //singleton
                                Console.WriteLine("wyznacznik Det(A)=" + table1[0, 0]);
                                break;
                            }
                        case 2:
                            {
                                //ad-bc
                                det = table1[0, 0] * table1[1, 1] - table1[1, 0] * table1[0, 1];
                                Console.WriteLine("wyznacznik Det(A)=" + det);
                                break;
                            }
                        case 3:
                            {
                                //sarrus
                                det = table1[0, 0] * table1[1, 1] * table1[2, 2] +
                                      table1[0, 1] * table1[1, 2] * table1[2, 0] +
                                      table1[0, 2] * table1[1, 0] * table1[2, 1]
                                      - table1[0, 2] * table1[1, 1] * table1[2, 1] * table1[1, 0] -
                                      table1[0, 0] * table1[1, 2] * table1[2, 1] -
                                      table1[0, 1] * table1[1, 0] * table1[2, 2];
                                Console.WriteLine("wyznacznik Det(A)=" + det);
                                break;
                            }
                        default:
                            {
                                // Liczenie wyznacznika  dla D>3 np: La'placem dopiero do napisania
                                /*
                                int w = 0;
                                for (int i = 0; i < D; i++)
                                {
                                    for (int j = 0; j < D; j++)
                                    {
                                    det(table1[i,j])=table3[1,j]*((-1)^(1+j))*(
                                     w++;
                                        for (int a = w; a < D; a++)
                                        {
                                            int n = 0;
                                            for (int b = 0; b < D; b++)
                                            {
                                                det(table1[a,b])=table1[a, if (b < 0 + n)
                                                {
                                                   j
                                                }
                                                else
                                                {
                                                    j + 1
                                                }]

                                                n++;
                                            }
                                        }

                                    )
                                    }
                                }
                                Console.WriteLine("wyznacznik Det(A)=" + det(table1[i,j]));
                                */
                                break;

                            }
                    }
                }
            }
        }

        public static void Transposition(int Rows1, int Columns1, double[,] table1)
        {
            double[,] table3 = new double[Columns1, Rows1];
            // Transpozycja macierzy A
            Console.WriteLine("Macierz transpozycja macierzy A:");
            for (int i = 0; i < Rows1; i++)
            {
                for (int j = 0; j < Columns1; j++)

                {
                    table3[i, j] = table1[j, i];
                    Console.WriteLine("t" + i + j + "=" + (table3[i, j]));
                }
            }
        }

        public static void Trace(int Rows1, int Columns1, double[,] table1)
        {
            if (Rows1 == Columns1)
            {
                // liczenie śladu
                int i = 0;
                int j = 0;
                int amount_added_count = 0;
                double value = 0;
                while (amount_added_count < Rows1)
                {
                    value += table1[i, j];
                    i++;
                    j++;
                    amount_added_count++;
                }

                Console.WriteLine("ślad wynosi: " + value);
            }
            else
            {
                Console.WriteLine("Macierz nie jest kwadratowa, więc nie da się policzyć jej śladu");
            }

        }

        public static void Multiplication_scalar(int Rows1, int Columns1, double[,] table1)
        {
            double[,] table3 = new double[Rows1, Columns1];
            //mnożenie macierzy przez skalar
            double a = Technical.Exceptions_handling.Exceptions_double_without_limits("Podaj skalar:");
            for (int i = 0; i < Rows1; i++)
            {
                for (int j = 0; j < Columns1; j++)
                {
                    table3[i, j] = table1[i, j] * a;
                    Console.WriteLine("c" + i + j + "=" + (table3[i, j]));
                }
            }
        }

        public static void Elementary_operations(int Rows1, int Columns1, double[,] table1)
        {
            double[,] table3 = new double[Rows1, Columns1];
            int choice_number1 = Technical.Exceptions_handling.Exceptions_int(0, 1,
                "Wybierz czy chcesz operować na: \n kolumnach- 0 \n wierszach 1 \n)");
            if (choice_number1 == 0)
            {
                Console.WriteLine("Wybrałeś operacje na kolumnach");
                int choice_number2 = Technical.Exceptions_handling.Exceptions_int(0, 3,
                    "Wybierz, czy chcesz: odejmować od siebie kolumny - 0 \n mnożyć kolumny przez skalar - 1 \n usunąć kolumnę - 2 \n zamienić miejscami kolumny - 3 \n");
                switch (choice_number2)
                {
                    case 1:
                        {
                            int column_number = Technical.Exceptions_handling.Exceptions_int(0, Columns1, "wybierz kolumnę");
                            double scalar = Technical.Exceptions_handling.Exceptions_double_without_limits("Podaj skalar:");

                            for (int i = 0; i < Rows1; i++)
                            {
                                for (int j = 0; j < Columns1; j++)
                                {
                                    table1[i, j] = table1[i, column_number] * scalar;
                                    Console.WriteLine("c" + i + j + "=" + (table1[i, j]));
                                }
                            }

                            break;
                        }
                    case 0:
                        {
                            int column1 = Technical.Exceptions_handling.Exceptions_int(0, Columns1,
                                "wybierz kolumnę do której będziesz dawał/odejmował inną kolumnę");
                            double scalar1 =
                                Technical.Exceptions_handling.Exceptions_double_without_limits(
                                    "Podaj skalar przez który mnożysz podaną kolumnę");
                            int choice_number3 = Technical.Exceptions_handling.Exceptions_int(0, 1,
                                "Wybiersz operację: dodawanie - 0 \n odejmowanie - 1 \n");
                            int column2 = Technical.Exceptions_handling.Exceptions_int(0, Columns1,
                                "wybierz kolumnę którą będziesz dodawał/odejmował");
                            double scalar2 =
                                Technical.Exceptions_handling.Exceptions_double_without_limits(
                                    "Podaj skalar przez który mnożysz podaną kolumnę");

                            for (int i = 0; i < Rows1; i++)
                            {
                                for (int j = 0; j < Columns1; j++)
                                {
                                    if (choice_number3 == 0)
                                    {
                                        table1[i, column1] = table1[i, column1] * scalar1 + table1[i, column2] * scalar2;
                                    }
                                    else if (choice_number3 == 1)
                                    {
                                        table1[i, column1] = table1[i, column1] * scalar1 - table1[i, column2] * scalar2;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Błędne dane");
                                    }

                                    Console.WriteLine("a" + i + j + "=" + (table1[i, j]));
                                }
                            }

                            break;
                        }
                    case 2:
                        {
                            int column =
                                Technical.Exceptions_handling.Exceptions_int(0, Columns1, "wybierz kolumnę którą chcesz usunąć");

                            int j = 0;
                            for (int i = 0; i < Rows1; i++)
                            {
                                if (j == column)
                                {
                                    j++;
                                }

                                for (j = 0; j < Columns1 - 1; j++)
                                {
                                    if (j < column)
                                    {
                                        table1[i, j] = table1[i, j];
                                    }
                                    else
                                    {
                                        table1[i, j] = table1[i, j + 1];
                                    }

                                    Console.WriteLine("a" + i + j + "=" + (table1[i, j]));
                                }
                            }

                            break;
                        }
                    case 3:
                        {
                            int column1 = Technical.Exceptions_handling.Exceptions_int(0, Columns1,
                                "wybierz numer pierwszej kolumny do zamiany");
                            int column2 = Technical.Exceptions_handling.Exceptions_int(0, Columns1,
                                "wybierz numer drugiej kolumny do zamiany");
                            for (int i = 0; i < Rows1; i++)
                            {
                                for (int j = 0; j < Columns1; j++)
                                {
                                    if ((column2 == j) && (column1 == j))
                                    {
                                        if (column2 == j)
                                        {
                                            table3[i, j] = table1[i, j];
                                            table1[i, j] = table1[i, column1];
                                        }
                                        else // k==j
                                        {
                                            table1[i, j] = table3[i, column2];
                                        }
                                    }

                                    Console.WriteLine("a" + i + j + "=" + (table1[i, j]));
                                }
                            }

                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Błędne dane");
                            break;
                        }
                }
            }
            else if (choice_number1 == 1)
            {
                Console.WriteLine("Wybrałęś operacje na wierszach");
                int choice_number2 = Technical.Exceptions_handling.Exceptions_int(0, 3,
                    "Wybierz, czy chcesz: odejmować od siebie wiersze - 0 \n mnożyć wiersze przez wiersze - 1 \n usunąć wiersz -2 \n zamienić miejscami wiersze - 3  \n");
                switch (choice_number2)
                {
                    case 1:
                        {
                            int row = Technical.Exceptions_handling.Exceptions_int(0, Rows1, "wybierz wiersz");
                            double scalar = Technical.Exceptions_handling.Exceptions_double_without_limits("Podaj skalar");

                            for (int i = 0; i < Rows1; i++)
                            {
                                for (int j = 0; j < Columns1; j++)
                                {
                                    table1[i, j] = table1[i, row] * scalar;
                                    Console.WriteLine("a" + i + j + "=" + (table1[i, j]));
                                }
                            }

                            break;
                        }
                    case 0:
                        {
                            int row1 = Technical.Exceptions_handling.Exceptions_int(0, Rows1,
                                "wybierz wiersz do której będziesz dodawał/odejmował inny wiersz ");
                            double scalar1 =
                                Technical.Exceptions_handling.Exceptions_double_without_limits(
                                    "Podaj skalar przez który mnożysz podany wiersz");
                            int choice_number3 = Technical.Exceptions_handling.Exceptions_int(0, 1,
                                "Wybiersz operację: dodawanie - 0 \n odejmowanie - 1 \n");
                            int row2 = Technical.Exceptions_handling.Exceptions_int(0, Rows1,
                                "wybierz wiersz który będziesz dodawał/odejmował");
                            double scalar2 =
                                Technical.Exceptions_handling.Exceptions_double_without_limits(
                                    "Podaj skalar przez który mnożysz podany wiersz");
                            for (int i = 0; i < Rows1; i++)
                            {
                                for (int j = 0; j < Columns1; j++)
                                {
                                    if (choice_number3 == 0)
                                    {
                                        table1[row1, j] = table1[row1, j] * scalar1 + table1[row2, j] * scalar2;
                                    }
                                    else if (choice_number3 == 1)
                                    {
                                        table1[row1, j] = table1[row1, j] * scalar1 - table1[row2, j] * scalar2;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Błędne dane");
                                    }

                                    Console.WriteLine("a" + i + j + "=" + (table1[i, j]));
                                }
                            }

                            break;
                        }
                    case 2:
                        {
                            int row = Technical.Exceptions_handling.Exceptions_int(0, Rows1, "wybierz wiersz który chcesz usunąć");

                            int i = 0;
                            if (i == row)
                            {
                                i++;
                            }

                            for (i = 0; i < Rows1 - 1; i++)
                            {
                                for (int j = 0; j < Columns1; j++)
                                {
                                    if (i < row)
                                    {
                                        table1[i, j] = table1[i, j];
                                    }
                                    else
                                    {
                                        table1[i, j] = table1[i + 1, j];
                                    }

                                    Console.WriteLine("a" + i + j + "=" + (table1[i, j]));
                                }
                            }

                            break;
                        }
                    case 3:
                        {
                            //zamiana miejscami wierszach
                            int row1 = Technical.Exceptions_handling.Exceptions_int(0, Rows1,
                                "wybierz numer pierwszego wiersza do zamiany");
                            int row2 = Technical.Exceptions_handling.Exceptions_int(0, Rows1,
                                "wybierz numer drugiego wiersza do zamiany");
                            for (int i = 0; i < Rows1; i++)
                            {
                                for (int j = 0; j < Columns1; j++)
                                {
                                    if ((row2 == j) && (row1 == j))
                                    {
                                        if (row2 == j)
                                        {
                                            table3[i, j] = table1[i, j];
                                            table1[i, j] = table1[row1, j];
                                        }
                                        else // k==j
                                        {
                                            table1[i, j] = table3[row2, i];
                                        }
                                    }

                                    Console.WriteLine("a" + i + j + "=" + (table1[i, j]));
                                }
                            }

                            break;
                        }
                    default:
                        {
                            Console.WriteLine("błędne dane");
                            break;
                        }
                }
            }
            else
            {
                Console.WriteLine("błędne dane");
            }
        }

        public static void Matrices_powering(int Rows1, int Columns1, double[,] table1)
        {
            if (Rows1 != Columns1)
            {
                Console.WriteLine("Macierz nie jest kwadratowa");
            }
            else
            {
                double[,] table3 = new double[Rows1, Columns1];
                // Potęgowanie macierzy
                int power = Technical.Exceptions_handling.Exceptions_uint_without_limits("Podaj potęgę: ");
                if (power == 0)
                {
                    Console.WriteLine("Value = 1");
                }
                else
                {
                    //ustawienie table3 jako macierzy jednostkowej
                    for (int i = 0; i < Rows1; i++)
                    {
                        for (int j = 0; j < Columns1; j++)
                        {
                            if (i == j)
                            {
                                table3[i, j] = 1;
                            }
                            else
                            {
                                table3[i, j] = 0;
                            }
                        }
                    }

                    int count = 0;
                    double[,] table0 = new double[Rows1, Columns1];
                    while (count < power)
                    {
                        for (int i = 0; i < Rows1; i++)
                        {
                            for (int j = 0; j < Columns1; j++)
                            {
                                for (int k = 0; k < Rows1; k++)
                                {
                                    table0[i, j] += table1[i, k] * table3[k, j];
                                }
                            }

                        }

                        for (int i = 0; i < Rows1; i++)
                        {
                            for (int j = 0; j < Columns1; j++)
                            {
                                table3[i, j] = table0[i, j];
                                table0[i, j] = 0;
                                if (count + 1 == power)
                                {
                                    //Ostatnia pętla - wypisywanie wartości docelowej macierzy table3
                                    Console.WriteLine("c" + i + j + "=" + (table3[i, j]));
                                }
                            }
                        }

                        count++;
                    }
                }
            }
        }

        public static void Matrices_characteristic(int Rows1, int Columns1, double[,] table1)
        {

            if (Rows1 == Columns1) //Czy jest kwadratowa?
            {
                // Jeśli jest kwadratowa
                Console.WriteLine("macierz jest kwadratowa \n");
                {
                    int Count = 0;
                    for (int i = 0; i < Rows1; i++)
                    {
                        for (int j = 0; j < Rows1; j++)
                        {
                            if (i == j)
                            {
                                if (table1[i, j] == 1)
                                    Count++;
                            }
                            else
                            {
                                if (table1[i, j] == 0)
                                    Count++;
                            }
                        }
                    }

                    if (Count == Rows1 * Columns1)
                    {
                        Console.WriteLine("macierz jest jednostkowa \n");
                    }
                }
                // Czy jest symetryczna
                {
                    int Count = 0;
                    for (int i = 0; i < Rows1; i++)
                    {
                        for (int j = 0; j < Rows1; j++)
                        {
                            if (table1[i, j] == table1[j, i])
                                Count++;
                        }
                    }

                    if (Count == Rows1 * Rows1)
                    {
                        Console.WriteLine("macierz jest symetryczna \n");
                    }
                }
                // Czy jest antysymetryczna
                {
                    int Count = 0;
                    for (int i = 0; i < Rows1; i++)
                    {
                        for (int j = 0; j < Rows1; j++)
                        {
                            if (table1[i, j] == -table1[j, i])
                                Count++;
                        }
                    }

                    if (Count == Rows1 * Rows1)
                    {
                        Console.WriteLine("macierz jest antysymetryczna \n");
                    }
                }
                // Czy jest diagonalna
                {
                    int Count = 0;
                    for (int i = 0; i < Rows1; i++)
                    {
                        for (int j = 0; j < Rows1; j++)
                        {
                            if (i != j)
                            {
                                if (table1[i, j] == 0)
                                    Count++;
                            }
                        }
                    }

                    if (Count == Rows1 * Rows1)
                    {
                        Console.WriteLine("macierz jest diagonalna \n");
                    }
                }
                // Czy jest dolna trójkątna
                {
                    int Count = 0;
                    for (int i = 0; i < Rows1; i++)
                    {
                        for (int j = 0; j < Rows1; j++)
                        {
                            if (i < j)
                            {
                                if (table1[i, j] == 0)
                                    Count++;
                            }
                            else
                            {
                                Count++;
                            }
                        }
                    }

                    if (Count == Rows1 * Rows1)
                    {
                        Console.WriteLine("macierz jest dolna trójkątna \n");
                    }
                }
                // Czy jest górna trójkątne
                {
                    int Count = 0;
                    for (int i = 0; i < Rows1; i++)
                    {
                        for (int j = 0; j < Rows1; j++)
                        {
                            if (i > j)
                            {
                                if (table1[i, j] == 0)
                                    Count++;
                            }
                            else
                            {
                                Count++;
                            }
                        }
                    }

                    if (Count == Rows1 * Rows1)
                    {
                        Console.WriteLine("macierz jest górna trójkątna \n");
                    }
                }
                // Czy jest ortogonalna?  A x AT=I (macierz razy jej transpozycja = jednostkowa)
                {
                    int Count = 0;
                    for (int i = 0; i < Rows1; i++)
                    {
                        for (int j = 0; j < Rows1; j++)
                        {
                            if (i == j)
                            {
                                if (table1[i, j] * table1[j, i] == 1)
                                    Count++;
                            }
                            else
                            {
                                if (table1[i, j] * table1[j, i] == 0)
                                    Count++;
                            }
                        }
                    }

                    if (Count == Rows1 * Rows1)
                    {
                        Console.WriteLine("macierz jest diagonalna \n");
                    }
                }
                // Czy jest stochastyczna
                {
                    bool right_stochastic_matrix()
                    {
                        double sum1 = 0;
                        double sum2 = 0;
                        for (int i = 0; i < Rows1; i++)
                        {
                            for (int j = 0; j < Rows1; j++)
                            {
                                if (i % 2 == 0)
                                {
                                    if (j == 0)
                                    {
                                        sum1 = 0;
                                    }
                                    sum1 += table1[i, j];
                                    if (i == 0 && j == Rows1 - 1)
                                    {
                                        sum2 = sum1;
                                    }
                                    if (sum1 != 1 && j == Rows1 - 1)
                                    {
                                        return false;
                                    }
                                }
                                else
                                {
                                    if (j == 0)
                                    {
                                        sum2 = 0;
                                    }
                                    sum2 += table1[i, j];
                                    if (sum2 != 1 && j == Rows1 - 1)
                                    {
                                        return false;
                                    }
                                }
                            }
                        }
                        return true;
                    }
                    bool left_stochastic_matrix()
                    {
                        double sum1 = 0;
                        double sum2 = 0;
                        for (int j = 0; j < Rows1; j++)
                        {
                            for (int i = 0; i < Rows1; i++)
                            {
                                if (j % 2 == 0)
                                {
                                    if (i == 0)
                                    {
                                        sum1 = 0;
                                    }
                                    sum1 += table1[i, j];
                                    if (j == 0 && i == Rows1 - 1)
                                    {
                                        sum2 = sum1;
                                    }
                                    if (sum1 != 1 && i == Rows1 - 1)
                                    {
                                        return false;
                                    }
                                }
                                else
                                {
                                    if (i == 0)
                                    {
                                        sum2 = 0;
                                    }
                                    sum2 += table1[i, j];
                                    if (sum2 != 1 && i == Rows1 - 1)
                                    {
                                        return false;
                                    }
                                }
                            }
                        }
                        return true;
                    }
                    if (right_stochastic_matrix() == true && left_stochastic_matrix() == true)
                    {
                        Console.WriteLine("Jest to macierz stochastyczna podwójna. \n");
                    }
                    else if (left_stochastic_matrix() == true)
                    {
                        Console.WriteLine("Jest to macierz stochastyczna lewa. \n");
                    }
                    else if (right_stochastic_matrix() == true)
                    {
                        Console.WriteLine("Jest to macierz stochastyczna prawa. \n");
                    }
                }
                //kwadrat magiczny
                {
                    bool comparing_row_sums()
                    {
                        double sum1 = 0;
                        double sum2 = 0;
                        for (int i = 0; i < Rows1; i++)
                        {
                            for (int j = 0; j < Rows1; j++)
                            {
                                // if row is even
                                if (i % 2 == 0)
                                {
                                    if (j == 0)
                                    {// Nullifying the previous sum1
                                        sum1 = 0;
                                    }
                                    // Adding cells of given row
                                    sum1 += table1[i, j];
                                    if (i == 0 && j == Rows1 - 1)
                                    {
                                        sum2 = sum1;
                                    }
                                    // when all row was summed checking if it has the same value as the previous one
                                    if (sum1 != sum2 && j == Rows1 - 1)
                                    {
                                        return false;
                                    }
                                }
                                else
                                {
                                    if (j == 0)
                                    {
                                        sum2 = 0;
                                    }
                                    sum2 += table1[i, j];
                                    if (sum1 != sum2 && j == Rows1 - 1)
                                    {
                                        return false;
                                    }
                                }
                            }
                        }
                        return true;
                    }
                    bool comparing_column_sums()
                    {
                        double sum1 = 0;
                        double sum2 = 0;
                        for (int j = 0; j < Rows1; j++)
                        {
                            for (int i = 0; i < Rows1; i++)
                            {
                                // if row is even columns
                                if (j % 2 == 0)
                                {
                                    if (i == 0)
                                    {// Nullifying the previous sum1
                                        sum1 = 0;
                                    }
                                    // Adding cells of given row
                                    sum1 += table1[i, j];
                                    if (j == 0 && i == Rows1 - 1)
                                    {
                                        sum2 = sum1;
                                    }
                                    // when all row was summed checking if it has the same value as the previous one
                                    if (sum1 != sum2 && i == Rows1 - 1)
                                    {
                                        return false;
                                    }
                                }
                                else
                                {
                                    if (i == 0)
                                    {
                                        sum2 = 0;
                                    }
                                    sum2 += table1[i, j];
                                    if (sum1 != sum2 && i == Rows1 - 1)
                                    {
                                        return false;
                                    }
                                }
                            }
                        }
                        return true;
                    }
                    bool comparing_diagonal_sums()
                    {
                        double sum1 = 0;
                        double sum2 = 0;
                        for (int i = 0; i < Rows1; i++)
                        {
                            for (int j = 0; j < Rows1; j++)
                            {
                                if (i == j)
                                {
                                    sum1 += table1[i, j];
                                    if (i == Rows1 - 1 && j == Rows1 - 1)
                                    {
                                        if (sum1 != sum2)
                                        {
                                            return false;
                                        }
                                    }
                                }
                                if (i + j == Rows1 - 1)
                                {
                                    sum2 += table1[i, j];
                                }
                            }
                        }
                        return true;
                    }
                    if (comparing_row_sums() == true && comparing_column_sums() == true && comparing_diagonal_sums() == true)
                    {
                        Console.WriteLine("Jest to kwadrat magiczny. \n");
                    }
                    else
                    {
                        Console.WriteLine("NIe jest to kwadrat magiczny. \n");
                    }
                }
            }
            // miejsce na kolejne metody charakterystyki macierzy kwadratowych

            // charakterystyki dotyczące macierzy niekwadratowych
            {
                // Macierz rzadka (większość elementów = 0)
                {
                    int Count = 0;
                    for (int i = 0; i < Rows1; i++)
                    {
                        for (int j = 0; j < Columns1; j++)
                        {
                            if (table1[i, j] == 0)
                            {
                                Count++;
                            }
                        }
                    }

                    if (2 * Count > Rows1 * Columns1)
                    {
                        Console.WriteLine("macierz jest rzadka \n");
                    }
                }
                // Czy macierzą zerową
                {
                    int Count = 0;
                    for (int i = 0; i < Rows1; i++)
                    {
                        for (int j = 0; j < Columns1; j++)
                        {
                            if (table1[i, j] == 0)
                            {
                                Count++;
                            }
                        }
                    }

                    if (Count == Rows1 * Columns1)
                    {
                        Console.WriteLine("macierz jest zerowa \n");
                    }
                }
            }
            Console.ReadLine();
        }

    }
}
