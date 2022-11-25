class MainClass {
    public static void Main(string[] args) {
        Pessoa p1 = new Pessoa(); // objeto chamado p1 da classe Pessoa
        p1.Nome = "Ric";
        p1.Idade = 40;
        p1.Genero = 'M';
        //p1.Aprovado = false; //o atributo está privado na classe Pessoa
        p1.MostrarDados();


    }
}