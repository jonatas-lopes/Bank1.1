using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank1._1
{
    public partial class Form1 : Form
    {
        private Conta c1;
        private Conta c2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conta c1 = new Conta();
            Conta c2 = new Conta();
            
           

            c2.numero = 2;
            c1.numero = 1;
            this.c1 = new Conta();
            this.c2 = new Conta();
            Cliente cli1 = new Cliente("João");
            Cliente cli2 = new Cliente("Maria");
            c2.titular = cli2;
            c1.titular = cli1;
            

            campoTitular.Text = c1.titular.nome;
            campoNumero.Text = Convert.ToString(c1.numero);
            campoSaldo.Text = Convert.ToString(c1.saldo);

            campoTitular2.Text = c2.titular.nome;
            campoNumero2.Text = Convert.ToString(c2.numero);
            campoSaldo2.Text = Convert.ToString(c2.saldo);
        }

        private void buttonDepositar_Click(object sender, EventArgs e)
        {
            string valorDigitado = campoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            this.c1.Depositar(valorOperacao);
            campoSaldo.Text = Convert.ToString(this.c1.saldo);
            MessageBox.Show("Deposito de " + valorOperacao + " efetuado com sucesso");
        }

        private void buttonSacar_Click(object sender, EventArgs e)
        {
            string valorDigitado = campoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            bool verificar = this.c1.Sacar(valorOperacao);

            if(verificar)
            {
                campoSaldo.Text = Convert.ToString(this.c1.saldo);

                MessageBox.Show("Saque Efetuado com sucesso");
                
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
                
            }
            
        }

        private void buttonDepositar2_Click(object sender, EventArgs e)
        {
            string ValorDigitado = campoValor2.Text;
            double valorOp = Convert.ToDouble(ValorDigitado);
            this.c2.Depositar(valorOp);
            campoSaldo2.Text = Convert.ToString(this.c2.saldo);
            MessageBox.Show("Deposito de " + valorOp + " efetuado com sucesso");
        }

        private void buttonSacar2_Click(object sender, EventArgs e)
        {
            string valorDigitado = campoValor2.Text;
            double valorOp = Convert.ToDouble(valorDigitado);
            bool confere = this.c2.Sacar(valorOp);

            if(confere)
            {
                campoSaldo2.Text = Convert.ToString(this.c2.saldo);
                MessageBox.Show("Saque de valor " + valorOp + " Realizado com sucesso");
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");

            }

        }

        private void buttonTransferir_Click(object sender, EventArgs e)
        {
            string valor = campoValor2.Text;
                             
            double valorOp = Convert.ToDouble(valor);
            bool confere = this.c1.Transferir(this.c2, this.c1, valorOp);
            if(confere)
            {
                campoSaldo2.Text = Convert.ToString(this.c2.saldo);
                campoSaldo.Text = Convert.ToString(this.c1.saldo);
                MessageBox.Show("Tranferencia realizada no valor de " + valorOp);
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }

            
        }

        private void buttonTranferir2_Click(object sender, EventArgs e)
        {
            string valor = campoValor.Text;
            
            double valorOp = Convert.ToDouble(valor);
            bool confere = this.c1.Transferir(this.c1, this.c2, valorOp);

            if (confere)
            {
                campoSaldo.Text = Convert.ToString(this.c1.saldo);
                campoSaldo2.Text = Convert.ToString(this.c2.saldo);
                MessageBox.Show("Tranferencia realizada no valor de " + valorOp);
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
            

        }
    }
}
