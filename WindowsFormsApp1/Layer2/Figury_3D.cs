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
    public partial class Figury_3D : Form
    {
        public Figury_3D()
        {
            InitializeComponent();
        }

        private void Kula_Click(object sender, EventArgs e)
        {
            Kula_Form openForm = new Kula_Form();
            openForm.Show();
            Visible = false;
        }

        private void Prostopadłościan_Click(object sender, EventArgs e)
        {
            Prostopadłościan_Form openForm = new Prostopadłościan_Form();
            openForm.Show();
            Visible = false;
        }

        private void Ostrosłup_Click(object sender, EventArgs e)
        {
            Ostrosłup_Form openForm = new Ostrosłup_Form();
            openForm.Show();
            Visible = false;
        }

        private void Stożek_Click(object sender, EventArgs e)
        {
            Stożek_Form openForm = new Stożek_Form();
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
