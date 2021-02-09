namespace Bank1._1
{
    internal class Contapoupanca : Conta
    {
        public Contapoupanca()
        {
        }

        public override bool Sacar(double valor)
        {
            if(this.saldo >= valor)
            {
                base.Sacar(valor + 0.10);
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}