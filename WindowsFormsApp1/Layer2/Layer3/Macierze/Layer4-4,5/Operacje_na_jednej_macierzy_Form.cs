using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Layer3.Macierze.Layer4_4_5.Layer_5
{
    public partial class Operacje_na_jednej_macierzy_Form : Form
    {
        public Operacje_na_jednej_macierzy_Form()
        {
            InitializeComponent();
        }

        private void Liczenie_wyznacznika_Click(object sender, EventArgs e)
        {
            Liczenie_wyznacznika openForm = new Liczenie_wyznacznika();
            openForm.Show();
            Visible = false;
        }

        private void Transpozycja_Click(object sender, EventArgs e)
        {
            Transpozycja openForm = new Transpozycja();
            openForm.Show();
            Visible = false;
        }

        private void Liczenie_śladu_Click(object sender, EventArgs e)
        {
            Liczenie_śladu openForm = new Liczenie_śladu();
            openForm.Show();
            Visible = false;
        }

        private void Mnożenie_macierzy_przez_skalar_Click(object sender, EventArgs e)
        {
            Mnożenie_macierzy_przez_skalar openForm = new Mnożenie_macierzy_przez_skalar();
            openForm.Show();
            Visible = false;
        }

        private void Operacje_elementarne_Click(object sender, EventArgs e)
        {
            Operacje_elementarne openForm = new Operacje_elementarne();
            openForm.Show();
            Visible = false;
        }

        private void Liczenie_macierzy_odwrotnej_Click(object sender, EventArgs e)
        {
            Liczenie_macierzy_odwrotnej openForm = new Liczenie_macierzy_odwrotnej();
            openForm.Show();
            Visible = false;
        }

        private void Charakterystyka_macierzy_Click(object sender, EventArgs e)
        {
            Charakterystyka_macierzy openForm = new Charakterystyka_macierzy();
            openForm.Show();
            Visible = false;
        }

        private void Potęgowanie_macierzy_Click(object sender, EventArgs e)
        {
            Potęgowanie_macierzy openForm = new Potęgowanie_macierzy();
            openForm.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deklaracja_pierwszej_macierzy openForm = new Deklaracja_pierwszej_macierzy();
            openForm.Show();
            Visible = false;
        }
    }
}
