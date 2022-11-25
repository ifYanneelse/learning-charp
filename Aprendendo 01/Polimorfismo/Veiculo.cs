using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    //modelo com propriedades relevantes veiculo em geral
    public abstract class Veiculo //classe de um veículo genérico qualquer
    {
        public int PesoKg { get; set; }

        public DateTime Datafabricacao { get; set; }    

        public double QuantidadeCombustivel { get; set; }   
        
        //pra dizer que tipo de objeto é: onibus, carro, etc
        public string Tipo { get { return this.GetType().Name; } } //propriedade só de leitura

        public abstract int Capacidade { get; set; } //abstrata, deve ser implementada em todas que herdam veiculo




        public abstract void Abastecer(double quantidadeLitros);
        public abstract void Mover(double distanciaKm);

        public virtual void Frear() //tem implementação e é opcional aos descendentes
        {
            Console.WriteLine("Acionando os freios... PAROU!");
        }



        //construtor
        public Veiculo(int pesoKg, DateTime dataFabricacao)
        {
            PesoKg = pesoKg;
            Datafabricacao = dataFabricacao;
        }
    }
}
