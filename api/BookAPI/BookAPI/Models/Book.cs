using System.Reflection.Metadata;

namespace BookAPI.Models;

public class Book
{
    public int BookId {get;set;}
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? ISBN { get; set; }
    public int AuthorId { get; set; }
    public virtual Author? Author { get; set; }
    public virtual List<Genre>? Genres { get; set; }
}
