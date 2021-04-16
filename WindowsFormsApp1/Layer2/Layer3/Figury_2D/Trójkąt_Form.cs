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
    public partial class Trójkąt_Form : Form
    {
        public Trójkąt_Form()
        {
            InitializeComponent();
        }


        Trójkąt trójkąt = new Trójkąt();

        private void button1_Click(object sender, EventArgs e)
        {
            trójkąt.Bok1= Program.Exceptions_double_without_limits(richTextBox1.Text);
            trójkąt.Bok2= Program.Exceptions_double_without_limits(richTextBox2.Text);
            trójkąt.Bok3= Program.Exceptions_double_without_limits(richTextBox3.Text);

            trójkąt.Wysokość1= Program.Exceptions_double_without_limits(richTextBox4.Text);
            trójkąt.Wysokość2= Program.Exceptions_double_without_limits(richTextBox5.Text);
            trójkąt.Wysokość3= Program.Exceptions_double_without_limits(richTextBox6.Text);

            trójkąt.Kąt12= Program.Exceptions_double_without_limits(richTextBox7.Text);
            trójkąt.Kąt13= Program.Exceptions_double_without_limits(richTextBox8.Text);
            trójkąt.Kąt23=Program.Exceptions_double_without_limits(richTextBox9.Text);

            trójkąt.Obwód= Program.Exceptions_double_without_limits(richTextBox10.Text);
            trójkąt.Pole= Program.Exceptions_double_without_limits(richTextBox11.Text);
            
            Trójkąt.Wylicz_dane(trójkąt);

            richTextBox12.Text = Convert.ToString(Math.Round(trójkąt.Bok1, 3));
            richTextBox13.Text = Convert.ToString(Math.Round(trójkąt.Bok2, 3));
            richTextBox14.Text = Convert.ToString(Math.Round(trójkąt.Bok3, 3));
            richTextBox15.Text = Convert.ToString(Math.Round(trójkąt.Wysokość1, 3));
            richTextBox16.Text = Convert.ToString(Math.Round(trójkąt.Wysokość2, 3));
            richTextBox17.Text = Convert.ToString(Math.Round(trójkąt.Wysokość3, 3));
            richTextBox18.Text = Convert.ToString(Math.Round(trójkąt.Kąt12, 3));
            richTextBox19.Text = Convert.ToString(Math.Round(trójkąt.Kąt13, 3));
            richTextBox20.Text = Convert.ToString(Math.Round(trójkąt.Kąt23, 3));
            richTextBox21.Text = Convert.ToString(Math.Round(trójkąt.Pole, 3));
            richTextBox22.Text = Convert.ToString(Math.Round(trójkąt.Obwód, 3));

            richTextBox23.Text = null;

            if (trójkąt.Kąt12 == trójkąt.Kąt13 || trójkąt.Kąt12 == trójkąt.Kąt23 || trójkąt.Kąt13 == trójkąt.Kąt23)
            {
                richTextBox23.Text+="Jest to trójkąt równoramienny \n";
            }
            if (trójkąt.Kąt12 == 60 && trójkąt.Kąt13 == 60 && trójkąt.Kąt23 == 60)
            {
                richTextBox23.Text += "Jest to trójkąt równoboczny \n";
            }
            if (trójkąt.Kąt12 < 90 && trójkąt.Kąt13 < 90 && trójkąt.Kąt23 < 90)
            {
                richTextBox23.Text += "Jest to trójkąt ostrokątny \n";
            }
            if (trójkąt.Kąt12 == 90 || trójkąt.Kąt13 == 90 || trójkąt.Kąt23 == 90)
            {
                richTextBox23.Text += "Jest to trójkąt prostokątny \n";
            }
            if (trójkąt.Kąt12 > 90 || trójkąt.Kąt13 > 90 || trójkąt.Kąt23 > 90)
            {
                richTextBox23.Text += "Jest to trójkąt rozwartokątny \n";
            }
            for (int i = 1; i < 100; i++)
            {
                if ((trójkąt.Bok1 == 3 * i || trójkąt.Bok2 == 3 * i || trójkąt.Bok3 == 3 * i) && (trójkąt.Bok1 == 4 * i || trójkąt.Bok2 == 4 * i || trójkąt.Bok3 == 4 * i)
                                                                                  && (trójkąt.Bok1 == 5 * i || trójkąt.Bok2 == 5 * i || trójkąt.Bok3 == 5 * i))
                {
                    richTextBox23.Text += "Jest to trójkąt egipski \n";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Figury_2D openForm = new Figury_2D();
            openForm.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text=null;
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

            richTextBox15.Text = null;
            richTextBox16.Text = null;
            richTextBox17.Text = null;

            richTextBox18.Text = null;
            richTextBox19.Text = null;
            richTextBox20.Text = null;

            richTextBox21.Text = null;
            richTextBox22.Text = null;

            richTextBox23.Text = null;
        }
    }

    class Trójkąt
    {


        // zmienne
        public double Bok1;
        public double Bok2;
        public double Bok3;
        public double Wysokość1;
        public double Wysokość2;
        public double Wysokość3;
        public double Kąt12;
        public double Kąt13;
        public double Kąt23;
        public double Obwód;
        public double Pole;
        public Trójkąt()
        {
        }

        public static void Wylicz_dane(Trójkąt trójkąt_obiekt)
        {

            for (int i = 0; i < 2; i++)
            {

                List<double> BOK1 = new List<double>();
                BOK1.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(trójkąt_obiekt.Bok1));
                BOK1.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(trójkąt_obiekt.Pole * 2 / trójkąt_obiekt.Wysokość1));
                if (trójkąt_obiekt.Kąt12 != 0)
                {
                    BOK1.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(trójkąt_obiekt.Pole * 2 / (trójkąt_obiekt.Bok2 * Math.Sin(Matematyka.Technical.Other_Methods.Kąt_na_radiany(trójkąt_obiekt.Kąt12)))));
                }
                if (trójkąt_obiekt.Kąt13 != 0)
                {
                    BOK1.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(trójkąt_obiekt.Pole * 2 / (trójkąt_obiekt.Bok3 * Math.Sin(Matematyka.Technical.Other_Methods.Kąt_na_radiany(trójkąt_obiekt.Kąt13)))));
                }
                if (trójkąt_obiekt.Kąt13 == trójkąt_obiekt.Kąt23 && Matematyka.Technical.Other_Methods.If_not_zero_of_two(trójkąt_obiekt.Kąt13, trójkąt_obiekt.Kąt23))
                {
                    BOK1.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(trójkąt_obiekt.Bok2));
                }
                if (trójkąt_obiekt.Kąt12 == trójkąt_obiekt.Kąt23 && Matematyka.Technical.Other_Methods.If_not_zero_of_two(trójkąt_obiekt.Kąt12, trójkąt_obiekt.Kąt23))
                {
                    BOK1.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(trójkąt_obiekt.Bok3));
                }
                if (trójkąt_obiekt.Kąt12 == 60 && trójkąt_obiekt.Kąt13 == 60 && trójkąt_obiekt.Kąt23 == 60)
                {
                    BOK1.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(trójkąt_obiekt.Bok2));
                    BOK1.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(trójkąt_obiekt.Bok3));
                    BOK1.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(2 * Math.Sqrt(trójkąt_obiekt.Pole / Math.Sqrt(3))));
                }
                BOK1.Sort();
                BOK1.Reverse();
                trójkąt_obiekt.Bok1 = BOK1[0];

                List<double> BOK2 = new List<double>();
                BOK2.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(trójkąt_obiekt.Bok2));
                BOK2.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(trójkąt_obiekt.Pole * 2 / trójkąt_obiekt.Wysokość2));
                if (trójkąt_obiekt.Kąt12 != 0)
                {
                    BOK2.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(trójkąt_obiekt.Pole * 2 / (trójkąt_obiekt.Bok1 * Math.Sin(Matematyka.Technical.Other_Methods.Kąt_na_radiany(trójkąt_obiekt.Kąt12)))));
                }
                if (trójkąt_obiekt.Kąt23 != 0)
                {
                    BOK2.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(trójkąt_obiekt.Pole * 2 / (trójkąt_obiekt.Bok3 * Math.Sin(Matematyka.Technical.Other_Methods.Kąt_na_radiany(trójkąt_obiekt.Kąt23)))));
                }
                if (trójkąt_obiekt.Kąt12 == trójkąt_obiekt.Kąt13 && Matematyka.Technical.Other_Methods.If_not_zero_of_two(trójkąt_obiekt.Kąt12, trójkąt_obiekt.Kąt13))
                {
                    BOK2.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(trójkąt_obiekt.Bok3));
                }
                if (trójkąt_obiekt.Kąt13 == trójkąt_obiekt.Kąt23 && Matematyka.Technical.Other_Methods.If_not_zero_of_two(trójkąt_obiekt.Kąt13, trójkąt_obiekt.Kąt23))
                {
                    BOK2.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(trójkąt_obiekt.Bok1));
                }
                if (trójkąt_obiekt.Kąt12 == 60 && trójkąt_obiekt.Kąt13 == 60 && trójkąt_obiekt.Kąt23 == 60)
                {
                    BOK2.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(trójkąt_obiekt.Bok1));
                    BOK2.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(trójkąt_obiekt.Bok3));
                }
                BOK2.Sort();
                BOK2.Reverse();
                trójkąt_obiekt.Bok2 = BOK2[0];

                List<double> BOK3 = new List<double>();
                BOK3.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(trójkąt_obiekt.Bok3));
                BOK3.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(trójkąt_obiekt.Pole * 2 / trójkąt_obiekt.Wysokość3));
                if (trójkąt_obiekt.Kąt13 != 0)
                {
                    BOK3.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(trójkąt_obiekt.Pole * 2 / (trójkąt_obiekt.Bok1 * Math.Sin(Matematyka.Technical.Other_Methods.Kąt_na_radiany(trójkąt_obiekt.Kąt13)))));
                }
                if (trójkąt_obiekt.Kąt23 != 0)
                {
                    BOK3.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(trójkąt_obiekt.Pole * 2 / (trójkąt_obiekt.Bok2 * Math.Sin(Matematyka.Technical.Other_Methods.Kąt_na_radiany(trójkąt_obiekt.Kąt23)))));
                }
                if (trójkąt_obiekt.Kąt12 == trójkąt_obiekt.Kąt23 && Matematyka.Technical.Other_Methods.If_not_zero_of_two(trójkąt_obiekt.Kąt12, trójkąt_obiekt.Kąt23))
                {
                    BOK3.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(trójkąt_obiekt.Bok1));
                }
                if (trójkąt_obiekt.Kąt12 == trójkąt_obiekt.Kąt13 && Matematyka.Technical.Other_Methods.If_not_zero_of_two(trójkąt_obiekt.Kąt12, trójkąt_obiekt.Kąt13))
                {
                    BOK3.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(trójkąt_obiekt.Bok2));
                }
                if (trójkąt_obiekt.Kąt12 == 60 && trójkąt_obiekt.Kąt13 == 60 && trójkąt_obiekt.Kąt23 == 60)
                {
                    BOK3.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(trójkąt_obiekt.Bok1));
                    BOK3.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(trójkąt_obiekt.Bok2));
                }
                BOK3.Sort();
                BOK3.Reverse();
                trójkąt_obiekt.Bok3 = BOK3[0];

                List<double> WYSOKOŚĆ1 = new List<double>();
                WYSOKOŚĆ1.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(trójkąt_obiekt.Wysokość1));
                WYSOKOŚĆ1.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(trójkąt_obiekt.Pole * 2 / trójkąt_obiekt.Bok1));
                WYSOKOŚĆ1.Sort();
                WYSOKOŚĆ1.Reverse();
                trójkąt_obiekt.Wysokość1 = WYSOKOŚĆ1[0];

                List<double> WYSOKOŚĆ2 = new List<double>();
                WYSOKOŚĆ2.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(trójkąt_obiekt.Wysokość2));
                WYSOKOŚĆ2.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(trójkąt_obiekt.Pole * 2 / trójkąt_obiekt.Bok2));
                WYSOKOŚĆ2.Sort();
                WYSOKOŚĆ2.Reverse();
                trójkąt_obiekt.Wysokość2 = WYSOKOŚĆ2[0];

                List<double> WYSOKOŚĆ3 = new List<double>();
                WYSOKOŚĆ3.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(trójkąt_obiekt.Wysokość3));
                WYSOKOŚĆ3.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(trójkąt_obiekt.Pole * 2 / trójkąt_obiekt.Bok3));
                WYSOKOŚĆ3.Sort();
                WYSOKOŚĆ3.Reverse();
                trójkąt_obiekt.Wysokość3 = WYSOKOŚĆ3[0];

                List<double> KAT12 = new List<double>();
                KAT12.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(trójkąt_obiekt.Kąt12));
                KAT12.Add(Math.Asin(Matematyka.Technical.Other_Methods.NULL_INFINITY(trójkąt_obiekt.Pole * 2 / (trójkąt_obiekt.Bok1 * trójkąt_obiekt.Bok2))) * 180 / Math.PI);
                if (Matematyka.Technical.Other_Methods.If_not_zero_of_two(trójkąt_obiekt.Kąt13, trójkąt_obiekt.Kąt23))
                {
                    KAT12.Add(180 - (trójkąt_obiekt.Kąt13 + trójkąt_obiekt.Kąt23));
                }
                if (Matematyka.Technical.Other_Methods.If_not_zero_of_two(trójkąt_obiekt.Bok1, trójkąt_obiekt.Bok2))
                {
                    if (trójkąt_obiekt.Bok1 == trójkąt_obiekt.Bok2 && trójkąt_obiekt.Bok2 == trójkąt_obiekt.Bok3)
                    {
                        KAT12.Add(60);
                    }
                }
                KAT12.Sort();
                KAT12.Reverse();
                trójkąt_obiekt.Kąt12 = KAT12[0];

                List<double> KAT13 = new List<double>();
                KAT13.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(trójkąt_obiekt.Kąt13));
                KAT13.Add(Math.Asin(Matematyka.Technical.Other_Methods.NULL_INFINITY(trójkąt_obiekt.Pole * 2 / (trójkąt_obiekt.Bok1 * trójkąt_obiekt.Bok3))) * 180 / Math.PI);
                if (Matematyka.Technical.Other_Methods.If_not_zero_of_two(trójkąt_obiekt.Kąt12, trójkąt_obiekt.Kąt23))
                {
                    KAT13.Add(180 - (trójkąt_obiekt.Kąt12 + trójkąt_obiekt.Kąt23));
                }
                if (Matematyka.Technical.Other_Methods.If_not_zero_of_two(trójkąt_obiekt.Bok1, trójkąt_obiekt.Bok2))
                {
                    if (trójkąt_obiekt.Bok1 == trójkąt_obiekt.Bok2 && trójkąt_obiekt.Bok2 == trójkąt_obiekt.Bok3)
                    {
                        KAT13.Add(60);
                    }
                }
                KAT13.Sort();
                KAT13.Reverse();
                trójkąt_obiekt.Kąt13 = KAT13[0];

                List<double> KAT23 = new List<double>();
                KAT23.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(trójkąt_obiekt.Kąt23));
                KAT23.Add(Math.Asin(Matematyka.Technical.Other_Methods.NULL_INFINITY(trójkąt_obiekt.Pole * 2 / (trójkąt_obiekt.Bok2 * trójkąt_obiekt.Bok3))) * 180 / Math.PI);
                if (Matematyka.Technical.Other_Methods.If_not_zero_of_two(trójkąt_obiekt.Kąt12, trójkąt_obiekt.Kąt13))
                {
                    KAT23.Add(180 - (trójkąt_obiekt.Kąt12 + trójkąt_obiekt.Kąt13));
                }
                if (Matematyka.Technical.Other_Methods.If_not_zero_of_two(trójkąt_obiekt.Bok1, trójkąt_obiekt.Bok2))
                {
                    if (trójkąt_obiekt.Bok1 == trójkąt_obiekt.Bok2 && trójkąt_obiekt.Bok2 == trójkąt_obiekt.Bok3)
                    {
                        KAT23.Add(60);
                    }
                }
                KAT23.Sort();
                KAT23.Reverse();
                trójkąt_obiekt.Kąt23 = KAT23[0];

                List<double> OBWÓD = new List<double>();
                OBWÓD.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(trójkąt_obiekt.Obwód));
                OBWÓD.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(trójkąt_obiekt.Bok1 + trójkąt_obiekt.Bok2 + trójkąt_obiekt.Bok3));
                OBWÓD.Sort();
                OBWÓD.Reverse();
                trójkąt_obiekt.Obwód = OBWÓD[0];

                //Console.WriteLine(Math.Asin(0.5) * 180 / Math.PI);//30
                //Console.WriteLine(Math.Sin(Kąt_na_radiany(30)));//0,5

                List<double> POLE = new List<double>();
                double Parametr = (Matematyka.Technical.Other_Methods.NULL_INFINITY(trójkąt_obiekt.Obwód)) / 2;
                POLE.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(trójkąt_obiekt.Pole));
                POLE.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(Math.Sqrt(Parametr * (Parametr - Matematyka.Technical.Other_Methods.NULL_INFINITY(trójkąt_obiekt.Bok1)) *
                  (Parametr - Matematyka.Technical.Other_Methods.NULL_INFINITY(trójkąt_obiekt.Bok2)) * (Parametr - Matematyka.Technical.Other_Methods.NULL_INFINITY(trójkąt_obiekt.Bok3)))));
                POLE.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(((trójkąt_obiekt.Bok1) * trójkąt_obiekt.Wysokość1) / 2));
                POLE.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(((trójkąt_obiekt.Bok2) * trójkąt_obiekt.Wysokość2) / 2));
                POLE.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(((trójkąt_obiekt.Bok3) * trójkąt_obiekt.Wysokość3) / 2));
                POLE.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY((trójkąt_obiekt.Bok1 * trójkąt_obiekt.Bok2) / 2) * Math.Sin(Matematyka.Technical.Other_Methods.Kąt_na_radiany(trójkąt_obiekt.Kąt12)));
                POLE.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY((trójkąt_obiekt.Bok1 * trójkąt_obiekt.Bok3) / 2) * Math.Sin(Matematyka.Technical.Other_Methods.Kąt_na_radiany(trójkąt_obiekt.Kąt13)));
                POLE.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY((trójkąt_obiekt.Bok2 * trójkąt_obiekt.Bok3) / 2) * Math.Sin(Matematyka.Technical.Other_Methods.Kąt_na_radiany(trójkąt_obiekt.Kąt23)));
                if (trójkąt_obiekt.Kąt12 == 60 && trójkąt_obiekt.Kąt13 == 60 && trójkąt_obiekt.Kąt23 == 60)
                {
                    POLE.Add(Matematyka.Technical.Other_Methods.NULL_INFINITY(Math.Pow(trójkąt_obiekt.Bok1, 2) * Math.Sqrt(3) / 4));
                }
                POLE.Sort();
                POLE.Reverse();
                trójkąt_obiekt.Pole = POLE[0];
            }
        }
    }
}
