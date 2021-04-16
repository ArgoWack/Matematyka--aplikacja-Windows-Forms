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
    public partial class Artmetyka : Form
    {
        public Artmetyka()
        {
            InitializeComponent();
        }

        private void NWD_NWW_Click(object sender, EventArgs e)
        {
            NWW_NWD_Form openForm = new NWW_NWD_Form();
            openForm.Show();
            Visible = false;
        }

        private void Dzielenie_z_resztą_Click(object sender, EventArgs e)
        {
            Dzielenie_z_resztą_Form openForm = new Dzielenie_z_resztą_Form();
            openForm.Show();
            Visible = false;
        }

        private void Funkcja_liniowa_Click(object sender, EventArgs e)
        {
            Funkcja_liniowa_Form openForm = new Funkcja_liniowa_Form();
            openForm.Show();
            Visible = false;
        }

        private void Funkcja_kwadratowa_Click(object sender, EventArgs e)
        {
            Funkcja_kwadratowa_Form openForm = new Funkcja_kwadratowa_Form();
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
