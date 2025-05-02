// written by Holbrait
// 02/27/25

public class PrintedBook : Book
{
    public int PageCount { get; set; }

    public PrintedBook(string title, string author, int yearPublished, int pageCount)
        : base(title, author, yearPublished)
    {
        PageCount = pageCount;
    }

    public override string ToString()
    {
        return Title + " by " + Author + " (" + YearPublished + "), Pages: " + PageCount;
    }
}
