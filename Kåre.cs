using System;

public class Kåre
{
    public int Kidney { get; set; }
    public string Name { get; set; }

    public Kåre(int kidney, string name)
    {

        Kidney = kidney;
        Name = name;

    }
    public void PrintInfoKåre()
    {

        Console.WriteLine($"{Name} has {Kidney} kidneys");

    }
    public void Donatekidney(int amount)
    {
        if (amount > 0 && amount <= Kidney)
        {
            Kidney -= amount;
        }
        else
        {
            Console.WriteLine("Ugyldig tall. Ingen endring ble gjort");
        }
    }

}