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





