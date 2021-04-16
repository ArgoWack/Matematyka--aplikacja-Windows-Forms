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
    public partial class Deklaracja_drugiej_macierzy : Form
    {
        public Deklaracja_drugiej_macierzy()
        {
            InitializeComponent();
        }

        private void Zatwierdź_Click(object sender, EventArgs e)
        {
            double Rzędy2, Kolumny2;

            Rzędy2 = Program.Exceptions_double_without_limits(textBox1.Text);
            Kolumny2 = Program.Exceptions_double_without_limits(textBox2.Text);

            //tworzenie tabeli, po czym wprowadzanie jej wartosci

            Layer3.Macierze.Layer4_4_5.Layer_5.Operacje_na_dwóch_macierzach_Form openForm = new Layer3.Macierze.Layer4_4_5.Layer_5.Operacje_na_dwóch_macierzach_Form();
            openForm.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deklaracja_pierwszej_macierzy openForm = new Deklaracja_pierwszej_macierzy();
            openForm.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //reset
        }
    }
}
