using System;
using System.Runtime.InteropServices; //pra mensagem

namespace HerancaDeClasses
{
    class Aviao : Veiculo //aviao herda de veiculo
    {
        public int Passageiros { get; set; }
        public double Altitude { get; set; }
        public Aviao (double peso, double altura, double largura, double comprimento, int passageiros) : //int passageiros vem de aviao
            base (peso, altura, largura, comprimento)
        {
            this.Passageiros = passageiros;
            this.Altitude = 0; //começa com a altitude 0
            Console.WriteLine ("Um objeto do tipo AVIÃO foi criado");
            //estando na classe avião, herdeira da classe veículo, pode aqui puxar uma classe protected e mostrar no program
            Console.WriteLine($"Um objeto do tipo AVIÃO foi criado com densidade {this.Densidade:F2}Kg/m3."); 
        }

        ~Aviao()
        {
            Console.WriteLine("Um objeto do tipo avião foi DESTRUÍDO");
        }

        public void Voar (double distancia) //distancia que vai voar
        {
            this.Decolar(1000); //decola com 1000 metros de altitude
            double percorrida = 0; //começa com 0
            while (percorrida < distancia) //enquanto a percorrida for menor que a distancia que quer percorrer
            {
                Console.WriteLine($"Nosso avião está a {(distancia - percorrida):F2} metros de distancia do destino.");
                percorrida += 220; //vai aumentar 220 metros por segundo
                Thread.Sleep(1000); //pausa por 1 segundo - milesegundos
            }
            this.Pousar();
        }

        private void Pousar()
        {
            while (this.Altitude > 0) //enquanto a altitude do avião for maior que 0
            {
                Console.WriteLine($"Nosso avião está a {this.Altitude:F2} metros de altitude.");
                this.Altitude -= 60;
                this.Altitude = this.Altitude < 0 ? 0 : this.Altitude; //se altitude é menor que 0? se for positivo recebe 0, se não recebe o valor de altitude
                Thread.Sleep(1000); //pausa por 1 segundo - milesegundos
            }
            Console.WriteLine("Pouso concluído");
            Thread.Sleep(1000); //dorme mais um segundo

        }

        private void Decolar (int altitude)
        {
            while (this.Altitude < altitude) //enquanto a altitude atual do avião é menor que a altitude pretendida
            {
                Console.WriteLine($"Nosso avião está a {this.Altitude:F2} metros de altitude.");
                this.Altitude += 60; //vai aumentar 220 metros por segundo
                Thread.Sleep(1000); //pausa por 1 segundo - milesegundos
            }
            Console.WriteLine("Decolagem concluída");            
            Thread.Sleep(1000); //dorme mais um segundo
        }









    }
}
