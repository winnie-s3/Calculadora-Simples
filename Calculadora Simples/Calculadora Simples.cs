using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Simples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;
            valor1 = int.Parse(textBox1.Text);
            valor2 = Convert.ToInt32(textBox2.Text);
            resultado = valor1 - valor2;
            label5.Text = resultado.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;
            valor1 = int.Parse(textBox1.Text);
            valor2 = Convert.ToInt32(textBox2.Text);
            resultado = valor1 / valor2;
            label5.Text = resultado.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;
            valor1 = int.Parse(textBox1.Text);
            valor2 = Convert.ToInt32(textBox2.Text);
            resultado = valor1 + valor2;
            label5.Text = resultado.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int valor1, valor2, resultado;
            valor1 = int.Parse(textBox1.Text);
            valor2 = Convert.ToInt32(textBox2.Text);
            resultado = valor1 * valor2;
            label5.Text = resultado.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label5.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
