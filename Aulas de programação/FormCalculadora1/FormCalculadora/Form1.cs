using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCalculadora
{   
    public partial class Form1 : Form
    {
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////// AJEITAR
        void Soma (String s)
        {
            int n1, n2, soma;

            soma = n1 + n2;
            TbTela.AppendText(soma.ToString());
        }

        void Subtracao (String s)
        {
            int n1, n2, sub;

            sub = n1 - n2;
            TbTela.AppendText(sub.ToString());
        }

        void Multiplicacao (String s)
        {
            int n1, n2, mult;

            mult = n1 * n2;
            TbTela.AppendText(mult.ToString());
        }

        void Divisao (String s)
        {
            int n1, n2, div;

            div = n1 / n2;
            TbTela.AppendText(div.ToString());
        }

        void resto (String s)
        {
            int n1, n2, resto;

            resto = n1 % n2;
            TbTela.AppendText(resto.ToString());
        }

        void PrimosAnt (String s)
        {

        }

        void Divisores (String s)
        {
            int n, i = 0;
            String divisores;
            while (n <= i)
            {
                if (n % i == 0)
                {
                    
                }
            }
        }


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////// AJEITAR

        void Maior (String s)
        {   
            int maior = 0, numero;
            numero = int.Parse(TbTela.Text);

            while (numero > 0)
            {
                if (numero % 10 > maior)
                {
                    maior = numero % 10;
                }
                numero = numero / 10;
            }

            TbTela.Clear();
            TbTela.AppendText(maior.ToString());

        }

        void Fatorial (String s)
        {
            int i, numero;
            numero = int.Parse(TbTela.Text);

            for (i = numero - 1; i != 1; i--)
            {
                numero = numero * i;
            }

            TbTela.Clear();
            TbTela.AppendText(numero.ToString());
        }

        void Primo (String s)
        {
            int numero;
            numero = int.Parse(TbTela.Text);
            int i, contador = 0;
            for (i = 2; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    contador = contador + 1;
                }
            }
            if (contador == 1)
            {
                TbTela.Clear();
                TbTela.AppendText("É primo!");
            }
            else
            {
                TbTela.Clear();
                TbTela.AppendText("Não é primo!");
            }
        }

        void Angulo (String s)
        {
            int angulo;
            angulo = int.Parse(TbTela.Text);
            
            if (angulo != 90)
            {
                if (angulo < 90)
                {
                    TbTela.Clear();
                    TbTela.AppendText("Agudo");
                }
                else
                {
                    TbTela.Clear();
                    TbTela.AppendText("Obtuso");
                }
            }
            else
            {
                TbTela.Clear();
                TbTela.AppendText("Reto");
            }
            
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
        
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            TbTela.AppendText("1");
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            TbTela.AppendText("2");
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            TbTela.AppendText("3");
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            TbTela.AppendText("4");
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            TbTela.AppendText("5");
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            TbTela.AppendText("6");
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            TbTela.AppendText("7");
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            TbTela.AppendText("8");
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            TbTela.AppendText("9");
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            TbTela.AppendText("0");
        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            TbTela.Clear();
        }

        private void BtnSoma_Click(object sender, EventArgs e)
        {
            Soma(TbTela.Text);
        }

        private void BtnSubtrai_Click(object sender, EventArgs e)
        {
            TbTela.AppendText("-");
        }

        private void BtnMultiplica_Click(object sender, EventArgs e)
        {
            TbTela.AppendText("*");
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            TbTela.AppendText("/");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPrimo_Click(object sender, EventArgs e)
        {
            Primo(TbTela.Text);
        }

        private void BtnAng_Click(object sender, EventArgs e)
        {
            Angulo(TbTela.Text);
        }

        private void BtnFat_Click(object sender, EventArgs e)
        {
            Fatorial(TbTela.Text);
        }

        private void BtnMaior_Click(object sender, EventArgs e)
        {
            Maior(TbTela.Text);
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {

        }

        private void BtnDivisores_Click(object sender, EventArgs e)
        {

        }
    }
}
