using BookAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BookAPI.Contexts
{
    public class BookCollectionContext: DbContext
    {
        public BookCollectionContext(DbContextOptions<BookCollectionContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; } = null!;
        public DbSet<Author> Authors { get; set; } = null!;
        public DbSet<Genre> Genres { get; set; } = null!;
    }
}
