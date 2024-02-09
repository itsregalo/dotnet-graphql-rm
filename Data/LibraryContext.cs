using graphRM.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace graphRM.Data;

public class LibraryDbContext: DbContext
{
    public LibraryDbContext(DbContextOptions<LibraryDbContext> options): base(options)
    {

    }
    public DbSet<Book> Book {get; set;}
}