namespace Heranca1
{
    partial class Program
    {
        class Conta 
        {
            private int teste;

            public int Numero { get; set; }

            public double Saldo { get; set; }

            public double GetSaldo() 
            {
                return Saldo;
            }
        }
    }
}
