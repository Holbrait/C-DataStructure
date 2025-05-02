// written by Holbrait
// 02/27/25

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int YearPublished { get; set; }

    public Book(string title, string author, int yearPublished)
    {
        Title = title;
        Author = author;
        YearPublished = yearPublished;
    }

    public override string ToString()
    {
        return Title + " by " + Author + " (" + YearPublished + ")";
    }
}
