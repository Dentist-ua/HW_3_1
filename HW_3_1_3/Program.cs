//Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
//Потрібно: Створити класи Point та Figure. Клас Point повинен містити два цілих поля і одне рядкове поле.
//Створити три властивості одним методом доступу get. Створити власний конструктор, у тілі якого проініціалізуйте поля значеннями аргументів.
//Клас Figure повинен містити конструктори, які приймають від 3 до 5 аргументів типу Point.
//Створити два методи: double LengthSide(Point A, Point B), що розраховує довжину сторони багатокутника; void PerimeterCalculator(), що розраховує периметр багатокутника.
//Написати програму, яка виводить на екран назву та периметр багатокутника.


class Point
{
    public int X { get; }
    public int Y { get; }
    public string Field3 { get; }

    public Point(int x, int y, string field3) //Конструктор в якому ініціалізую дані
    {
        Console.WriteLine("Enter field1");
        var input1 = Console.ReadLine();
        int.TryParse(input1, out x );
        {
            X = x;
        }
        
        Console.WriteLine("Enter field2");
        var input2 = Console.ReadLine();
        int.TryParse(input2, out y );
        {
            Y = y;
        }
        Console.WriteLine("Enter field3");
        Field3 = Console.ReadLine();
        
    }
}




class Figure
{
    public Figure(int x, int y)
    {
        
    }
    
}