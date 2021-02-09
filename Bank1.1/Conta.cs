using System;

namespace Bank1._1
{
    public class Conta
    {
        

        public int numero { get; set; }
        public double saldo { get; protected set; }
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

        public virtual bool Sacar(double valor)
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

        public bool Transferir(Conta partida, Conta destino, double valor)
        {
            if(valor <= this.saldo)
            {
                if (partida.Sacar(valor))
                {
                    destino.Depositar(valor);
                }
                return true;

            }
            else
            {
                return false;
            }
           
        }
    }
}