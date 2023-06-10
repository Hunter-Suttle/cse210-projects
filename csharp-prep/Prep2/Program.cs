using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please insert your grade as a percentage: ");
        string percent = Console.ReadLine();
        double grade = double.Parse(percent);

        string letter = "";

        if (grade >= 90)
            letter = "A";
        else if (grade >= 80)
            letter = "B";
        else if (grade >= 70)
            letter = "C";
        else if (grade >= 60)
            letter = "D";
        else 
            letter = "F";

        Console.Write($"Your letter grade was {letter}. ");

        if (letter == "A" || letter == "B" || letter == "C")
            Console.Write("Congratulations! You passed the course!");
        else
            Console.Write("Unfortunately you did not pass the class. Better luck next term!");

    }
}