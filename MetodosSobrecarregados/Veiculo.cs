using System;
using System.Threading;


namespace MetodosSobrecarregados { 

    enum CorVeiculo
    {
        Branco,
        Preto,
        Vermelho,
        Prata,
        Grafite
    }

    class Veiculo
    {

        //propriedades
        public string Modelo { get; set; }
        public int Peso { get; set; }
        public double Velocidade { get; set; }
        public int Portas { get; set; }
        public CorVeiculo Cor { get; set; } //chama o enum CorVeiculo


        //3 versões sobrecarregadas de construtores
        public Veiculo(string modelo)
        {
            this.Modelo = modelo;
        }

        public Veiculo(string modelo, CorVeiculo cor) : this(modelo)
        {
            this.Cor = cor;
        }

        public Veiculo(string modelo, CorVeiculo cor, int portas = 4) : this(modelo, cor) //portas = 4 como valor padrão
        {
            this.Portas = portas;
        }

        public void MostrarDados()
        {
            Console.WriteLine($" Veiculo {this.Modelo} :: Cor {this.Cor} :: {this.Portas} portas");
        }

        public void MostrarDados(int nLinha) //recebe o número da linha
        {
            Console.WriteLine($" {nLinha}: Veiculo {this.Modelo} :: Cor {this.Cor} :: {this.Portas} portas");
        }


        //pra acelerar
        public void Acelelar()
        {
            this.Velocidade += 10;
        }

        public void Acelerar (int acrescimo)
        {
            this.Velocidade += acrescimo;
        }

        public void Acelerar(int acrescimoPorSegundo, double tempoSeg)
        {
            DateTime inicio = DateTime.Now;
            DateTime fim = inicio.AddSeconds(tempoSeg);
            while (inicio < fim)
            {
                this.Velocidade += acrescimoPorSegundo;
                Thread.Sleep(1000);
                Console.WriteLine($"Velocidade atual: {this.Velocidade:F2}");
                inicio = inicio.AddSeconds(1);
            }
            
        }


    }  
}
