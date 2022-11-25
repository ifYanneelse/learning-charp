using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("************************************************\n");


            //para criar um objeto, precisa criar uma instância da class Conta
            Conta conta1 = new Conta();
            Conta conta2 = new Conta();


            //para acessar as propriedades da conta (saldo, limite, numero)
            conta1.Saldo = 1500;
            conta1.Limite = 500;
            conta1.Numero = 123;

            conta2.Saldo = 2000;
            conta2.Limite = 600;
            conta2.Numero = 456;


            Console.WriteLine("Olá, fulano, seu saldo em conta é: " + conta1.Saldo);
            Console.WriteLine("Limite de saque: " + conta1.Limite);
            Console.WriteLine("O número da conta é: " + conta1.Numero);

            Console.WriteLine("_________________________________________________\n");

            Console.WriteLine("Olá, fulano, seu saldo em conta é: " + conta2.Saldo);
            Console.WriteLine("Limite de saque: " + conta2.Limite);
            Console.WriteLine("O número da conta é: " + conta2.Numero);

            Console.WriteLine("\n");

            Console.WriteLine("************************************************");

        }
    }
}
