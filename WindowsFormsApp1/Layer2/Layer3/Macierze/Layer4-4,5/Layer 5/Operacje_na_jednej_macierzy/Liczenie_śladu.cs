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
    public partial class Liczenie_śladu : Form
    {
        public Liczenie_śladu()
        {
            InitializeComponent();
        }

        private void Liczenie_śladu_Load(object sender, EventArgs e)
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
    }
}
