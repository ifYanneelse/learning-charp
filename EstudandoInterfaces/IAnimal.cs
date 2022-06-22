using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudandoInterfaces
{
    interface IAnimal
    {
        //declaração de 3 assinaturas do metodo
        //não tem modificadores de acesso
        void Comer();
        void Dormir();
        void EmitirSom();

    }
}
