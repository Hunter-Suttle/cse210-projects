using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Please select the activity you wish to do:");
        Console.WriteLine();
        Console.WriteLine("1 - Breathing Activity");
        Console.WriteLine("2 - Reflection Activity");
        Console.WriteLine("3 - Listing Activity");
        Console.WriteLine();
        Console.WriteLine("(enter a number)");
        Console.WriteLine();
        Console.Write("-> ");
        string menu_choice = Console.ReadLine();
        Console.Clear();

        Activity a1 = new Activity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Activity a2 = new Activity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Activity a3 = new Activity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        
        if (menu_choice == "1")
        {
            Console.WriteLine(a1.GetActivity());
            Console.WriteLine();
            Console.WriteLine(a1.GetDescription());
            Console.WriteLine();
            Console.WriteLine(a1.GetDuration());
            a1.Pause();
            Breathing.BreatheIn();
            Breathing.BreatheOut();
            Breathing.BreatheIn();
            Breathing.BreatheOut();
            Console.Clear();
            a1.GoodJobMessage();
            Console.WriteLine(a1.GetActivity());
            Console.WriteLine();
            Console.WriteLine(a1.GetDescription());
            a1.EndingCountdown();
        }

        if (menu_choice == "2")
        {
            Console.WriteLine(a2.GetActivity());
            Console.WriteLine();
            Console.WriteLine(a2.GetDescription());
            Console.WriteLine();
            Console.WriteLine(a2.GetDuration());
            a2.Pause();
            Reflection.StartReflecting();
            Console.Clear();
            a2.GoodJobMessage();
            Console.WriteLine(a2.GetActivity());
            Console.WriteLine();
            Console.WriteLine(a2.GetDescription());
            a2.EndingCountdown();
        }

        if (menu_choice == "3")
        {
            Console.WriteLine(a3.GetActivity());
            Console.WriteLine();
            Console.WriteLine(a3.GetDescription());
            Console.WriteLine();
            Console.WriteLine(a3.GetDuration());
            a3.Pause();
            Listing.StartListing();
            Console.Clear();
            a1.GoodJobMessage();
            Console.WriteLine(a3.GetActivity());
            Console.WriteLine();
            Console.WriteLine(a3.GetDescription());
            a3.EndingCountdown();
        }
    }
}

public class Activity
{
    private string activity_name;

    private string _description;

    public Activity(string activity, string description)
    {
        activity_name = activity;

        _description = description;
    }

    public void EndingCountdown()
    {
        Console.WriteLine();
        Console.WriteLine("Please wait...");
        Console.Write("8");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("7");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("6");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("5");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("4");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("3");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1200);
        Console.Clear();
        Console.WriteLine("Ending Program...");
        Console.Write("5");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("4");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("3");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1200);
        Console.Clear();
    }

    public string GetActivity()
    {
        return $"Activity: {activity_name}";
    }

    public string GetDescription()
    {
        return $"Description: {_description}";
    }

    public string GetDuration()
    {
        Console.Write("Please enter how long you wish to do the activity for (in seconds): ");
        string dur = Console.ReadLine();
        int duration = int.Parse(dur);
        Console.WriteLine();

        return $"Duration: {duration} seconds";
    }

    public void GoodJobMessage()
    {
        Console.WriteLine("You did a great job!");
        Console.WriteLine();
        Console.WriteLine("Please wait for your activity summary...");
        Console.Write("5");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("4");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("3");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1200);
        Console.Clear();
    }

    public void Pause()
    {
        Thread.Sleep(2500);
        Console.WriteLine();
        Console.WriteLine("Please get ready to begin the activity...");
        Thread.Sleep(1200);
        Console.Write("10");
        Thread.Sleep(1200);
        Console.Write("\b \b\b");
        Console.Write("9");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("8");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("7");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("6");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("5");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("4");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("3");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1200);
        Console.Clear();
    }
}

public class Breathing
{
    public static void BreatheIn()
    {
        Console.Write("Breathe In... ");
        Console.Write("5");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("4");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("3");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1200);
        Console.Clear();
    }

    public static void BreatheOut()
    {
        Console.Write("Breathe Out... ");
        Console.Write("6");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("5");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("4");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("3");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1200);
        Console.Clear();
    }
}

public class Reflection
{
    static List<string> ref_prompts = new List<string>{
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };

    static List<string> follow_prompts = new List<string>{
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    static Random random = new Random();

    static string prompt1 = ref_prompts[random.Next(4)];

    static string follow1 = follow_prompts[random.Next(9)];

    static string follow2 = follow_prompts[random.Next(9)];

    static string follow3 = follow_prompts[random.Next(9)];

    public static void StartReflecting()
    {
        Console.WriteLine(prompt1);
        Console.WriteLine();
        Console.WriteLine("Reflect on the prompt above...");
        Thread.Sleep(1200);
        Console.Write("10");
        Thread.Sleep(1200);
        Console.Write("\b \b\b");
        Console.Write("9");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("8");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("7");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("6");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("5");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("4");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("3");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1200);
        Console.Clear();
        Console.WriteLine(follow1);
        Console.WriteLine();
        Console.WriteLine("Reflect on the prompt above...");
        Thread.Sleep(1200);
        Console.Write("10");
        Thread.Sleep(1200);
        Console.Write("\b \b\b");
        Console.Write("9");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("8");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("7");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("6");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("5");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("4");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("3");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1200);
        Console.Clear();
        Console.WriteLine(follow2);
        Console.WriteLine();
        Console.WriteLine("Reflect on the prompt above...");
        Thread.Sleep(1200);
        Console.Write("10");
        Thread.Sleep(1200);
        Console.Write("\b \b\b");
        Console.Write("9");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("8");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("7");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("6");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("5");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("4");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("3");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1200);
        Console.Clear();
        Console.WriteLine(follow3);
        Console.WriteLine();
        Console.WriteLine("Reflect on the prompt above...");
        Thread.Sleep(1200);
        Console.Write("10");
        Thread.Sleep(1200);
        Console.Write("\b \b\b");
        Console.Write("9");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("8");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("7");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("6");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("5");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("4");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("3");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1200);
    }
}

public class Listing
{
    static List<string> prompts = new List<string>{
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    static Random random = new Random();

    static string prompt = prompts[random.Next(5)];

    public static string GetPrompt()
    {
        return prompt;
    }

    public static void StartListing()
    {
        Console.WriteLine("Please consider the following prompt and list as many answers as you can. Separate your responses by using a comma and a space.");
        Console.WriteLine();
        Console.WriteLine($"Prompt: {GetPrompt()}");
        Console.WriteLine();
        Console.Write("Enter responses here: ");
        List<string> inputs = new List<string>();
        var line = Console.ReadLine();
        var input = line.Split(", ");
        foreach (string item in input)
        {
            inputs.Add(item);
        }
        Console.WriteLine();
        Console.WriteLine("Thank you for your responses. Please wait...");
        Thread.Sleep(1200);
        Console.Write("5");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("4");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("3");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1200);
        Console.Clear();
        Console.WriteLine("Here were your answers:");
        Console.WriteLine();
        foreach (string thing in inputs)
        {
            Console.WriteLine(thing);
        }
        Console.WriteLine();
        Console.WriteLine("Please wait...");
        Thread.Sleep(1200);
        Console.Write("5");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("4");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("3");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1200);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1200);
        Console.Clear();
    }
}