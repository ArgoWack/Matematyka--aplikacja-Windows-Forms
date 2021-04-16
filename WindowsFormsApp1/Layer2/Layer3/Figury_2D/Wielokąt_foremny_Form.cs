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
    public partial class Wielokąt_foremny_Form : Form
    {
        public Wielokąt_foremny_Form()
        {
            InitializeComponent();
        }

        private void Wielokąt_foremny_Load(object sender, EventArgs e)
        {

        }

        Wielokąt_foremny wielokąt_foremny = new Wielokąt_foremny();

        private void button1_Click(object sender, EventArgs e)
        {
            wielokąt_foremny.Bok = Program.Exceptions_double_without_limits(richTextBox1.Text);
            wielokąt_foremny.Ilość_boków = Program.Exceptions_double_without_limits(richTextBox2.Text);
            wielokąt_foremny.Promień_okręgu_wpisanego = Program.Exceptions_double_without_limits(richTextBox3.Text);

            wielokąt_foremny.Promień_okręgu_opisanego = Program.Exceptions_double_without_limits(richTextBox4.Text);
            wielokąt_foremny.Suma_miar_kątów_wewnętrznych = Program.Exceptions_double_without_limits(richTextBox5.Text);
            wielokąt_foremny.Pole = Program.Exceptions_double_without_limits(richTextBox6.Text);

            wielokąt_foremny.Obwód = Program.Exceptions_double_without_limits(richTextBox7.Text);


            Wielokąt_foremny.Wylicz_dane(wielokąt_foremny);

            richTextBox8.Text = Convert.ToString(Math.Round(wielokąt_foremny.Bok, 3));
            richTextBox9.Text = Convert.ToString(Math.Round(wielokąt_foremny.Ilość_boków, 3));
            richTextBox10.Text = Convert.ToString(Math.Round(wielokąt_foremny.Promień_okręgu_wpisanego, 3));
            richTextBox11.Text = Convert.ToString(Math.Round(wielokąt_foremny.Promień_okręgu_opisanego, 3));
            richTextBox12.Text = Convert.ToString(Math.Round(wielokąt_foremny.Suma_miar_kątów_wewnętrznych, 3));
            richTextBox13.Text = Convert.ToString(Math.Round(wielokąt_foremny.Pole, 3));
            richTextBox14.Text = Convert.ToString(Math.Round(wielokąt_foremny.Obwód, 3));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Figury_2D openForm = new Figury_2D();
            openForm.Show();
            Visible = false;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
            richTextBox2.Text = null;
            richTextBox3.Text = null;

            richTextBox4.Text = null;
            richTextBox5.Text = null;
            richTextBox6.Text = null;

            richTextBox7.Text = null;
            richTextBox8.Text = null;
            richTextBox9.Text = null;

            richTextBox10.Text = null;
            richTextBox11.Text = null;
            richTextBox12.Text = null;

            richTextBox13.Text = null;
            richTextBox14.Text = null;
        }
    }


    class Wielokąt_foremny
    {
        public double Bok;//a
        public double Promień_okręgu_wpisanego;//r
        public double Promień_okręgu_opisanego;//R
        public double Pole;
        public double Obwód;
        public double Ilość_boków;//n
        public double Kąt;
        public double Suma_miar_kątów_wewnętrznych;

        public Wielokąt_foremny()
        {

        }
        public Wielokąt_foremny(double Bok, double Promień_okręgu_wpisanego, double Promień_okręgu_opisanego, double Pole, double Obwód, double Kąt,
            double Ilość_ścian, double Suma_miar_kątów_wewnętrznych)
        {
            this.Bok = Bok;
            this.Promień_okręgu_wpisanego = Promień_okręgu_wpisanego;
            this.Promień_okręgu_opisanego = Promień_okręgu_opisanego;
            this.Pole = Pole;
            this.Obwód = Obwód;
            this.Kąt = Kąt;
            this.Ilość_boków = Ilość_boków;
            this.Suma_miar_kątów_wewnętrznych = Suma_miar_kątów_wewnętrznych;
        }

        public static void Wylicz_dane(Wielokąt_foremny wielokąt_foremny)
        {
            for (int i = 0; i < 2; i++)
            {
                double cotangens = 1 / Math.Tan(wielokąt_foremny.Ilość_boków);
                //public double Kąt;
                //public double Suma_miar_kątów_wewnętrznych;
                wielokąt_foremny.Suma_miar_kątów_wewnętrznych = Math.Max(wielokąt_foremny.Suma_miar_kątów_wewnętrznych, (wielokąt_foremny.Ilość_boków - 2) * 180);

                wielokąt_foremny.Kąt = Math.Max(wielokąt_foremny.Kąt, Matematyka.Technical.Other_Methods.NULL_INFINITY(360 / wielokąt_foremny.Ilość_boków));

                wielokąt_foremny.Ilość_boków = Math.Max(wielokąt_foremny.Ilość_boków, Matematyka.Technical.Other_Methods.NULL_INFINITY(360 / wielokąt_foremny.Kąt));

                wielokąt_foremny.Obwód = Math.Max(wielokąt_foremny.Obwód, wielokąt_foremny.Ilość_boków * wielokąt_foremny.Bok);

                //Bok - a
                List<double> BOK = new List<double>();
                BOK.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(wielokąt_foremny.Bok));
                BOK.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(2 * Math.Sqrt(wielokąt_foremny.Pole / (wielokąt_foremny.Ilość_boków * cotangens))));
                BOK.Sort();
                BOK.Reverse();
                wielokąt_foremny.Bok = BOK[0];

                //Promień_okręgu_wpisanego - r
                List<double> PROMIEŃ_OKRĘGU_WPISANEGO = new List<double>();
                PROMIEŃ_OKRĘGU_WPISANEGO.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(wielokąt_foremny.Promień_okręgu_wpisanego));
                PROMIEŃ_OKRĘGU_WPISANEGO.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY((wielokąt_foremny.Bok / 2) * cotangens));
                PROMIEŃ_OKRĘGU_WPISANEGO.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(2 * wielokąt_foremny.Pole / (wielokąt_foremny.Ilość_boków * wielokąt_foremny.Bok)));
                PROMIEŃ_OKRĘGU_WPISANEGO.Sort();
                PROMIEŃ_OKRĘGU_WPISANEGO.Reverse();
                wielokąt_foremny.Promień_okręgu_wpisanego = PROMIEŃ_OKRĘGU_WPISANEGO[0];

                //Promień_okręgu_opisanego - R
                List<double> PROMIEŃ_OKRĘGU_OPISANEGO = new List<double>();
                PROMIEŃ_OKRĘGU_OPISANEGO.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(wielokąt_foremny.Promień_okręgu_opisanego));
                PROMIEŃ_OKRĘGU_OPISANEGO.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(wielokąt_foremny.Bok / (2 * Math.Sin(Matematyka.Technical.Other_Methods.Kąt_na_radiany(Math.PI / wielokąt_foremny.Ilość_boków)))));
                PROMIEŃ_OKRĘGU_OPISANEGO.Sort();
                PROMIEŃ_OKRĘGU_OPISANEGO.Reverse();
                wielokąt_foremny.Promień_okręgu_opisanego = PROMIEŃ_OKRĘGU_OPISANEGO[0];


                List<double> POLE = new List<double>();
                POLE.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(wielokąt_foremny.Pole));
                //cotangens=Math.PI/2 - Math.Atan(x)
                POLE.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY((wielokąt_foremny.Ilość_boków / 4) * Math.Pow(wielokąt_foremny.Bok, 2) * (cotangens)));
                POLE.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(wielokąt_foremny.Ilość_boków / 4) * wielokąt_foremny.Bok *
                         Math.Sqrt(4 * Math.Pow(wielokąt_foremny.Promień_okręgu_opisanego, 2) - Math.Pow(wielokąt_foremny.Bok, 2)));
                POLE.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(wielokąt_foremny.Ilość_boków / (2 * wielokąt_foremny.Bok * wielokąt_foremny.Promień_okręgu_wpisanego)));
                POLE.Sort();
                POLE.Reverse();
                wielokąt_foremny.Pole = POLE[0];
            }
        }
    }
}
