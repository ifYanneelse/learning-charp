using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana05
{
    class Pessoa
    {
        private string cpf;  //atributo
        private string CPF  // propriedade
        {
            get { return cpf; } //vai ler o cpf
            set // e quando receber número vai passar pela validação
            {
                if ((value.Length == 11) && value.HasOnlyDigits())//ovalor precisa de 11 digítios, se não, vai pra exceção 
                    cpf = value;
                else
                    throw new Exception("O CPF deve possuir 11 dígitos.");
            }
        }

        public string Nome { get; set; }    
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }  
        public double Peso { get; set; }
        public double Altura { get; set; }

        //propriedade calculada, não recebe valores, só calcula
        public double IMC
        {
            get //somente leitura
            {
                return (this.Peso / (this.Altura * this.Altura));
            }

        }

        //método construtor
        public Pessoa (string nome, string sobrenome, DateTime dataNascimento, string cpf)
        {
            this.Nome = nome;   
            this.Sobrenome = sobrenome;
            this.DataNascimento = dataNascimento;
            this.CPF = cpf;
        }

        public Pessoa (string nome, string sobrenome, DateTime dataNascimento, string cpf, 
            double peso, double altura) : this (nome, sobrenome, dataNascimento, cpf) //usando o construtor anterior
        {
            this.Peso = peso;
            this.Altura = altura;
        }

        //métodos sobrecarregados com parametros
        public void Comer(double pesoKg) //calcula quantos quilos comeu
        {
            this.Peso += pesoKg / 10; //quando comer vai aumentar 10% do peso que comeu
            Console.WriteLine($"{this.Nome} {this.Sobrenome} comeu {pesoKg}kg de comida.");
        }

        public void Comer(int calorias)
        {
            this.Peso += calorias / 30000; //aumenta 1kg a cada 30.000calorias
            Console.WriteLine($"{this.Nome} {this.Sobrenome} ingeriu {calorias} calorias.");
        }

        public void Correr(double distanciaKm, int dias = 1)//quantos dias correu, vai ser padrão = 1
        {   //o peso vai reduzir enquanto corre:
            this.Peso -= (distanciaKm / 40) * dias;
            Console.WriteLine($"{this.Nome} {this.Sobrenome} correu {distanciaKm} kms diários por {dias} dia(s).");
        }

        public void MostrarDados()
        {
            Console.WriteLine($"Nome completo: {this.Nome} {this.Sobrenome}");
            Console.WriteLine($"Idade: {Math.Truncate((DateTime.Now - this.DataNascimento).TotalDays / 365.25)}");
            //data atual menos a data de nascimento | totaldays = converte para dias em que vive até o momento 
            //divide por 365 dias e 25 é pelo ano bissexto - converte para anos
            //math.truncate remove a parte decimal e deixa inteiro
            Console.WriteLine($"IMC: {this.IMC:F2}"); //f2 = com duas casas decimais
        }









    
    }
}
