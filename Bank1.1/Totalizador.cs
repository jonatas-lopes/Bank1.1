namespace Bank1._1
{
    internal class Totalizador
    {
        public double valorTotal { get; protected set; }
        public Totalizador()
        {
        }

        public void Soma(Conta conta)
        {
            valorTotal += conta.saldo;
        }
    }
}