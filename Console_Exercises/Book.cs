namespace Console_Exercises;

public class Book
{
    public string Title { get; private set; }
    public string Author { get; private set; }
    public int PublicationYear { get; private set; }
    public string Genre { get; private set; }
    public string Publisher { get; private set; }

    public void SetTitle(string title)
    {
        Title = title;
    }

    public void SetAuthor(string author)
    {
        Author = author;
    }

    public void SetPublicationYear(int publicationYear)
    {
        PublicationYear = publicationYear;
    }

    public void SetGenre(string genre)
    {
        Genre = genre;
    }
    
    public void SetPublisher(string publisher)
    {
        Publisher = publisher;
    }
}