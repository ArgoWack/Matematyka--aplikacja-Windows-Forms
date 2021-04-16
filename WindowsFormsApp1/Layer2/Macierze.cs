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
    public partial class Macierze : Form
    {
        public Macierze()
        {
            InitializeComponent();
        }

        public static bool Czy_2_macierze = false;

        private void Jedna_macierz_Click(object sender, EventArgs e)
        {
            Deklaracja_pierwszej_macierzy openForm = new Deklaracja_pierwszej_macierzy();
            openForm.Show();
            Visible = false;
        }

        private void Dwie_macierze_Click(object sender, EventArgs e)
        {
            Czy_2_macierze = true;
            Deklaracja_pierwszej_macierzy openForm = new Deklaracja_pierwszej_macierzy();
            openForm.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main_Menu openForm = new Main_Menu();
            openForm.Show();
            Visible = false;
        }
    }
}
