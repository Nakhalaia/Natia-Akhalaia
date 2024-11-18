public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
}

public class Library
{
    private List<Book> books = new List<Book>();

    public void PrintBooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("Books are not available");
            return;
        }

        foreach (var book in books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.Year}");
        }
    }

    public int Count
    {
        get { return books.Count; }
    }

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void RemoveBook(Book book)
    {
        if (books.Contains(book))
        {
            books.Remove(book);
        }
        else
        {
            Console.WriteLine("Book not found.");
        }
    }

    public List<Book> FindBooks(string title)
    {
        return books.FindAll(b => b.Title.Contains(title, StringComparison.OrdinalIgnoreCase));
    }

    public List<Book> FindBooksByAuthor(string author)
    {
        return books.FindAll(b => b.Author.Contains(author, StringComparison.OrdinalIgnoreCase));
    }
}

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();

        Book book1 = new Book { Title = "Pride and Prejudice", Author = "Jane Austen", Year = 1813 };
        library.AddBook(book1);
        Console.WriteLine("Added book: " + book1.Title);
        Console.WriteLine("Current book count: " + library.Count);

        Book book2 = new Book { Title = "A Christmas Carol", Author = "Charles Dickens", Year = 1843 };
        library.AddBook(book2);
        Console.WriteLine("Added book: " + book2.Title);
        Console.WriteLine("Current book count: " + library.Count);

        Book book3 = new Book { Title = "Animal Farm", Author = "George Orwell", Year = 1945 };
        library.AddBook(book3);
        Console.WriteLine("Added book: " + book3.Title);
        Console.WriteLine("Current book count: " + library.Count);

        Console.WriteLine("\nList of books in the library:");
        library.PrintBooks();

        Console.WriteLine("\nFinding books with title 'Animal Farm':");
        var foundBooks = library.FindBooks("Animal Farm");
        foreach (var book in foundBooks)
        {
            Console.WriteLine($"Found book: {book.Title} by {book.Author}, published in {book.Year}");
        }

        library.RemoveBook(book1);
        Console.WriteLine("\nAfter removing 'Pride and Prejudice':");
        library.PrintBooks();
        Console.WriteLine("Current book count: " + library.Count);

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
