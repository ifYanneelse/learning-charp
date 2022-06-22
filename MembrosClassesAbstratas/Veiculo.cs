using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembrosClassesAbstratas
{
    public abstract class Veiculo //antes era public class
        //abstract não pode ser instanciada, agora ela é a derivada
    {
        public double Peso { get; set; }

        //precisa colocar mesmo construtor de carro
        public Veiculo (double peso)
        {
            this.Peso = peso;
            Console.WriteLine("Um novo objeto VEÍCULO foi criado");
        }

        ~Veiculo()
        {
            Console.WriteLine("Um objeto veiculo foi DESTRUÍDO");
        }


        public abstract void Mover(double distancia); //precisa estar na classe carro também




    }

}
