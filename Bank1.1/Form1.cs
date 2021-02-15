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
        private Conta[] contas;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            contas = new Conta[2];

            

            this.contas[0] = new Conta();
            this.contas[0].titular = new Cliente("João");
            this.contas[0].numero = 1;

            this.contas[1] = new Contapoupanca();
            this.contas[1].titular = new Cliente("Maria");
            this.contas[1].numero = 2;


            foreach (Conta c in contas)
            {
                comboContas.Items.Add(c.titular.nome);
            }


            foreach (Conta c in contas)
            {
                comboTransfere.Items.Add(c.titular.nome);
            }


        }

        private void buttonDepositar_Click(object sender, EventArgs e)
        {
            int indice = Convert.ToInt32(comboContas.SelectedIndex);
            Conta selecionada = this.contas[indice];

            double valor = Convert.ToDouble(campoValor.Text);
            selecionada.Depositar(valor);
            campoSaldo.Text = Convert.ToString(selecionada.saldo);            
        }

        private void buttonSacar_Click(object sender, EventArgs e)
        {
            int indice = Convert.ToInt32(comboContas.SelectedIndex);
            Conta selecionada = this.contas[indice];

            double valor = Convert.ToDouble(campoValor.Text);
            selecionada.Sacar(valor);
            campoSaldo.Text = Convert.ToString(selecionada.saldo);

        }

            
               

        private void buttonTranferir2_Click(object sender, EventArgs e)
        {
            
            

        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
                       

            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];
            campoNumero.Text = Convert.ToString(selecionada.numero);
            campoTitular.Text = selecionada.titular.nome;
            campoSaldo.Text = Convert.ToString(selecionada.saldo);

            
        }

        private void comboTransfere_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
