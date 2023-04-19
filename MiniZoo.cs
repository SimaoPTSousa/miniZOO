using System;
using System.Collections.Generic;

public class MiniZoo
{
    private List<Animal> _animais;

    public MiniZoo()
    {
        _animais = new List<Animal>();
    }
    public void AddAnimal(Animal animal)
    {
        _animais.Add(animal);
    }
    public void EmitirSomDeTodosOsAnimais()
    {
        foreach (Animal animal in _animais)
        {
            Console.WriteLine(animal.EmitirSom());
        }
    }
    public void ImprimirTodosOsAnimais()
    {
        foreach (Animal animal in _animais)
        {
            Console.WriteLine(animal.Nome + " " + animal.Idade + animal.GetType().Name);
            
        }
    }
}
