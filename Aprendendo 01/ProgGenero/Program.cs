/* //não roda com 2 Main

class MainClass {
    public static void Main(string[] args)
    {
        int n1 = 3;
        double n2 = 3.4;
        string s1 = "Ricardo";
        char c1 = '@';
        Console.WriteLine($"{n1}, {n2}, {s1}, {c1}"); //$ = formata a frase
        Console.WriteLine($"{n1} + {n2} + {s1} + {c1}");
        double n3 = n1+n2; //n3 é double porque n2 é double
        Console.WriteLine(n3);
        Console.WriteLine($"A soma é {n3}.");
        Console.WriteLine($"A soma é {n3:F4}."); //f4 para mostrar casas decimais, acrescenta 0s

        n3 +=5; //Atribuição composta vai somar
        Console.WriteLine($"A nova soma é {n3:F4}."); 

        Console.WriteLine("\n"); //estruturas condicionais
        bool ehPar = (n1 % 2 == 0);
        if (!ehPar) // não é par
        {
            Console.WriteLine("O número é ímpar.");
        } else {
            Console.WriteLine("O número é par.");
        }
       
       Console.WriteLine("\n"); //estruturas de seleção múltipla
       switch (n1)
       {
            case 1:
                Console.WriteLine("O valor é 1");
                break;
            case 2:
                Console.WriteLine("O valor é 2");
                break;
            case 3:
                Console.WriteLine("O valor é 3");
                break;
            case 4:
                Console.WriteLine("O valor é 4");
                break;
            default:
                Console.WriteLine("O valor não está entre 1 e 4");
                break;
       }

       Console.WriteLine("\n"); //estruturas de repetição baseada em condição
       int i = 0;
       while (i<10) // vai até 9, até 10 (i<=10)
       {
           Console.WriteLine($"Iteração {i}");
           i++;
       }

       Console.WriteLine("_______________");

        int j = 0;
       while (j<10) // vai até 9, até 10 (i<=10)
       {
           Console.WriteLine($"Iteração {j}");
           j++;
           if (j==5){ //vai até o 4
               break;
           }
           //j++ pra imprimir até o 5
       }
       
       Console.WriteLine("\n"); //estruturas de repetição baseado em contador
       for (int l=0; l<10; l++){
           Console.WriteLine($"Iteração {l}");
           if (l == 5){
               break;
           }
       }
       Console.WriteLine("_______________");
       for (int m=0; m<10; m++){
           if (m == 5){
               continue; // pula o 5
           }
           Console.WriteLine($"Iteração {m}");
       }
       Console.WriteLine("_______________");
       i = 10;
       do
       {
           i--;
           if(i == 5){ //pula o número 5 
               continue;
           }
           Console.WriteLine($"Iteração {i}");
       } while (i > 0);

       Console.WriteLine("_______________");

       Console.WriteLine("\n"); //saída e entrada de dados
       Console.Write("Digite seu nome: "); //write = o usuário digita na frente da frase
       string r1 =  Console.ReadLine();
       Console.WriteLine($"O seu nome é {r1} e possui {ContarLetras()} caracteres."); //ContarLetras(r1) = conta o nome digitado
       Mostrar(); // chama o método Mostrar
    }

    //métodos - funções e procedimentos
    public static void Mostrar(){
        Console.WriteLine("estes são os dados: ");
        Console.WriteLine("Rua estrela do norte, 10");
    }

    public static int ContarLetras(string palavra = "seu nome"){ //string palavra = leva o nome digitado | deafault palavra="seu nome" deve ir por último
        return palavra.Length;
    } 
    //recebe parâmetro, precisa de um retorno
    // imprimie 8 caracteres porcausa do "seu nome"

    
}
*/