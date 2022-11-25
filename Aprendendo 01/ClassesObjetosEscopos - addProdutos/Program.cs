using System;
using System.Collections.Generic; //pra listas


class MainClass {
    private static List<Produto> produtos = new List<Produto>(); //criando uma lista de produtoS vazia
    public static void Main(string[] args) {
        Console.WriteLine("Classes, Objetos e Escopos de Visibilidade");

        string comandoEscolhido; 

        do {
            //exibição do menu
            Console.Clear(); //limpa a tela
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1 - Cadastrar produto");
            Console.WriteLine("2 - Listar produtos");
            Console.WriteLine("S - Sair");

            //leitura da opção desejada pelo usuário:
             Console.Write("Opção: ");
             comandoEscolhido = Console.ReadKey().KeyChar.ToString().ToUpper();
             //readkey=le apenas uma tecla e muda
             //keychar = transforma em tipo de char
             //tostring - toupper = transforma em string pra poder converter em maiuscula

            switch (comandoEscolhido) {
                case "1":
                    Console.Write("\nNome do produto: ");
                    string nome = Console.ReadLine();
                    Console.Write("Preco do produto: ");
                    string preco = Console.ReadLine();

                    Produto novoProduto = new Produto(nome, Convert.ToDouble(preco)); //cria o objeto produto
                    produtos.Add(novoProduto);                     //adiciona o novo produto na lista de produtos
                    Console.WriteLine("Produto adicionado com sucesso!");
                    break;

                case "2":    
                    if (produtos.Count > 0) {

                        Console.WriteLine("\n________Listagem de produtos_______");
                        
                        foreach (Produto p in produtos) { //para cada produto 'p' dentro da lista de produtos
                            Console.WriteLine(p.ObterTexto());
                        }

                        Console.WriteLine("Pressione qualquer tecla para prosseguir...");
                        Console.ReadKey(); //espera uma tecla
                    } else
                        Console.WriteLine("\nNão há produtos cadastrados.");                                        
                    break;

                case "S":
                    Console.WriteLine("\nObrigado por usar o programa.");
                    break;

                default:
                    Console.WriteLine("\nOpção inválida! Tente novamente");
                    break;
            }

        } while (comandoEscolhido != "S");

    }
}