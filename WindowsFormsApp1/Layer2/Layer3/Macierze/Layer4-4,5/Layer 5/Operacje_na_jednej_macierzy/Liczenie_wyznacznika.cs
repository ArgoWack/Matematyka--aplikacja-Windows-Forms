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
    public partial class Liczenie_wyznacznika : Form
    {
        public Liczenie_wyznacznika()
        {
            InitializeComponent();
        }

        private void Liczenie_wyznacznika_Load(object sender, EventArgs e)
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
    }
}
