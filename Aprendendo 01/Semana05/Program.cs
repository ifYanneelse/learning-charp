using System;

namespace Semana05
{
    class Program
    {
        static void Main(string[] args)
        {
            //chama o primeiro construtor sem imc
            Pessoa p1 = new Pessoa("Albert", "Einstein", new DateTime(1955, 6, 17), "98765432110"); //mes 6 e dia 17
                        
            p1.Peso = 76;
            p1.Altura = 1.78;
            p1.MostrarDados();

            p1.Comer(2.5); //peso
            p1.Comer(3800); //calorias
            p1.Correr(7, 30); //7km, por 30 dias
            p1.MostrarDados();

            Console.WriteLine("_______________\n");

            Pessoa p2 = new Pessoa("Ada", "Lovelace", new DateTime(1975, 4, 18), "12345678901", 62, 1.65); //62 peso e 1.65 altura
            p2.MostrarDados();

        }




    }
}