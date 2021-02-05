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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conta c1 = new Conta();
            c1.numero = 1;
            this.c1 = new Conta();
            Cliente cli1 = new Cliente("João");
            c1.titular = cli1;
            

            campoTitular.Text = c1.titular.nome;
            campoNumero.Text = Convert.ToString(c1.numero);
            campoSaldo.Text = Convert.ToString(c1.saldo);
        }

        private void buttonDepositar_Click(object sender, EventArgs e)
        {
            string valorDigitado = campoDepositar.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            this.c1.Depositar(valorOperacao);
            campoSaldo.Text = Convert.ToString(this.c1.saldo);
            MessageBox.Show("Deposito de " + valorOperacao + " efetuado com sucesso");
        }

        private void buttonSacar_Click(object sender, EventArgs e)
        {
            string valorDigitado = campoDepositar.Text;
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
    }
}
