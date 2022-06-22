using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudandoInterfaces
{
    class Macaco : IAnimal, IBipede
    {
        public void Caminhar()
        {
            Console.WriteLine("O macaco está caminhando com os dois pés");
        }

        public void Comer()
        {
            Console.WriteLine("O macaco está comendo banana");
        }

        public void Dormir()
        {
            Console.WriteLine("O macaco está dormindo na arvore");
        }

        public void EmitirSom()
        {
            Console.WriteLine("uuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuu");
        }
    }
}
