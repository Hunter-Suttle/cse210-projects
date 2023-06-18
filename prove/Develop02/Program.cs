using System;
using System.Collections.Generic;
using System.IO;

class WriteDisplay
{
    public void GetPrompt(List<string> journal_entries)
    {
        List<string> prompts = new List<string>();

        prompts.Add("Who was the most interesting person I interacted with today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");
        prompts.Add("What are 10 things you are grateful for?");
        prompts.Add("What is one thing I did today that I am proud of?");
        prompts.Add("What is something you saw today that was beautiful?");

        Random rand_prompt = new Random();
        int index = rand_prompt.Next(0,7);
        Console.WriteLine(prompts[index]);
        Console.Write("> ");

        string date_time = DateTime.Now.ToString();
        string response = Console.ReadLine();
        string prompt = prompts[index];

        string journal_entry = "Date and Time: " + date_time + " Prompt: " + prompt + " Response: " + response;
        journal_entries.Add(journal_entry);
        Console.WriteLine(journal_entry);
    }

    public void Display(List<string> journal_entries)
    {
        Console.WriteLine("Journal Entries:");

        foreach (string entry in journal_entries)
            Console.WriteLine(entry);
    }
}
class ReadWrite
{
    public void Save_File(List<string> journal_entries)
    {
        Console.WriteLine("Enter the name of the file:");
        Console.Write("> ");
        string fileName = Console.ReadLine();

        using (TextWriter writer = File.CreateText(fileName))
        {
            foreach (string entry in journal_entries)
            writer.WriteLine(entry);
        }
    }

    public void Load_File(List<string> journal_entries)
    {
        Console.WriteLine("Enter the name of the file:");
        Console.Write("> ");
        string fileName = Console.ReadLine();

        string[] lines = File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            journal_entries.Add(line);
        }
    }
}
class Program
{   
    static List<string> journal_entries = new List<string>();
    static WriteDisplay wd = new WriteDisplay();
    static ReadWrite rw = new ReadWrite();
    static void Main(string[] args)
    {
        int menu_number = 0;
        while (menu_number != 5)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1 Write");
            Console.WriteLine("2 Display");
            Console.WriteLine("3 Save");
            Console.WriteLine("4 Load");
            Console.WriteLine("5 Quit");
            Console.Write("> ");
            
            string menu = Console.ReadLine();
            menu_number = int.Parse(menu);
            
            if (menu_number == 1)
                {wd.GetPrompt(journal_entries);}

            if (menu_number == 2)
                {wd.Display(journal_entries);}

            if (menu_number == 3)
                {rw.Save_File(journal_entries);}

            if (menu_number == 4)
                {rw.Load_File(journal_entries);}
        }
    }
}