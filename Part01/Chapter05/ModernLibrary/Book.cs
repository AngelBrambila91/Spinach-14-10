namespace LD.Shared;
using System.Diagnostics.CodeAnalysis;

public class Book
{
    public required string? Isbn;
    public required string? Title;
    public string? Author;
    public int PageCount;

    // Constructor for initializing required fields
    public Book()
    {
    }
    [SetsRequiredMembers]
    public Book(string? isbn, string? title)
    {
        Isbn = isbn;
        Title = title;
    }
}
