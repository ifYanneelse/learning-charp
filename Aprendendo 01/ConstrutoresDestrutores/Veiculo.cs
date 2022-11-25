using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutoresDestrutores
{
    internal class Veiculo
    {
        public int PesoKg { get; set; } 

        public Veiculo()
        {
            Console.WriteLine("um novo objeto VEÍCULO foi criado");
        }

        public Veiculo(int pesoKg) : this()
        {
            this.PesoKg = pesoKg;
        }

        ~Veiculo()
        {
            Console.WriteLine("um objeto VEÍCULO foi DESTRUÍDO");
        }


    }
}
