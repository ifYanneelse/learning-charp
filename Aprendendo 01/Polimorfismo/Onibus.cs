using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Onibus : Veiculo
    {

        private int capacidade;
        public override int Capacidade
        {
            get { return capacidade; }
            set
            {
                if ((value >= 18) && (value <= 60))
                {
                    capacidade = value;
                }
                else
                {
                    throw new Exception("O ônibus pode ter capacidade de 18 a 60 pessoas.");
                }
            }
        }

        public override void Abastecer(double quantidadeLitros)
        {
            QuantidadeCombustivel += quantidadeLitros;
            Console.WriteLine($"Ônibus abastecido com {quantidadeLitros} litros de diesel.");
        }

        public override void Mover(double distanciaKm)
        {
            if (QuantidadeCombustivel > (distanciaKm / 5))
            {
                QuantidadeCombustivel -= (distanciaKm / 5);
                Console.WriteLine($"Onibus se moveu por {distanciaKm} km.");
            }
            else
            {
                Console.WriteLine("Não há combustível para percorrer a distância informada.");
            }
        }

        //public override void Frear() vai copiar a classe carro
        public new void Frear() // new=quer reimplementar o metodo, desconsiderando a que está na classe ancestral
        {
            Console.WriteLine("Acionando os freios a ar.. PAROU!.");
        }

        public Onibus(int pesoKg, DateTime dataFabricacao, int capacidade = 44) : base(pesoKg, dataFabricacao)
        {
            Capacidade = capacidade;
        }






    }
}
