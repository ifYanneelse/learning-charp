using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudandoInterfaces
{
    class Cachorro : IAnimal, IQuadrupede
        //não está herdando, mas está implementando de outra classe || precisa pegar todos os metodos da outra
    {
        public void Andar()
        {
            Console.WriteLine("O cachorro está andando com as 4 patas");
        }

        public void Comer()
        {
            Console.WriteLine("O cachorro está comendo ração");
        }

        public void Correr()
        {
            Console.WriteLine("O cachorro está correndo com as 4 patas");
        }

        public void Dormir()
        {
            Console.WriteLine("O cachorro está dormindo no chão");
        }

        public void EmitirSom()
        {
            Console.WriteLine("au au auuuuuuuuuuuuuu");
        }

        //fora do IAnimal
        public void Farejar()
        {
            Console.WriteLine("O cachorro está farejando");
        }


    }



}
