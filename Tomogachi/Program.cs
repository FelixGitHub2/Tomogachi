Tamagotchi tama = new();

Tamagotchi myTomo = new Tamagotchi();

Console.WriteLine("What is your tomogachis name?");

while (myTomo.GetAlive() == true)
{
    Console.Clear();
    myTomo.PrintStats();
    Console.WriteLine("What do you wanna do?");
    Console.WriteLine("$1. Teach {myTomo.name} a new word");
    Console.WriteLine("$2. Feed {myTomo.name}");
    Console.WriteLine("$3. Talk with {myTomo.name}");
    Console.WriteLine("$4. Do Nothing");

    string doWhat = Console.ReadLine();
    if (doWhat == "1")
    {
        Console.WriteLine("What word do you wanna teach?");
        string word = Console.ReadLine();
        myTomo.Teach(word);
    }

    if (doWhat == "2")
    {
        myTomo.Feed();
    }

    if (doWhat == "3")
    {
        myTomo.Hi();
    }
    else
    {
        Console.WriteLine("nothing lol");
    }
    myTomo.Tick();

}

Console.WriteLine("${myTama.name} died u suck lol");

Console.ReadLine();