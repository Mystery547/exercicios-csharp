using System;
using System.Globalization;

namespace Exercicio_encapsulacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco b = new Banco();

            Console.Write("Entre com o número da conta: ");
            int numeroDaConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o Titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char confirmacao = char.Parse(Console.ReadLine());

            while(confirmacao != 's' && confirmacao != 'S' && confirmacao != 'n' && confirmacao != 'N')
            {
                Console.WriteLine();
                Console.WriteLine("Favor fornecer resposta válida!");
                Console.WriteLine();

                Console.Write("Haverá depósito inicial (s/n)? ");
                confirmacao = char.Parse(Console.ReadLine());

                if (confirmacao == 's' || confirmacao == 'S')
                {
                    Console.Write("Entre o valor de depósito inicial: ");
                    double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    b = new Banco(numeroDaConta, nome, saldo);
                }
                else
                {
                    b = new Banco(numeroDaConta, nome);
                }
            }          

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(b);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b.Deposito(deposito);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados:");
            Console.WriteLine(b);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b.Saque(saque);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados:");
            Console.WriteLine(b);
        }
    }
}
