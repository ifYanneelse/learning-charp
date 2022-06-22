using System;

namespace MembrosClassesAbstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa iniciado\n");

            //Veiculo v1 = new Veiculo(1000);
            //veiculo tem que ser a base de todos e usar apenas os objetos derivados, não a classe veiculo
            //precisa tornar a classe veiculo de 'public class veiculo' para 'public abstract class veiculo'
            //assim ela não poderá mais ser instanciada

            Carro c1 = new Carro(1200);

            Aviao a1 = new Aviao(3000); //peso

            viajar(a1); //qual veiculo vai viajar
        }

        //metodo
        static void viajar(Veiculo v)
        {
            Console.WriteLine("\n");
            v.Mover(10000); //distancia
        }





    }

}