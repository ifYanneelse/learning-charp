using System;

namespace ConstrutoresDestrutores
{
    class Program
    {
        //construtores static são chamados pelo próprio progama
        static Program()
        {
            Console.WriteLine("Programa iniciado\n");
        }


        static void CriarObjetos()
        {
            //chama o construtor padrão
            Carro c1 = new Carro(); //new Carro() vai invocar o método construtor padrão = sem parâmetro
            c1.Modelo = "Fusca";
            c1.Portas = 4;
            c1.Preco = 29990;

            Carro c2 = new Carro();
            c2.Modelo = "Opala";
            c2.Portas = 4;
            c2.Preco = 49990;

            //chama o construtor personalizado - envia parâmetro
            Carro c3 = new Carro("Chevete");
            c3.Portas = 2;
            c3.Preco = 32990;

            //chama o construtor com todos os parâmetros
            Carro c4 = new Carro("Monza", 4, 39990);

            Carro c5 = new Carro(1190); //passando o peso pra testar heranças
        }



        static void Main(string[] args)
        {
            CriarObjetos(); //chama o método e por método vai limpando

            Console.WriteLine("Objetos já não são mais utilizados");

            //garbage collect | lixeira | forçando liberar a memória
            GC.Collect();

        }
    }



}
