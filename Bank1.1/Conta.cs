using System;

namespace Bank1._1
{
    public class Conta
    {
        public Conta()
        {
        }

        public int numero { get; set; }
        public double saldo { get; private set; }
        public Cliente titular { get; set; }

        public double setSaldo(double valor)
        {
            return this.saldo = valor;
        }
        public bool Depositar(double valorOperacao)
        {
            if(valorOperacao >= 0)
            {
                this.saldo += valorOperacao;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Sacar(double valor)
        {
            if(this.saldo >= valor)
            {
                this.saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}