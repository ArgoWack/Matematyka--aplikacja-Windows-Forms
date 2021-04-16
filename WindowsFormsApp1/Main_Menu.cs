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
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Figury_2D openForm= new Figury_2D();
            openForm.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Figury_3D openForm = new Figury_3D();
            openForm.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Artmetyka openForm = new Artmetyka();
            openForm.Show();
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Macierze openForm = new Macierze();
            openForm.Show();
            Visible = false;
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
