static void Main(string[] args)
{
    

    Player newPlayer = new Player(0, name, 10, 10, 1, 0);

    

    newPlayer.Inventory.Add(new Weapon(World.ITEM_ID_RUSTY_SWORD, "Rusty sword", 5, 10));

    Console.WriteLine("At the beginning you received a Rusty Sword!");

    foreach (Weapon item in newPlayer.Inventory)
    {
        Console.WriteLine(item.Name);
    }

    
}

private static void PrintMenu()
{
    Console.WriteLine("Avalible actions:");
    Console.WriteLine("\t0 - Quit");
    Console.WriteLine("\t1 - Start fighting!");
    Console.WriteLine("\t2 - Check your items");
    Console.WriteLine("\t3 - Check the level of experience");
    Console.WriteLine("\t4 - Choose a difficulty level");
    Console.Write("Choose action: ");
}



    DifficultyLevel difficultyLevel = new SelectDifficultyLevel();






    int action = int.Parse(Console.ReadLine()); // wczytaj numer polecenia
    switch (action)
    {
        case 0:
            break;
        case 1:
            break;
        case 2:
            Console.WriteLine();
            break;
        case 3:
            Console.WriteLine();
            break;
    }
}