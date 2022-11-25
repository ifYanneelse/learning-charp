using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{

    public class Conta
    {

        public Conta(int numero, double limite)
        {
            this.Numero = numero;
            this.Limite = limite;
            //this.TotalContasCriadas++; //faze a contagem | quando é static não funciona essa função
            //depois de static chamar agora pela class
            Conta.TotalContasCriadas++;
        }


        private double Saldo { get; set; } 

        public double Limite { get; private set; } 

        public int Numero { get; private set; }

        //public int TotalContasCriadas { get; set; }
        //exibe na tela quantas contas foram criadas na class
        public static int TotalContasCriadas { get; set; } //static pra ser acessado na class e não só pelo objeto criado


        //método statico
        //usa diretamente da class
        public static int ProximoTotalContasCriadas()
        {
            return Conta.TotalContasCriadas + 1;
        }



        public void Deposita(double valor) 
        {
            this.Saldo += valor; 
        }

        public bool Saca(double valor) 
        {
            double saldoDisponivel = this.ConsultaSaldoDisponivel(); 

            if(valor > saldoDisponivel)
            {
                Console.WriteLine("Saque e saldo indisponível!");
                return false; 
            }

            this.Saldo -= valor;
            return true;
        }

        public void AddLimite(double valor)
        {
            this.Limite = valor;             
        }

        public double ConsultaSaldoDisponivel()
        {
            return this.Saldo + this.Limite;
        }

    }

}
