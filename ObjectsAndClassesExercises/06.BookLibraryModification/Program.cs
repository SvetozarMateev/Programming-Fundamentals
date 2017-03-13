using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

public class Library
{
    public string Name { get; set; }
    public List<Book> Books { get; set; }
}
public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public DateTime ReleaseDate { get; set; }
    public string ReleaseDateInStringFormat { get; set; }
    public string ISBN { get; set; }
    public double Price { get; set; }

    public static Book ReadBook()
    {
        Book book = new Book();
        string[] input = Console.ReadLine().Split(' ').ToArray();
        book.Title = input[0];
        book.Author = input[1];
        book.Publisher = input[2];
        book.ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
        book.ISBN = input[4];
        book.Price = double.Parse(input[5]);
        book.ReleaseDateInStringFormat = input[3];
        return book;
    }
}
public class Program
{

    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Library books = new Library();
        
        List<Book> temporary = new List<Book>();
        for (int i = 0; i < n; i++)
        {
            Book input = Book.ReadBook();
           temporary.Add(input);
        }
        books.Books = temporary;
        DateTime earliest = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
        foreach (var book in books.Books.OrderBy(x=>x.ReleaseDate).ThenBy(x=>x.Title))
        {
            if(book.ReleaseDate>earliest)
                Console.WriteLine($"{book.Title} -> {book.ReleaseDateInStringFormat}");
        }
    }
}

