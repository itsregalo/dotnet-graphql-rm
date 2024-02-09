using graphRM.Data;
using graphRM.Data.Entities;
using graphRM.DTO;
using HotChocolate;

namespace graphRM.GraphQL;

public class MutationType
{
     public async Task<Book> CreateBookAsync([Service] LibraryDbContext context, BookDto newBook)
     {

        var book = new Book {
            BookName = newBook.Name,
            Price = newBook.Price,
        };

        context.Book.Add(book);
        await context.SaveChangesAsync();
        return book;
    }

    public async Task<Book> UpdateBookAsync([Service] LibraryDbContext context, Guid id,  BookDto updatedBook)
    {
        var book = await context.Book.FindAsync(id) 
            ?? throw new ArgumentException("Book Not Found");

        book.BookName = updatedBook.Name;
        book.Price = updatedBook.Price;

        await context.SaveChangesAsync();
        return book;
    }

    public async Task<string> DeleteBookAsync([Service] LibraryDbContext context, Guid id)
    {
        var book = await context.Book.FindAsync(id)
         ?? throw new ArgumentException("Book Item dows Not Exist");

        context.Book.Remove(book);
        await context.SaveChangesAsync();
        return "Book Deleted Successfully!";
    }
}