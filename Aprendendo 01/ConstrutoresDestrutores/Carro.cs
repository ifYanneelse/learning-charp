using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutoresDestrutores
{
    internal class Carro : Veiculo //a classe carro herda de veículo | carro vai ter tudo o que o veiculo tem
    {
        public int Portas { get; set; } //get|set como propriedade automática
        public double Preco { get; set; }
        public string Modelo { get; set; } //usa o construtor base | o object


        //construtor padrão
        public Carro()
        {
            Console.WriteLine("um novo objeto CARRO foi criado\n");
        }

        //construtor que puxa a classe Veiculo, puxando o parametro inteiro ': base ()'
        public Carro(int pesoKg) : base(pesoKg)
        {
            Console.WriteLine($"um novo objeto CARRO com peso {this.PesoKg} foi criado\n");
        }

        //construtor personalizado - recebe parâmetro

        /*
        public Carro(string modelo)
        {
            this.Modelo = modelo; //this=c3
        }
        */
        public Carro(string modelo) : this() //this invoca construtor padrão, depois bota o que foi add
        {
            this.Modelo = modelo;
        }


        //construtor que recebe todos os parâmetros
        /*
        public Carro(string modelo, int portas, double preco)
        {
            this.Modelo = modelo;
            this.Portas = portas;
            this.Preco = preco;
        }
        */
        public Carro(string modelo, int portas, double preco) : this(modelo) //chamando o construtor anterior
        {
            //this.Modelo = modelo; //já foi chamado no parametro
            this.Portas = portas;
            this.Preco = preco;
        }


        //método destrutor
        ~Carro()
        {
            Console.WriteLine("Um objeto CARRO foi DESTRUÍDO");
        }



    }
}
