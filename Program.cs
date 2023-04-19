class Program
{
    static void Main(string[] args)
    {
        MiniZoo miniZoo = new MiniZoo();
        Animal leao = new Leão("Leao", 7, 2);
        miniZoo.AddAnimal(leao);
        Animal cobra = new Cobra("Cobra", 5, 1);
        miniZoo.AddAnimal(cobra);
        miniZoo.EmitirSomDeTodosOsAnimais();
        miniZoo.ImprimirTodosOsAnimais();
    }

}
