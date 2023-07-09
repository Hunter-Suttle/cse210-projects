using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager.Start();
    }
}

public abstract class Goal
{
    protected string _shortName;

    protected string _description;

    protected int _points;

    protected bool _IsComplete = false;

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        if (_IsComplete)
        return 
            String.Format("You have {0} points. \n [x] {1} \n {2}", _points, _shortName, _description);
        return
            String.Format("You have {0} points. \n [ ] {1} \n {2}", _points, _shortName, _description);
    }

    public abstract string GetStringRepresentation();

    public Goal(string name, string description, int points)
    {
        _shortName = name;

        _description = description;

        _points = points;
    }
}

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base (name, description, points)
    {

    }

    public override void RecordEvent()
    {
        _IsComplete = true;

        Console.WriteLine($"Congrats! You have earned {_points}.");
    }

    public override bool IsComplete()
    {
        return _IsComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName},{_description},{_points}";
    }
}

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base (name, description, points)
    {

    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congrats! You have earned {_points}.");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName},{_description},{_points}";
    }
}

public class ChecklistGoal : Goal
{
    private int _amountCompleted;

    private int _target;

    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base (name, description, points)
    {
        _target = target;

        _bonus = bonus;

        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        _amountCompleted += 1;

        if (_amountCompleted >= _target)
        {
            _IsComplete = true;
        }
    }

    public override bool IsComplete()
    {
        return _IsComplete;
    }

    public override string GetStringRepresentation()
    {
       return $"{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }

    public override string GetDetailsString()
    {
        return 
            //_points;

            $"{_shortName} ({_description}) Completed({_amountCompleted}/{_target})";
    }
}

public class GoalManager
{
    private List<string> _goals = new List<string>();

    private static int _score = 0;

    public static int menu_choice = 0;

    public static void Start()
    {
            while (menu_choice != 6)
            {
                Console.WriteLine($"You have {_score} points.");
                Console.WriteLine();
                Console.WriteLine("Please choose an option from the menu");
                Console.WriteLine("1 Create A New Goal");
                Console.WriteLine("2 Display Goals");
                Console.WriteLine("3 Save Goals");
                Console.WriteLine("4 Load Goals");
                Console.WriteLine("5 Record Event");
                Console.WriteLine("6 Quit");
                Console.Write("-> ");
                string menu_number = Console.ReadLine();
                menu_choice = int.Parse(menu_number);
            }
    }

    public int DisplayPlayerInfo()
    {
        return 0;
    }

    //public string ListGoalNames()
    //{
    //    foreach (string list in _goals)
    //    {
    //        Console.WriteLine(list);
    //    }
    //}
    
    public void CreateGoal()
    {

        Console.WriteLine("What type of goal will you create?");
        Console.WriteLine("1 Simple Goal");
        Console.WriteLine("2 Eternal Goal");
        Console.WriteLine("3 Checklist Goal");
        string goal_choice = Console.ReadLine();
        int goal_number = int.Parse(goal_choice);
        if (goal_number == 1)
        {
            Console.WriteLine("What is your goal name?");
            Console.Write("-> ");
            string tempgoal_name = Console.ReadLine();
            Console.WriteLine("What is a description of your goal?");
            Console.Write("-> ");
            string tempgoal_description = Console.ReadLine();
            Console.WriteLine("How many points do you want to assign to completing your goal?");
            Console.Write("-> ");
            string tempgoal_points = Console.ReadLine();
            int tempgoal_intpoints = int.Parse(tempgoal_points);

            SimpleGoal tempgoal = new SimpleGoal(tempgoal_name,tempgoal_description,tempgoal_intpoints);
        }
    }

    public void RecordEvent()
    {
        //Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
    }

    public void SaveGoals()
    {
        Console.WriteLine("Enter the name of the file:");
        Console.Write("-> ");
        string fileName = Console.ReadLine();

        using (TextWriter writer = File.CreateText(fileName))
        {
            foreach (string gol in _goals)
            writer.WriteLine(gol);
        }
    }

    public void LoadGoals()
    {
        Console.WriteLine("Enter the name of the file:");
        Console.Write("-> ");
        string fileName = Console.ReadLine();

        string[] lines = File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            _goals.Add(line);
        }
    }
}