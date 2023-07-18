//Foundation 1

using System;
using System.Collections.Generic;

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    public List<Comment> Comments { get; set; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public int GetNumberOfComments()
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
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Funny Cats", "Sam", 120);
        video1.Comments.Add(new Comment("Tim", "Super funny! lol"));
        video1.Comments.Add(new Comment("Tom", "I hate cats..."));
        video1.Comments.Add(new Comment("Tony", "10/10 would recommend"));
        videos.Add(video1);

        Video video2 = new Video("Laughing Baby Compilation", "Brooke", 180);
        video2.Comments.Add(new Comment("Bill", "Aww adorable!"));
        video2.Comments.Add(new Comment("Bob", "Reminds me of my babies when I was young"));
        video2.Comments.Add(new Comment("Brad", "Could not stop laughing!"));
        videos.Add(video2);

        Video video3 = new Video("How to Change a Tire", "Jane", 240);
        video3.Comments.Add(new Comment("Jim", "Saved my life! I was stuck on the freeway"));
        video3.Comments.Add(new Comment("Joe", "Very helpful for people"));
        video3.Comments.Add(new Comment("Jack", "Audio was terrible. Could barely hear anything with the wind."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.Length + " seconds");
            Console.WriteLine("Number of comments: " + video.GetNumberOfComments());

            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine(comment.Name + ": " + comment.Text);
            }

            Console.WriteLine();
        }

        Console.ReadLine();
    }
}