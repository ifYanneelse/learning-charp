using System;

namespace HerancaDeClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Aviao a1 = new Aviao(3200, 4, 16, 12, 22);
            a1.Voar(1000);

            //a1.Decolar() não funciona porque Decolar é private | private só pode ser visto na mesma classe
            //a1.Densidade não funciona porque Densidade está como protected

            Barco b1 = new Barco(1200, 2.5, 4, 12, 800);
            b1.Navegar(200);
        }







    }
}