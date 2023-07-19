using System;

public class Address
{
    private string street;
    private string city;
    private string state;
    private string zip;

    public Address(string street, string city, string state, string zip)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.zip = zip;
    }

    public override string ToString()
    {
        return $"{street}, {city}, {state} {zip}";
    }
}

public abstract class Event
{
    protected string title;
    private string description;
    protected DateTime date;
    private TimeSpan time;
    private Address address;

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public abstract string GetStandardDetails();
    public abstract string GetFullDetails();
    public abstract string GetShortDescription();

    protected string GetEventDetails()
    {
        return $"{title}\n{description}\n{date.ToShortDateString()} {time.ToString()}\n{address.ToString()}";
    }
}

public class Lecture : Event
{
    private string speakerName;
    private int capacity;

    public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speakerName, int capacity) : base(title, description, date, time, address)
    {
        this.speakerName = speakerName;
        this.capacity = capacity;
    }

    public override string GetStandardDetails()
    {
        return GetEventDetails();
    }

    public override string GetFullDetails()
    {
        return $"{GetEventDetails()}\nSpeaker: {speakerName}\nCapacity: {capacity}";
    }

    public override string GetShortDescription()
    {
        return $"Lecture: {title} on {date.ToShortDateString()}";
    }
}

public class Reception : Event
{
    private string rsvpEmail;

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail) : base(title, description, date, time, address)
    {
        this.rsvpEmail = rsvpEmail;
    }

    public override string GetStandardDetails()
    {
        return GetEventDetails();
    }

    public override string GetFullDetails()
    {
        return $"{GetEventDetails()}\nRSVP Email: {rsvpEmail}";
    }

    public override string GetShortDescription()
    {
        return $"Reception: {title} on {date.ToShortDateString()}";
    }
}

public class OutdoorGathering : Event
{
   private bool isWeatherGood;

   public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address) : base(title, description, date, time, address)
   {
       // Assume weather is good by default.
       isWeatherGood = true;
   }

   public void SetWeather(bool isWeatherGood)
   {
       this.isWeatherGood = isWeatherGood;
   }

   public override string GetStandardDetails()
   {
       return GetEventDetails();
   }

   public override string GetFullDetails()
   {
       return $"{GetEventDetails()}\nWeather: {(isWeatherGood ? "Good" : "Bad")}";
   }

   public override string GetShortDescription()
   {
       return $"Outdoor Gathering: {title} on {date.ToShortDateString()}";
   }
}

class Program
{
   static void Main(string[] args)
   {
       Address address1 = new Address("123 Main St", "Seattle", "WA", "98101");
       Address address2 = new Address("456 5th St", "New York", "NY", "10001");
       Address address3 = new Address("789 10th St", "Las Vegas", "NV", "88901");

       Lecture lecture1 = new Lecture("Business Lecture", "Come hear from some of the most outstanding professionals in business!", new DateTime(2023, 7, 20), new TimeSpan(10, 0 ,0), address1, "Bill Gates", 50);

       Reception reception1 = new Reception("Wedding Reception", "Bob and Sally would love it if you came to celebrate their union with them.", new DateTime(2023, 7 ,21), new TimeSpan(18 ,0 ,0), address2, "rsvp@example.com");

       OutdoorGathering outdoorGathering1 = new OutdoorGathering("Lake Party", "Meet us on the lake for an evening of music, food, and fun.", new DateTime(2023, 7, 22), new TimeSpan(18, 0, 0), address3);

       Console.WriteLine(lecture1.GetFullDetails());
       Console.WriteLine();
       Console.WriteLine(lecture1.GetShortDescription());
       Console.WriteLine();
       Console.WriteLine(lecture1.GetStandardDetails());
       Console.WriteLine();

       Console.WriteLine(reception1.GetFullDetails());
       Console.WriteLine();
       Console.WriteLine(reception1.GetShortDescription());
       Console.WriteLine();
       Console.WriteLine(reception1.GetStandardDetails());
       Console.WriteLine();

       Console.WriteLine(outdoorGathering1.GetFullDetails());
       Console.WriteLine();
       Console.WriteLine(outdoorGathering1.GetShortDescription());
       Console.WriteLine();
       Console.WriteLine(outdoorGathering1.GetStandardDetails());
   }
}