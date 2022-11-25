using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Carro : Veiculo
    {
        private int capacidade;
        public override int Capacidade
        {
            get { return capacidade; } // ler: retorna o atributo sem validação
            set // gravar o atributo
            {//quantidade de passageiros no carro tem que ser entre 2 e 7
                if ((value >= 2) && (value <= 7))
                {
                    capacidade = value;
                }
                else
                {
                    throw new Exception("O carro pode ter capacidade de 2 a 7 pessoas.");
                }
            }
        }



        public int PotenciaCv { get; set; }

        public override void Abastecer(double quantidadeLitros)
        {
            QuantidadeCombustivel += quantidadeLitros;
            Console.WriteLine($"Carro abastecido com {quantidadeLitros} litros de gasolina.");
        }

        public override void Mover(double distanciaKm)
        {// se a quantidade de combustival é compativel com o parametro passado
            if (QuantidadeCombustivel > (distanciaKm / 10))
            {
                QuantidadeCombustivel -= (distanciaKm / 10);
                Console.WriteLine($"Carro se moveu por {distanciaKm} km.");
            }
            else //caso a quantidade de combustivel não seja suficiente
            {
                Console.WriteLine("Não há combustível para percorrer a distância informada.");
            }
        }


        public override void Frear()
        {
            Console.WriteLine("Acionando os freios AbS... PAROU!.");
        }

        public Carro(int pesoKg, DateTime dataFabricacao, int capacidade = 5) : base (pesoKg, dataFabricacao) 
        {//se não informar a capacidade, será de 5 passageiros
            Capacidade = capacidade;
        }











    }
}
