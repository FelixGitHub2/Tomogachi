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
        hunger -=1;
    }

    public void Hi()
    {
        int wordNum = generator.Next(words.Count);
        Console.WriteLine($" [{name}] says: {words[wordNum]}");
        ReduceBoredom();
    }

    public void Teach(string word)
    {
        Console.WriteLine($" [{name}] learns: {word}");
        words.Add(word);
        ReduceBoredom();
    }

    public void Tick()
    {
        hunger ++;
        bordedom ++;
        if (hunger >= 10 || bordedom >= 10) 
        {
            isAlive = false;
        }
    }

    public void PrintStats()
    {
        Console.WriteLine($"Name: {name} || Hunger: {hunger} || Boredom: {bordedom} || Vocabulary: {words.Count} words");
    }

    public bool GetAlive()
    {
        return isAlive;
    }

    private void ReduceBoredom()
    {
        bordedom -= 2;
    }
}