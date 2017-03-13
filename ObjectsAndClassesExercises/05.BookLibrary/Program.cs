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
    public string ISBN { get; set; }
    public double Price { get; set; }

    public static Book ReadBook()
    {
        Book book = new Book();
        string[] input = Console.ReadLine().Split(' ').ToArray();
        book.Title = input[0];
        book.Author = input[1];
        book.Publisher = input[2];
        book.ReleaseDate = DateTime.ParseExact(input[3], "dd-MM-YYYY", CultureInfo.InvariantCulture);
        book.ISBN = input[4];
        book.Price = double.Parse(input[5]);
        return book;
    }

}
public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<Book> books = new List<Book>();
        for (int i = 0; i < n; i++)
        {
            Book input = Book.ReadBook();
            books.Add(input);
        }
        Library answer = new Library();
        answer.Books = books;
        Dictionary<string, double> result = new Dictionary<string, double>();
        for (int i = 0; i < books.Count; i++)
        {

            if (result.ContainsKey(answer.Books[i].Author) == false)
                result.Add(answer.Books[i].Author, answer.Books[i].Price);
            else
                result[answer.Books[i].Author] += answer.Books[i].Price;


        }
        foreach (var pair in result.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{pair.Key} -> {pair.Value:f2}");
        }

    }
}

