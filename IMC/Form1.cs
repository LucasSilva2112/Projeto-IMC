using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Peso_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calcular(object sender, EventArgs e)
        {
            double peso  = Convert.ToDouble(textBoxPeso.Text); 
            double altura = Convert.ToDouble( textBoxAltura.Text);

            double IMC = peso / Math.Pow(altura,2);

            // textBoxIMC.Text = Convert.ToString(IMC);

            textBoxIMC.Text = Math.Round(IMC,2).ToString();

            pictureBoxIMC.Image = Image.FromFile("IMGs/img17.jpg");
            
        }
    }
}
