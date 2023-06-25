using System;

//2 Nephi 31:4-5

class Scripture
{
    private string _scripture;

    public void SetScripture(string scripture)
    {
        _scripture = scripture;
    }

    public string GetScripture()
    {
        return _scripture;
    }
}

class Reference
{
    private string _reference;

    public string GetReference()
    {
        return _reference;
    }

    public void SetReference(string reference)
    {
        _reference = reference;
    }
}

class Word
{
    static Scripture words = new Scripture();

    public void SetScripture(Scripture scripture)
    {
        words = scripture;
    }
    public string GetWords()
    {
        return words.GetScripture();
    }

    public void WordBuilder()
    {
        string[] word_list = words.GetScripture().Split(' ');

        string new_script = "";

        Random random = new Random();

        foreach (string word in word_list)
        {
            if (random.Next(4) == 0)
            {
                Console.Write("_".PadRight(word.Length, '_'));
                new_script += "_".PadRight(word.Length, '_');
            }
            else
            {
                Console.Write(word);
                new_script += word;
            }

            Console.Write(" ");

            new_script += " ";
        }
        words.SetScripture(new_script);
    }
}

class Program
{   
    static Scripture sc = new Scripture();
    static Reference rf = new Reference();
    static Word wd = new Word();

    static void Main(string[] args)
    { 

        Console.Clear();

        rf.SetReference("2 Nephi 31:4-5");

        sc.SetScripture("Wherefore, I would that ye should remember that I have spoken unto you concerning that prophet which the Lord showed unto me, that should baptize the Lamb of God, which should take away the sins of the world. And now, if the Lamb of God, he being holy, should have need to be baptized by water, to fulfil all righteousness, O then, how much more need have we, being unholy, to be baptized, yea, even by water!");
        
        Console.Write(sc.GetScripture());
        Console.Write(rf.GetReference());
        
        Console.Write("Press 'enter' to continue, type 'quit' to quit: ");
        
        string response = Console.ReadLine();

        wd.SetScripture(sc);

        while (response != "quit")
        {
            Console.Clear();
            wd.WordBuilder();
            if (wd.GetWords().Split('_').Length - 1 + wd.GetWords().Split(' ').Length - 1 == sc.GetScripture().Length)
            {
                break;
            }
            Console.Write("Press 'enter' to continue, type 'quit' to quit: ");
            response = Console.ReadLine();
        }
    }
}