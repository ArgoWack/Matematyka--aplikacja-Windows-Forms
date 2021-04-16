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
    public partial class Figury_2D : Form
    {
        public Figury_2D()
        {
            InitializeComponent();
        }

        private void Koło_Click(object sender, EventArgs e)
        {
            Koło_Form openForm = new Koło_Form();
            openForm.Show();
            Visible = false;
        }

        private void Trójkąt_Click(object sender, EventArgs e)
        {
            Trójkąt_Form openForm = new Trójkąt_Form();
            openForm.Show();
            Visible = false;
        }

        private void Czworokąt_Click(object sender, EventArgs e)
        {
            Czworokąt_Form openForm = new Czworokąt_Form();
            openForm.Show();
            Visible = false;
        }

        private void Wielokąt_foremny_Click(object sender, EventArgs e)
        {
            Wielokąt_foremny_Form openForm = new Wielokąt_foremny_Form();
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
