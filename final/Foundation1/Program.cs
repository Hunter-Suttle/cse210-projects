using System;
using System.Collections.Generic;

public abstract class Media
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    public List<Comment> Comments { get; set; }

    public Media(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public abstract int GetNumberOfComments();
}

public class Video : Media
{
    public Video(string title, string author, int length) : base(title, author, length)
    {
    }

    public override int GetNumberOfComments()
    {
        return Comments.Count;
    }
}

public class Comment
{
    public string Name { get; set; }
    public string Text { get; set; }

    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Media> mediaList = new List<Media>();

        Media video1 = new Video("Funny Cats", "Sam", 120);
        video1.Comments.Add(new Comment("Tim", "Super funny! lol"));
        video1.Comments.Add(new Comment("Tom", "I hate cats..."));
        video1.Comments.Add(new Comment("Tony", "10/10 would recommend"));
        mediaList.Add(video1);

        Media video2 = new Video("Laughing Baby Compilation", "Brooke", 180);
        video2.Comments.Add(new Comment("Bill", "Aww adorable!"));
        video2.Comments.Add(new Comment("Bob", "Reminds me of my babies when I was young"));
        video2.Comments.Add(new Comment("Brad", "Could not stop laughing!"));
        mediaList.Add(video2);

        Media video3 = new Video("How to Change a Tire", "Jane", 240);
        video3.Comments.Add(new Comment("Jim", "Saved my life! I was stuck on the freeway"));
        video3.Comments.Add(new Comment("Joe", "Very helpful for people"));
        video3.Comments.Add(new Comment("Jack", "Audio was terrible. Could barely hear anything with the wind."));
        mediaList.Add(video3);

        foreach (Media media in mediaList)
        {
            Console.WriteLine("Title: " + media.Title);
            Console.WriteLine("Author: " + media.Author);
            Console.WriteLine("Number of comments: " + media.GetNumberOfComments());
            Console.WriteLine("Length: " + media.Length + " seconds");
            Console.WriteLine();

            Console.WriteLine("Comments:");
            foreach (Comment comment in media.Comments)
            {
                Console.WriteLine(comment.Name + ": " + comment.Text);
            }

            Console.WriteLine();
        }
    }
}
