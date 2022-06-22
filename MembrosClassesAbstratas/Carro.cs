using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembrosClassesAbstratas
{
    public class Carro : Veiculo
    {

        //precisa colocar mesmo construtor de veiculo
        public Carro(double peso) : base(peso)
        {
            Console.WriteLine("Um novo objeto CARRO foi criado");
        }

        //veiculo transformado em abstract, precisa pegar o construtor abstract também
        public override void Mover(double distancia) //construtor de ancestral (class veiculo) e abstract precisa colocar override
        {
            Console.WriteLine($"Um objeto CARRO se moveu por {distancia} kms.");
        }







    }



}
