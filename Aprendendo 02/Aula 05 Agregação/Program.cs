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

            //Criando um objeto de cada classe
            //class CartaoDeCredito
            CartaoDeCredito cdc = new CartaoDeCredito();
            //class Cliente
            Cliente c = new Cliente();


            //Adicionando o nome do cliente
            c.Nome = "Green Apple"; //objeto c com única propriedade da class Cliente


            //Adicionando o numero e data de validade do cartao
            cdc.Numero = "1234567890";
            cdc.DataDeValidade = "02/2025";


            //associa o cliente dentro do agregado que está na class CartaoDeCredito
            cdc.Cliente = c;




            Console.WriteLine("************************************************\n");

            Console.WriteLine("O nome do cliente é: " + c.Nome); //nome direto da class Cliente
            Console.WriteLine("O número do cartão é: " + cdc.Numero);
            Console.WriteLine("A data de validade é: " + cdc.DataDeValidade);
            Console.WriteLine("O nome do cliente (por agregação) é: " + cdc.Cliente.Nome); //nome da class CartaoDeCredito

            Console.WriteLine("\n");
            Console.WriteLine("************************************************");

        }
    }
}
