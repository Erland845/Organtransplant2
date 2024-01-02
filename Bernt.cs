using System;

public class Bernt
{
    public string Name { get; set; }
    public int Kidney { get; set; }

    public Bernt(string name, int kidney)
    {
        Name = name;
        Kidney = kidney;
    }
    public void PrintInfoBernt()
    {
        Console.WriteLine($"{Name} has {Kidney} kidneys");
    }
    public void ReceiveKidney(int amount)
    {
        if (amount > 0)
        {
            Kidney += amount;
        }
        else
        {
            Console.WriteLine("Ugyldig input. Ingen endring");
        }
    }

}
