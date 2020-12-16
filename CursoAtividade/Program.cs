using System;

namespace CursoAtividade
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;
            ContaBancaria conta1;
            Console.WriteLine("Programa para simular sistema de banco. ");
            Console.Write("Numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("havera deposito inicial(s/n)? ");
            string sim_ou_nao = Console.ReadLine();

            if (sim_ou_nao == "s" || sim_ou_nao ==  "S")
            {
                Console.WriteLine("Digite o saldo inicial do conta ");
                double saldo = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numero, titular, saldo);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta");
            Console.WriteLine(conta);


            Console.WriteLine("Entre com o valor pra deposito: ");
            double pegarsaldo = double.Parse(Console.ReadLine());
            conta.AdicionarSaldo(pegarsaldo);


            Console.WriteLine("Dados atualizados");
            Console.WriteLine(conta);

            Console.WriteLine("Entre com o valor pra saque: ");
            pegarsaldo = double.Parse(Console.ReadLine());
            conta.RemoverSaldo(pegarsaldo);

            Console.WriteLine("Dados atualizados");
            Console.WriteLine(conta);

        }
    }
}
