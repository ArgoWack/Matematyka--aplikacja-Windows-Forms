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
    public partial class Dodawanie : Form
    {
        public Dodawanie()
        {
            InitializeComponent();
        }

        private void Dodawanie_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Layer3.Macierze.Layer4_4_5.Layer_5.Operacje_na_dwóch_macierzach_Form openForm = new Layer3.Macierze.Layer4_4_5.Layer_5.Operacje_na_dwóch_macierzach_Form();
            openForm.Show();
            Visible = false;
        }
    }
}
