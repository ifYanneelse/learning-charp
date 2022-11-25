using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaDeClasses
{
    class Barco : Veiculo
    {

        public int PotenciaHp { get; set; } 
        public double TamanhoEmPes
        {
            get
            {
                return this.Comprimento * 3.28;
            }
        }

        public Barco (double peso, double altura, double largura, double comprimento, int potenciaHp) : //int passageiros vem de aviao
           base(peso, altura, largura, comprimento)
        {
            this.PotenciaHp = potenciaHp;
            Console.WriteLine($"Um objeto do tipo BARCO foi criado com densidade {this.Densidade:F2}Kg/m3.");
        }

        ~Barco()
        {
            Console.WriteLine("Um objeto do BARCO foi DESTRUÍDO");
        }

        public void Navegar(double distancia) //distancia que vai voar
        {
            double percorrida = 0; //começa com 0
            while (percorrida < distancia) //enquanto a percorrida for menor que a distancia que quer percorrer
            {
                Console.WriteLine($"Nosso barco está a {(distancia - percorrida):F2} metros de distancia do destino.");
                percorrida += 20;
                Thread.Sleep(1000); //pausa por 1 segundo - milesegundos
            }
        }





    }
}
