﻿using System;
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
            //Conta conta = new Conta();
            //passa a não funcionar quando faz um outro construtor com outras propriedades


            /* Métodos Construtores
             * Sempre que uma classe for instanciada usando a palavra "new" o seu construtor é chamado.
             * 
             * Quando você cria uma classe, um construtor é automaticamente criado para a classe se você não definir nenhum construtor.
             * Este construtor é chamado de construtor padrão.
             * 
             * Ele não tem nenhuma funcionalidade, além do fato de que ele pode ser usado para criar uma instância da classe.
             * 
             * Dessa forma se você não definir nenhum construtor para a classe, o C# vai criar um construtor padrão vazio.
            */

            Conta conta = new Conta(123, 300); //quem instanciar essa conta, ganha o limite com esse valor automaticamente
            //numero + limite | conta.AddLimite(1500) passa a não ser funcional

            //conta.Numero(123); não funciona dessa maneira porque o set está private | só funciona a exibição


            //conta.Limite = 500; 
            //criado método AddLimite, não funciona mais

            //conta.AddLimite(1500);

            conta.Deposita(1500);
            conta.Deposita(2500);
            conta.Deposita(4500);
            //resultado = 10.000

            //conta.Saca(7000);
            //resultado = 3.000

            //conta.Saca(17000);
            //vai da negativo na conta, erro, tem que criar verificação no método Saca

            //como Saca é verdadeiro ou falso, criar um bool
            //bool saca = conta.Saca(17000); //vai dar saldo indisponivel
            //ou
            bool saca = conta.Saca(7000); //vai mostrar 3.000

            if (saca) //se deu certo, executa:
            {
                double saldo = conta.ConsultaSaldoDisponivel();

                Console.WriteLine("Seu saldo é: " + saldo);
                Console.WriteLine("Seu limite é: " + conta.Limite);
                Console.WriteLine("O número da sua conta é: " + conta.Numero);
            }

            /*
            double saldo = conta.ConsultaSaldoDisponivel(); //chama o método e retorna o saldo disponível

            //conta.Saldo = 10; 
            //para não permitir esse acrescimo, proteger o atributo saldo, para mover apenas na classe

            Console.WriteLine("Seu saldo é: " + saldo);
            Console.WriteLine("Seu limite é: " + conta.Limite);
            */


            //Console.WriteLine("Seu saldo é: " + conta.Saldo); 
            //funciona apenas quando os atributos são public

            Console.WriteLine("\n");
            Console.WriteLine("************************************************");

        }
    }
}
