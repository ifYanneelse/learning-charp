using System;
using System.Text;
using System.IO;

class Produto {
    private string nome; // atributo private: só é visivel dentro da própria classe


    //2: criar Propriedades:
    //criar proteção | não armazenam valores
    //são pontes de acesso a um atributo (atributos = armazenam valores)
    //nome do produto não tenha menos de 2 letras
    public string Nome { //ter letra maiuscula
        get{ return nome; //valor lido pelo atributo nome
        } set { //quando alguem escrever:
            if(value.Length > 1) //se o valor escrito for maior que 1:
                nome = value; //armazena o novo value na variavel existente 'nome'
            else
                throw new Exception ("Nome do produto deve ter pelo menos 2 caracteres");
        }
    }

    /*
    private double preco;
    public double Preco {
        get {return preco;}
        set {preco = value;}
    }
    */

    //propriedades automáticas | mesmo que o acima
    public double Preco { get; set;}

    public int Estoque { get; private set; } //fora dessa classe, só pode ser lido e não modificado


    //3: criar método construtor da classe Produto
    public Produto(){ //método construtor tem o mesmo nome da classe, é público e não possui tipo de retorno
        this.Estoque = 0; //todo novo objeto terá estoque 0
    }
    //this = é o objeto criado no momento
    public Produto(string nome, double preco){
        this.Nome = nome; //Nome recebe o que vem do parâmetro 'nome'
        this.Preco = preco;
        this.Estoque = 0;
    }

    //criando método-ação
    public int Vender(int qtde) {
        if (this.Estoque - qtde >= 0) //se tiver estoque, diminuir quantidade
        this.Estoque -= qtde; 
        return this.Estoque;
    }

    public int Comprar(int qtde) {
        this.Estoque += qtde;
        return this.Estoque;
    }

    public string ObterTexto() {
        StringBuilder sb = new StringBuilder();
        sb.Append($"\nNome: {this.Nome}\n");
        sb.Append($"Preço: {this.Preco}\n");
        sb.Append($"Estoque: {this.Estoque}\n");
        return sb.ToString();
    }









    
}