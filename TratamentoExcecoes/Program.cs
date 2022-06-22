using System;

namespace TratamentoExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Começou...\n");

            //DividirNumeroPor(0);
            //AcessarVetor(9);
            //ConverterObjetoParaString(null);
            //ConverterObjetoParaInteiro("abc");

            //versão 1:
            //ObterPosicaoDePalavraEmTexto("aprendedo");
            //versão 2:
            //ObterPosicaoDePalavraEmTexto(null);

            //ObterArquivoParaEscrita("C:\\Teste.txt");

        //assitir video https://www.youtube.com/watch?v=NVC-YB29hto&list=PL0YuSuacUEWsHR_a22z31bvA2heh7iUgr&index=21
        //Triangulo t1 = new Triangulo(30, 12, 12);
        //Console.WriteLine(WebCEP.ObterEndereco("29306490"));

        Console.WriteLine("\n-------------------------------------");
            Console.WriteLine("Executou depois da exceção");

        }

        static void DividirNumeroPor(int divisor)
        {
            try
            {
                Console.WriteLine(10/divisor);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não é possível dividir por zero");
            }
        }


        static void AcessarVetor(int indiceElemento)
        {
            string[] palavras = { "Estamos", "aprendendo", "a", "tratar", "exceções", "em", "C#" };

            try
            {
                Console.WriteLine(palavras[indiceElemento]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Não há palavra no indice informado");
            }
        }

        static void ConverterObjetoParaString(object obj)
        {
            try
            {
                Console.WriteLine(obj.ToString());
            }
            catch (NullReferenceException e) //e é opcional, a mensagem vai pra ela
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("tradução: Referência do objeto não definido para uma instancia do objeto");
            }
        }

        static void ConverterObjetoParaInteiro(object obj)
        {
            try
            {
                //Console.WriteLine(Convert.ToInt32(obj));
                Console.WriteLine((int)(obj)); //funciona os dois modos
            }
            catch (Exception e) //e é opcional, a mensagem vai pra ela
            {
                if (e is FormatException || e is InvalidCastException)
                Console.WriteLine($"O objeto passado comoparâmetro não põde ser convertido para inteiro");               
            }

        }

        static void ObterPosicaoDePalavraEmTexto(string palavra)
        {
            string texto = "estamos aprendendo a tratar exceções em c#.";

            try
            {
                Console.WriteLine(texto.IndexOf(palavra)); //vai dar -1 por não achar
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine($"Ocorreu um erro: {e.Message}" +
                    $"\nCódigo do erro: {e.HResult}");
            }
        }

        static StreamWriter ObterArquivoParaEscrita(string caminho)
        {
            if (caminho is null)//primeiro verifica se o caminho é nulo
            {
                Console.WriteLine("Você não informou um caminho para o arquivo.");
                return null;
            }

            try //começa o tratamento de exceção
            {
                var fs = new FileStream(caminho, FileMode.Open);//FileMode.CreateNew caso não exista, criar um novo caminho
                return new StreamWriter(fs); //objeto que cria um arquivo
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("O arquivo não pôde ser encontrado.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("O diretório não pôde ser encontrado.");
            }
            catch (DriveNotFoundException)
            {
                Console.WriteLine("O disco não pôde ser encontrado.");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("O caminho do arquivo excede o tamanho máximo.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Você não tem permissão para acessar o arquivo.");
            }
            catch (IOException e) when ((e.HResult & 0x0000FFFF) == 32)
            {
                Console.WriteLine("Há uma violação de compartilhamento de arquivo.");
            }
            catch (IOException e) when ((e.HResult & 0x0000FFFF) == 80)
            {
                Console.WriteLine("O arquivo já existe");
            }
            catch (IOException e)
            {
                Console.WriteLine($"Uma exceção ocorreu:\nCódigo do erro: " +
                    $"{e.HResult & 0x0000FFFF}\nMensagem: {e.Message}");
            }
            return null;

        }


    }


}
