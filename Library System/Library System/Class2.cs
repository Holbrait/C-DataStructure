// written by Holbrait
// 02/27/25

public class EBook : Book
{
    public double FileSizeMB { get; set; }

    public EBook(string title, string author, int yearPublished, double fileSizeMB)
        : base(title, author, yearPublished)
    {
        FileSizeMB = fileSizeMB;
    }

    public override string ToString()
    {
        return Title + " by " + Author + " (" + YearPublished + "), File Size: " + FileSizeMB + "MB";
    }
}
