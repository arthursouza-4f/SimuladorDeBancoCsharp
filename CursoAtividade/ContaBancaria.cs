using System;
using System.Collections.Generic;
using System.Text;

namespace CursoAtividade
{
    class ContaBancaria
    {

        public int NumeroDaConta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

      

    

       

        public ContaBancaria(int conta, string nome, double saldo)
        {
            NumeroDaConta = conta;
            Nome = nome;
            Saldo = saldo;
        }
         public ContaBancaria(int conta, string nome)
        {

            NumeroDaConta = conta;
            Nome = nome;
            Saldo = 0;

        }
        

        public void AdicionarSaldo(double pegarsaldo)
        {
            Saldo += pegarsaldo; 
        }

        public void RemoverSaldo(double pegarsaldo)
        {
            Saldo -= pegarsaldo + 5 ;
        }

        public override string ToString()
        {
            return "Numero da conta: "
                + NumeroDaConta
                + ", Titular: "
                + Nome
                + ", Saldo da conta: "
                + Saldo;
        }





    }
}
