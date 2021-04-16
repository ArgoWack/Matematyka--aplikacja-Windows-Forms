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
    public partial class Operacje_na_dwóch_macierzach_Form : Form
    {
        public Operacje_na_dwóch_macierzach_Form()
        {
            InitializeComponent();
        }

        private void Odejmowanie_Click(object sender, EventArgs e)
        {
            Odejmowanie openForm = new Odejmowanie();
            openForm.Show();
            Visible = false;
        }

        private void Dodawanie_Click(object sender, EventArgs e)
        {
            Dodawanie openForm = new Dodawanie();
            openForm.Show();
            Visible = false;
        }

        private void Mnożenie_Click(object sender, EventArgs e)
        {
            Mnożenie openForm = new Mnożenie();
            openForm.Show();
            Visible = false;
        }

        private void Iloczyn_Hadamarda_Click(object sender, EventArgs e)
        {
            Iloczyn_Hadamarda openForm = new Iloczyn_Hadamarda();
            openForm.Show();
            Visible = false;
        }

        private void Iloczyn_Kroneckera_Click(object sender, EventArgs e)
        {
            Iloczyn_Kroneckera openForm = new Iloczyn_Kroneckera();
            openForm.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deklaracja_drugiej_macierzy openForm = new Deklaracja_drugiej_macierzy();
            openForm.Show();
            Visible = false;
        }
    }
}
