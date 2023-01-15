using Microsoft.Extensions.Hosting;

namespace BookAPI.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime DeathDate { get; set; }

        public virtual List<Book>? Books { get; set; }


    }
}
