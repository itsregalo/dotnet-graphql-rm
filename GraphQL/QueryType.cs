using graphRM.Data;
using graphRM.Data.Entities;
using HotChocolate;
using Microsoft.EntityFrameworkCore;

namespace graphRM.GraphQL;

public class QueryType
{
    public async Task<List<Book>> getAllBooksAsync([Service] LibraryDbContext context)
    {
        return await context.Book.ToListAsync();
    }
}