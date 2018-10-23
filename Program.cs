using System;
using System.Globalization;

namespace fix1
{
    class Program
    {
        static void Main(string[] args)
        {

            Conta x;
            
            Console.Write("Digite o nome do titular da conta");
            Console.WriteLine("");
            string nome = Console.ReadLine();
            Console.Write("Digite o numero da conta");
            Console.WriteLine(" ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Havera deposito inicial? (s/n) ?");
            Console.WriteLine(" ");
            char ch = char.Parse(Console.ReadLine());

            if (ch == 's')
            {
                Console.Write("Digite o valor do deposito inicial: ");
                double valorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                x = new Conta(numero, nome, valorInicial);
            }
            else {
                x = new Conta(numero, nome);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Dados da conta" + x);

            Console.WriteLine(" ");
            Console.WriteLine("Digite o valor para deposito");
            double valordeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.depositarConta(valordeposito);
            
            Console.WriteLine(" ");
            Console.WriteLine("Dados da conta actualizada" + x);
            Console.WriteLine(" ");
            Console.WriteLine("Digite o valor para saque");
            double valorsaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.saqueConta(valorsaque);
            Console.WriteLine(" ");
            Console.WriteLine("Dados da conta actualizada" + x);

            Console.ReadLine();

        }
    }
}
