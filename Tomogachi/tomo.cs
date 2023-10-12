using System.Reflection;

public class Tamagotchi
{
    private int hunger = 0;

    private int bordedom = 0;

    private List<string> words = new List<string>() {"yo"};

    private bool isAlive;

    private Random generator;

    public string name;

    public Tamagotchi()
    {
        generator = new Random();
        isAlive = true;
    }


    public void Feed()
    {

    }

    public void Hi()
    {

    }

    public void Teach(string word)
    {

    }

    public void Tick()
    {

    }

    public void PrintStats()
    {
        Console.WriteLine($"Name: {name} || Hunger: {hunger} || Boredom: {bordedom} || Vocabulary: {words.Count} words");
    }

    public bool isAlive()
    {

    }

    private void ReduceBoredom()
    {

    }
}