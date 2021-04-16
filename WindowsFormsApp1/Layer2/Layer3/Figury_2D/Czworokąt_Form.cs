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
    public partial class Czworokąt_Form : Form
    {
        public Czworokąt_Form()
        {
            InitializeComponent();
        }

        private void Czworokąt_Load(object sender, EventArgs e)
        {

        }

        Czworokąt czworokąt = new Czworokąt();

        private void button1_Click(object sender, EventArgs e)
        {
            //czworokąt.Bok1 = Convert.ToDouble(maskedTextBox1.Text);

            Czworokąt.Wylicz_dane(czworokąt);

            //textBox1.Text = Convert.ToString(Math.Round(czworokąt.Bok1, 3));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Figury_2D openForm = new Figury_2D();
            openForm.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //reset
        }
    }
    class Czworokąt : Trójkąt
    {
        new public double Bok1;
        new public double Bok2;
        new public double Bok3;
        public double Bok4;
        new public double Wysokość1;
        new public double Wysokość2;
        new public double Wysokość3;
        public double Wysokość4;
        new public double Kąt12;
        public double Kąt14;
        new public double Kąt23;
        public double Kąt34;
        public double Przekątna14_23;
        public double Przekątna12_34;
        new public double Obwód;
        new public double Pole;

        public Czworokąt()
        {
        }

        public static void Wylicz_dane(Czworokąt czworokąt)
        {

        }
    }
}
