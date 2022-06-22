using System;

namespace EstudandoInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa iniciado\n");

            IAnimal osvaldo = new Cachorro();
            osvaldo.EmitirSom();

            //osvaldo.Farejar(); //não roda porque o osvaldo é do tipo IAnimal
            //precisa fazer conversão de tipos:
            if (osvaldo is Cachorro) //testa se osvaldo é do tipo cachorro
            {
                (osvaldo as Cachorro).Farejar();
            }

            Console.WriteLine("\n");
            //como classe cachorro tudo funciona:
            Cachorro bilu = new Cachorro();
            bilu.EmitirSom();
            bilu.Farejar();

            Console.WriteLine("\n");

            IAnimal bolinha = new Cachorro();
            if (bolinha is IQuadrupede)
            {
                (bolinha as IQuadrupede).Andar();
            }
            if (bolinha is Cachorro)
            {
                (bolinha as Cachorro).Farejar();
            }
            Console.WriteLine("\n");

            //gerador aleatorio de objetos

            Random rnd = new Random();
            List<IAnimal> animais = new List<IAnimal>();
            for (int i = 0; i < 30; i++)
            {
                int sorteio = rnd.Next();
                if (sorteio % 2 == 0) //se for par = cachorro
                {
                    animais.Add(new Cachorro());
                }
                else
                {
                    animais.Add(new Macaco());
                }

                foreach (var animal in animais) //para cada item animal na lista de animais
                {
                    Console.WriteLine("----------------------------");

                    if (animal is IQuadrupede)
                        Console.WriteLine("Quadrupede");

                    if (animal is IBipede)
                        Console.WriteLine("bipede");

                    if (animal is Cachorro)
                    {
                        Console.WriteLine("Este animal é um cachorro");
                        (animal as Cachorro).Farejar();
                    }

                    if (animal is Macaco)
                    {
                        Console.WriteLine("Este animal é um macaco");
                        (animal as Macaco).Caminhar();
                    }




                }
            }





        }

    }

}