using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    /*
    //class vazia, trocar o modificador pra public
    //classe invisivel, ninguem consegue chamar
    class Conta
    {
    }
    */

    public class Conta
    {
        //atributo
        private double Saldo { get; set; } //get pode ser buscado | set pode adicionar valor ao atributo saldo
        //private = só essa classe pode manipular, não se modifica mais pelo Program

        public double Limite { get; private set; } // quando for setar, ele vai chamar o método AddLimite

        public int Numero { get; set; }



        //métodos = ações dentro da classe

        // void = não vai retornar nada
        public void Deposita(double valor) //o parametro valor - vai ser pedido para depositar
        {
            this.Saldo += valor; //inclementa o valor que está chegando
            //this só pega as informações dentro da classe
        }

        /* antes de dar erro pra sacar mais que o valor existente
        public void Saca(double valor) //retira dinheiro
        {
            this.Saldo -= valor;
        }
        */

        public bool Saca(double valor) //retira dinheiro
        {
            double saldoDisponivel = this.ConsultaSaldoDisponivel(); //primeiro, qual o saldo disponivel do usuario

            if(valor > saldoDisponivel) //se o valor informado for maior que o saldo disponivel
            {
                Console.WriteLine("Saque e saldo indisponível!");
                return false; //não deu certo o processo de saque
            }

            this.Saldo -= valor;
            return true;
        }

        public void AddLimite(double valor)
        {
            this.Limite = valor;             
        }

        //precisa retornar o saldo do usuario
        public double ConsultaSaldoDisponivel() //sem parametro de entrada, precisa de return
        {
            return this.Saldo + this.Limite;
        }

    }

}
