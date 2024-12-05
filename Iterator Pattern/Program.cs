using System;
using System.Collections;
using System.Collections.Generic;

public class Book
{
    public string Title { get; }
    public string Author { get; }
    public int Year { get; }

    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    public override string ToString()
    {
        return $"{Title} by {Author} ({Year})";
    }
}

public class Library : IEnumerable<Book>
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public IEnumerator<Book> GetEnumerator()
    {
        return books.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

// Пример использования
public class Program
{
    public static void Main()
    {
        Library library = new Library();
        library.AddBook(new Book("1984", "George Orwell", 1949));
        library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", 1960));

        foreach (var book in library)
        {
            Console.WriteLine(book);
        }
    }
}