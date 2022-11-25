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

            Conta conta1 = new Conta(123, 500);
            Conta conta2 = new Conta(456, 800);
            Conta conta3 = new Conta(789, 900);
            Conta conta4 = new Conta(012, 1000);


            Console.WriteLine("************************************************\n");

            /*
            Console.WriteLine("Total de contas criadas: " + conta1.TotalContasCriadas);
            //vai retornar 1, porque TotalContasCriadas está sendo o atributo do objeto criado (conta1) e não da class
            //mudar então o atributo para static
            //depois de mudar pra static, não é possível mais o acesso pela instância, só pela class Conta.
            */

            Console.WriteLine("Total de contas criadas: " + Conta.TotalContasCriadas);

            //acessando o método static:
            int proximo = Conta.ProximoTotalContasCriadas();
            Console.WriteLine("Próximo Total de contas criadas será: " + proximo);

            Console.WriteLine("\n");
            Console.WriteLine("************************************************");

        }
    }
}
