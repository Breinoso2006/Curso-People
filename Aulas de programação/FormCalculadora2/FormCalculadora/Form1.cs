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

        private int n1, n2; //variáveis que 
        private char operador;//serão usadas
        
        public Form1()
        {
            InitializeComponent();
            PosicaoInicial();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

// INÍCIO DAS EXPRESSÕES EXTERNAS //

        private void PosicaoInicial() // permite apenas que os numeros sejam selecionados
        {
            BtnSoma.Enabled = false;
            BtnSubtrai.Enabled = false;
            BtnMultiplica.Enabled = false;
            BtnDivide.Enabled = false;
            BtnIgual.Enabled = false;
            BtnFat.Enabled = false;
            BtnResto.Enabled = false;
            BtnPrimosant.Enabled = false;
            BtnAng.Enabled = false;
            BtnDivisores.Enabled = false;
            BtnMaior.Enabled = false;
        }

        private void IniciaConta(char op) // recebe o que está na tb e passa para int, de forma que guarde essa informação para ser usada posteriormente
        {                               // além de limpar a textbox e desabilitar os botões
            n1 = int.Parse(TbTela.Text);

            operador = op;

            TbTela.Clear();

            DesabilitaBotoes();

        }

        private void FinalizaConta() // recebe o sinal para saber qual será a operação a ser feita, usando switch e case; de forma que para quando uma delas é realizada
        {
            n2 = int.Parse(TbTela.Text);

            switch (operador)
            {
                case '+':
                    TbTela.Text = (n1 + n2).ToString();
                    break;
                case '-':
                    TbTela.Text = (n1 - n2).ToString();
                    break;
                case '*':
                    TbTela.Text = (n1 * n2).ToString();
                    break;
                case '/':
                    TbTela.Text = (n1 / n2).ToString();
                    break;
                case '%':
                    TbTela.Text = (n1 % n2).ToString();
                    break;
            }

            HabilitaBotoes(); 
        }

        private void HabilitaBotoes() // habilita os botões; usado após o sinal de igual, desabilitando-o
        {
            BtnSoma.Enabled = true;
            BtnSubtrai.Enabled = true;
            BtnMultiplica.Enabled = true;
            BtnDivide.Enabled = true;
            BtnIgual.Enabled = true;
            BtnFat.Enabled = true; 
            BtnPrimosant.Enabled = true;
            BtnAng.Enabled = true;
            BtnDivisores.Enabled = true;
            BtnMaior.Enabled = true;
            BtnResto.Enabled = true;
        }

        private void DesabilitaBotoes() // desabilita botões de operação, usado após um deles ser pressionado; habilita o igual
        {
            BtnSoma.Enabled = false;
            BtnSubtrai.Enabled = false;
            BtnMultiplica.Enabled = false;
            BtnDivide.Enabled = false;
            BtnIgual.Enabled = true;
            BtnFat.Enabled = false;
            BtnPrimosant.Enabled = false;
            BtnAng.Enabled = false;
            BtnDivisores.Enabled = false;
            BtnMaior.Enabled = false;
            BtnResto.Enabled = false;
        }

        private void DesabilitaNumeros () // desabilita os numeros
        {
            Btn0.Enabled = false;
            Btn1.Enabled = false;
            Btn2.Enabled = false;
            Btn3.Enabled = false;
            Btn4.Enabled = false;
            Btn4.Enabled = false;
            Btn5.Enabled = false;
            Btn6.Enabled = false;
            Btn7.Enabled = false;
            Btn8.Enabled = false;
            Btn9.Enabled = false;
        }

        private void HabilitaNumeros() // habilita os numeros
        {
            Btn0.Enabled = true;
            Btn1.Enabled = true;
            Btn2.Enabled = true;
            Btn3.Enabled = true;
            Btn4.Enabled = true;
            Btn4.Enabled = true;
            Btn5.Enabled = true;
            Btn6.Enabled = true;
            Btn7.Enabled = true;
            Btn8.Enabled = true;
            Btn9.Enabled = true;
        }

        private void Maior(String s) // define o maior dígito do número digitado
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

        private void Fatorial(String s) // faz o fatorial do número que foi digitado na textbox
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

        private void Angulo(String s) // analisa que tipo de ângulo seria o número presente na textbox
        {
            int angulo;
            angulo = int.Parse(TbTela.Text);

            if (angulo > 360)
            {
                TbTela.Clear();
                TbTela.AppendText("Digite um ângulo menor.");
            }
            else
            {
                if (angulo == 90)
                {
                    TbTela.Clear();
                    TbTela.AppendText("Reto");
                }
                else
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
            }

        }

        private void Divisores () // verifica quantos divisores o número possui; caso sejam 2 ou menos (no caso do 1), diz que é primo
        {
            int i, divisores = 0, numero;
            numero = int.Parse(TbTela.Text);

            if (numero == 0)
            {
                TbTela.Clear();
                TbTela.AppendText("Zero não conta!");
            }
            else
            {
                for (i = 1; i <= numero; i++)
                {
                    if (numero % i == 0)
                    {
                        divisores++;
                    }
                }
                if (divisores <= 2)
                {
                    TbTela.Clear();
                    TbTela.AppendText("Este numero é primo");
                }
                else
                {
                    TbTela.Clear();
                    TbTela.AppendText(divisores.ToString());
                }
            }
        }

        private void PrimosAnteriores () // verifica quantos primos existem antes deste número
        {
            int i, j, primosant = 0,  numero;
            numero = int.Parse(TbTela.Text);

            for (i = 1; numero > i; i++)
            {
               for (j = 1; i >= j; j++)
                {
                    if (i % j != 0)
                    {
                        TbTela.AppendText(primosant.ToString() + ", ");
                    }
                }
            }
        }

// FINAL DAS EXPRESSÕES EXTERNAS //

        private void Btn1_Click(object sender, EventArgs e) //mostra o numero sugerido na textbox
        {
            TbTela.AppendText("1");
            HabilitaBotoes();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            TbTela.AppendText("2");
            HabilitaBotoes();
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            TbTela.AppendText("3");
            HabilitaBotoes();
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            TbTela.AppendText("4");
            HabilitaBotoes();
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            TbTela.AppendText("5");
            HabilitaBotoes();
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            TbTela.AppendText("6");
            HabilitaBotoes();
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            TbTela.AppendText("7");
            HabilitaBotoes();
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            TbTela.AppendText("8");
            HabilitaBotoes();
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            TbTela.AppendText("9");
            HabilitaBotoes();
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            TbTela.AppendText("0");
            HabilitaBotoes();
        }

        private void BtnSoma_Click(object sender, EventArgs e) // Usa o sinal de operação sugerido na função IniciaConta
        {
            IniciaConta('+');
        }

        private void BtnSubtrai_Click(object sender, EventArgs e)
        {
            IniciaConta('-');
        }

        private void BtnMultiplica_Click(object sender, EventArgs e)
        {
            IniciaConta('*');
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            IniciaConta('/');
        }

        private void BtnResto_Click(object sender, EventArgs e)
        {
            IniciaConta('%');
        }

        private void BtnExit_Click(object sender, EventArgs e) // fecha o programa
        {
            this.Close();
        }

        private void BtnAng_Click(object sender, EventArgs e) // pega o numero da textbox para analisar, em uma função externa, que tipo de angulo seria
        {
            Angulo(TbTela.Text);
        }

        private void BtnFat_Click(object sender, EventArgs e) // pega o numero da textbox para fazer seu fatorial, em uma função externa
        {
            Fatorial(TbTela.Text);
        }

        private void BtnMaior_Click(object sender, EventArgs e) // pega o numero da textbox para analisar, em uma função externa, qual seria seu maior dígito
        {
            Maior(TbTela.Text);
        }

        private void BtnIgual_Click(object sender, EventArgs e) // inicia a função FinalizaConta
        {
            FinalizaConta();
            PosicaoInicial();
            DesabilitaNumeros();
        }

        private void BtnCE_Click(object sender, EventArgs e) // limpa a textbox
        {
            TbTela.Clear();
            HabilitaNumeros();
            HabilitaBotoes();
        }

        private void BtnPrimosant_Click(object sender, EventArgs e)
        {
            PrimosAnteriores();
        }

 
        private void BtnDivisores_Click(object sender, EventArgs e) // inicia a função Divisores
        {
            Divisores();
        }
    }
}
