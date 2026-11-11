namespace cSH_hw_GC;

class Piesa : IDisposable
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public int Year { get; set; }

    public Piesa(string title, string author, string genre, int year)
    {
        Title = title;
        Author = author;
        Genre = genre;
        Year = year;
    }

    public void Dispose()
    {
        Console.WriteLine("Dispose called");
    }
    ~Piesa()
    {
        Console.WriteLine("the object is being deleted by the garbage collector. ");
    }
}