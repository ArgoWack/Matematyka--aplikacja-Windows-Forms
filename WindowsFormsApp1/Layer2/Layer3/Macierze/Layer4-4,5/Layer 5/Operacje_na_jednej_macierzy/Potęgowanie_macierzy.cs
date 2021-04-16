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
    public partial class Potęgowanie_macierzy : Form
    {
        public Potęgowanie_macierzy()
        {
            InitializeComponent();
        }

        private void Potęgowanie_macierzy_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Potęga;
            Potęga=Program.Exceptions_double_without_limits(textBox1.Text);

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
                int power = Matematyka.Technical.Exceptions_handling.Exceptions_uint_without_limits("Podaj potęgę: ");
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
    }
}
