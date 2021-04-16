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
    public partial class Koło_Form : Form
    {
        public Koło_Form()
        {
            InitializeComponent();
        }

        Koło koło = new Koło();

        private void Zatwierdź_Click(object sender, EventArgs e)
        {
            koło.Promień = Program.Exceptions_double_without_limits(maskedTextBox1.Text);
            koło.Pole = Program.Exceptions_double_without_limits(maskedTextBox2.Text);
            koło.Obwód = Program.Exceptions_double_without_limits(maskedTextBox3.Text);

            Koło.Wylicz_dane(koło);

            textBox1.Text = Convert.ToString(Math.Round(koło.Promień, 3));
            textBox2.Text = Convert.ToString(Math.Round(koło.Pole, 3));
            textBox3.Text = Convert.ToString(Math.Round(koło.Obwód, 3));

            // MessageBox.Show(koło_obiekt.Obwód.ToString());//0
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Figury_2D openForm = new Figury_2D();
            openForm.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;

            maskedTextBox1.Text = null;
            maskedTextBox2.Text = null;
            maskedTextBox3.Text = null;


        }
    }
    class Koło
    {
        public double Promień;
        public double Pole;
        public double Obwód;

        public Koło()
        {

        }

        public static void Wylicz_dane(Koło koło)
        {
            for (int i = 0; i < 2; i++)
            {
                koło.Pole = Math.Max(Math.PI * koło.Promień * koło.Promień, koło.Pole);
                koło.Obwód = Math.Max(2 * Math.PI * koło.Promień, koło.Obwód);
                koło.Promień = Math.Max(Math.Sqrt(koło.Pole / Math.PI), koło.Obwód / (2 * Math.PI));
            }
        }
    }
}
