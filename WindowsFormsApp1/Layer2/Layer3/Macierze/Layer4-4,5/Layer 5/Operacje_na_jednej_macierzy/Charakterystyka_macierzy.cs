using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Charakterystyka_macierzy : Form
    {
        public Charakterystyka_macierzy()
        {
            InitializeComponent();
        }

        private void Charakterystyka_macierzy_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Layer3.Macierze.Layer4_4_5.Layer_5.Operacje_na_jednej_macierzy_Form openForm = new Layer3.Macierze.Layer4_4_5.Layer_5.Operacje_na_jednej_macierzy_Form();
            openForm.Show();
            Visible = false;
        }
    }
    partial class Single_matrix_operations
    {
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
