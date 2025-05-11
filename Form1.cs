using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hellokittycalculator
{
    public partial class Form1 : Form
    {
        private double valor1;
        private double valor2;
        private int operacion;

        private double resultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            //num 1
            tbDisplay.Text = tbDisplay.Text + "1";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            //num 2
            tbDisplay.Text = tbDisplay.Text + "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //num 6
            tbDisplay.Text = tbDisplay.Text + "6";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //num 9
            tbDisplay.Text = tbDisplay.Text + "9";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //multiplicacion
            operacion = 4;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = " ";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //division
            operacion = 3;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = " ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            //num 0
            tbDisplay.Text = tbDisplay.Text + "0";


        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //num 3
            tbDisplay.Text = tbDisplay.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            //num 4
            tbDisplay.Text = tbDisplay.Text + "4";

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            //num 5
            tbDisplay.Text = tbDisplay.Text + "5";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            //num 7
            tbDisplay.Text = tbDisplay.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + "8";
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            //boton .
            tbDisplay.Text = tbDisplay.Text + ".";
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            //boton limpiar
            tbDisplay.Text = "";
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            //boton =
          valor2 = Convert.ToDouble(tbDisplay.Text);

           
            switch (operacion)
            {
                case 1:
                    resultado = valor1 + valor2;
                    break;
                    case 2:
                    resultado = valor1 - valor2;
                    break;
                    case 3:
                    resultado = valor1 / valor2;
                    break;
                    case 4:
                    resultado = valor1 * valor2;
                    break;
            }


            tbDisplay.Text = resultado.ToString();
        }

        private void bsuma_Click(object sender, EventArgs e)
        {
            //suma
            operacion = 1;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = " ";
        }

        private void bnresta_Click(object sender, EventArgs e)
        {
            //resya
            operacion = 2;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = " ";
        }
    }
}
