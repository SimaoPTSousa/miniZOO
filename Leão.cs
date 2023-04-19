public class Leão : Mamifero
{
    public int TamanhoDoGrupo { get; set; }
    public Leão(string nome, int idade, int tamanhoDoGrupo) : base(nome, idade) { 
        TamanhoDoGrupo = tamanhoDoGrupo;
    }
    public override string EmitirSom() => "Sporting!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!";
}