// Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
// Потрібно: Створити клас Book. 
// Створити класи Title, Author та Content, кожен з яких повинен містити одне рядкове поле та метод void Show().
// Реалізуйте можливість додавання до книги назви книги, імені автора та змісту.
// Виведіть на екран різними кольорами за допомогою методу Show() назву книги, ім'я автора та зміст.

class Book
{
    private Title _title;
    private Author _author;
    private Content _content;

    public Book(Title title, Author author, Content content)
    {
        this._title = title;
        this._author = author;
        this._content = content;
    }

    public void PrintBook()
    {
        Console.WriteLine("Info for book");
        _title.Show();
        _author.Show();
        _content.Show();
    }
    
}
class Title
{
    public string title;

    public Title(string initTitle)
    {
        this.title = initTitle;
    }
    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Title: {title} ");
        Console.ResetColor();
    }   
}

class Author
{
    public string author;

    public Author(string initAuthor)
    {
        this.author = initAuthor;
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Author: {author}");
        Console.ResetColor();
    }
}

class Content
{
    public string content;

    public Content(string initContent)
    {
        this.content = initContent;
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Content: {content}");
        Console.ResetColor();
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter Title");
        string inputTitle = Console.ReadLine();
        Console.WriteLine("Enter Author");
        string inputAuthor = Console.ReadLine();
        Console.WriteLine("Enter Content");
        string inputContent = Console.ReadLine();

        Title bookTitle = new Title(inputTitle);
        Author bookAuthor = new Author(inputAuthor);
        Content bookContent = new Content(inputContent);

        Book myBook = new Book(bookTitle, bookAuthor, bookContent);
        
        myBook.PrintBook();

    }
}
