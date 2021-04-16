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
    public partial class Funkcja_kwadratowa_Form : Form
    {
        public Funkcja_kwadratowa_Form()
        {
            InitializeComponent();
        }

        private void Funkcja_kwadratowa_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Artmetyka openForm = new Artmetyka();
            openForm.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //reset
        }
    }
}
