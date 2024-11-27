using System;
using projeto_DIO;

class Program
{
    public static void Main()
    {
        // Criando objetos polimorficamente
        SwordFighter Chrono = new SwordFighter("Chrono", 35, "SwordFighter", "Katana");
        Console.WriteLine(Chrono.ToString());
        Console.WriteLine(Chrono.Atack());
        Console.WriteLine(Chrono.Atack(1));

        Mage Luca = new Mage("Luca", 32, "Mage", "Fire Gun");
        Console.WriteLine(Luca.ToString());
        Console.WriteLine(Luca.Atack());
        Console.WriteLine(Luca.Atack(1));

        Healer Marle = new Healer("Marle", 30, "Healer", "Crossbow");
        Console.WriteLine(Marle.ToString());
        Console.WriteLine(Marle.Atack());
        Console.WriteLine(Marle.Atack(1));

        SwordFighter Frog = new SwordFighter("Frog", 33, "SwordFighter", "Long Sword");
        Console.WriteLine(Frog.ToString());
        Console.WriteLine(Frog.Atack());
        Console.WriteLine(Frog.Atack(1));

        Fighter Robo = new Fighter("Robo", 34, "Fighter", "Gloves");
        Console.WriteLine(Robo.ToString());
        Console.WriteLine(Robo.Atack());
        Console.WriteLine(Robo.Atack(1));

        Fighter Ayla = new Fighter("Ayla", 32, "Fighter", "Hands");
        Console.WriteLine(Ayla.ToString());
        Console.WriteLine(Ayla.Atack());
        Console.WriteLine(Ayla.Atack(1));

        Mage Magus = new Mage("Magus", 37, "Mage", "Magic Sickle");
        Console.WriteLine(Magus.ToString());
        Console.WriteLine(Magus.Atack());
        Console.WriteLine(Magus.Atack(1));

        Enemy Lavos = new Enemy("Lavos", 80, "Enemy", "Fangs");
        Console.WriteLine(Lavos.ToString());
        Console.WriteLine(Lavos.Atack());
        Console.WriteLine(Lavos.Atack(1));
    }
}