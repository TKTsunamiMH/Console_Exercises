namespace Console_Exercises;

public class Movie
{
    public string Title { get; private set; }
    public int ReleaseYear { get; private set; }
    public int LengthInMinutes { get; private set; }
    public string Genre { get; private set; }

    public void SetTitle(string title)
    {
        Title = title;
    }

    public void SetReleaseYear(int releaseYear)
    {
        ReleaseYear = releaseYear;
    }

    public void SetLengthInMinutes(int lengthInMinutes)
    {
        LengthInMinutes = lengthInMinutes;
    }

    public void SetGenre(string genre)
    {
        Genre = genre;
    }
}