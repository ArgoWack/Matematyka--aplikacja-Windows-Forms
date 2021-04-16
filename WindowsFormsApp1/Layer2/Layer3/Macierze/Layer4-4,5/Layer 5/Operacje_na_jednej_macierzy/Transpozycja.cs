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
    public partial class Transpozycja : Form
    {
        public Transpozycja()
        {
            InitializeComponent();
        }

        private void Transpozycja_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {//zatwierdź

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
    }
}
