using System;

public class Point
{
    public int X { get; }
    public int Y { get; }
    public string Label { get; }

    // Конструктор класу Point
    public Point(int x, int y, string label)
    {
        X = x;
        Y = y;
        Label = label;
    }
}

public class Figure
{
    private Point[] points;

    // Конструктор для фігур з трьох точок
    public Figure(Point point1, Point point2, Point point3)
    {
        points = new Point[] { point1, point2, point3 };
    }
    // Конструктор для фігур з чотирьох точок
    public Figure(Point point1, Point point2, Point point3, Point point4)
    {
        points = new Point[] { point1, point2, point3, point4 };
    }
    // Конструктор для фігур з п'яти точок
    public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
    {
        points = new Point[] { point1, point2, point3, point4, point5 };
    }
    // Метод для розрахунку довжини сторони багатокутника
    private double LengthSide(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }
    // Метод для розрахунку периметра багатокутника
    public void PerimeterCalculator()
    {
        double perimeter = 0;

        for (int i = 0; i < points.Length; i++)
        {
            int nextIndex = (i + 1) % points.Length;
            perimeter += LengthSide(points[i], points[nextIndex]);
        }
        Console.WriteLine($"Назва багатокутника: {points.Length}-кут");
        Console.WriteLine($"Периметр багатокутника: {perimeter}");
    }
}

class Program
{
    static void Main()
    {
        // Створення об'єкта класу Figure з використанням конструктора
        Point pointA = new Point(0, 0, "A");
        Point pointB = new Point(1, 0, "B");
        Point pointC = new Point(0, 1, "C");
        Point pointD = new Point(0, 1, "D");

        Figure triangle = new Figure(pointA, pointB, pointC, pointD);

        // Виведення інформації про фігуру
        triangle.PerimeterCalculator();
    }
}