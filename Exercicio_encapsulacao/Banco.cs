using System.Globalization;

namespace Exercicio_encapsulacao
{
    class Banco
    {
        public int NumeroDaConta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public Banco()
        {
        }

        public Banco(int numeroDaConta, string nome)
        {
            NumeroDaConta = numeroDaConta;
            Nome = nome;
        }

        public Banco(int numeroDaConta, string nome, double saldo) : this(numeroDaConta, nome)
        {
            Deposito(saldo);
        }

        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }

        public void Saque(double saque)
        {
            Saldo -= saque + 5.00;
        }

        public override string ToString()
        {
            return "Conta "
                + NumeroDaConta
                + ", Titular: "
                + Nome
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
