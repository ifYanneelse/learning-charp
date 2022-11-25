using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembrosClassesAbstratas
{
    //sealed impede que a classe avião seja ancestral de outra classe

    public sealed class Aviao : Veiculo
    {
        public Aviao(double peso) : base(peso)
        {
            Console.WriteLine("Um novo objeto AVIÃO foi criado");
        }

        public override void Mover(double distancia)
        {
            Console.WriteLine($"Um objeto AVIÃO se moveu por {distancia} metros.");
        }
    }
}
