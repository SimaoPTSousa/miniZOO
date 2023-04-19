public class Cobra : Reptil
{
    public double Comprimento { get; set; }
    public Cobra(string nome, int idade, double comprimento) : base(nome, idade) { 
        Comprimento = comprimento;
    }
    public override string EmitirSom() => "Benfica é merda!!!!!!!!!!!!!!!!!!";
}