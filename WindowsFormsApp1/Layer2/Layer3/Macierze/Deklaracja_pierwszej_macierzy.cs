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
    public partial class Deklaracja_pierwszej_macierzy : Form
    {
        public Deklaracja_pierwszej_macierzy()
        {
            InitializeComponent();
        }
        int Rzędy1=0, Kolumny1=0;

        private void Zatwierdź_Click(object sender, EventArgs e)
        {

            Rzędy1 = Program.Exceptions_int_without_limits(textBox1.Text);
            Kolumny1 = Program.Exceptions_int_without_limits(textBox2.Text);

            if (Macierze.Czy_2_macierze == true)
            {
                Deklaracja_drugiej_macierzy openForm = new Deklaracja_drugiej_macierzy();
                openForm.Show();
                Visible = false;
            }
            else
            {
                Layer3.Macierze.Layer4_4_5.Layer_5.Operacje_na_jednej_macierzy_Form openForm = new Layer3.Macierze.Layer4_4_5.Layer_5.Operacje_na_jednej_macierzy_Form();
                openForm.Show();
                Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Macierze openForm = new Macierze();
            openForm.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //reset
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows.Add();
            dataGridView1.Columns.AddRange();
            Rzędy1 =dataGridView1.Rows.Count - 2;
            Kolumny1 = dataGridView1.Columns.Count - 2;
            for(int i=0; i< Rzędy1; i++)
            {
                for (int j = 0; j < Kolumny1; j++)
                {
                   //dataGridView1[Rzędy1, Kolumny1].Value = textBox[i * Kolumny1 + j].Text;
                }
            }
        }
    }
}
