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
    public partial class Mnożenie_macierzy_przez_skalar : Form
    {
        public Mnożenie_macierzy_przez_skalar()
        {
            InitializeComponent();
        }

        private void Mnożenie_macierzy_przez_skalar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Skalar;
            Skalar = Program.Exceptions_double_without_limits(textBox1.Text);


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
        public static void Multiplication_scalar(int Rows1, int Columns1, double[,] table1)
        {
            double[,] table3 = new double[Rows1, Columns1];
            //mnożenie macierzy przez skalar
            double a = Matematyka.Technical.Exceptions_handling.Exceptions_double_without_limits("Podaj skalar:");
            for (int i = 0; i < Rows1; i++)
            {
                for (int j = 0; j < Columns1; j++)
                {
                    table3[i, j] = table1[i, j] * a;
                    Console.WriteLine("c" + i + j + "=" + (table3[i, j]));
                }
            }
        }
    }
}
