//Потрібно: Створити клас із ім'ям Rectangle. У тілі класу створити два поля, що описують довжини сторін double side1, side2.
//Створити власний конструктор Rectangle(double side1, double side2), у тілі якого поля side1 і side2 ініціалізуються значеннями аргументів.
//Створити два методи, що обчислюють площу прямокутника - double AreaCalculator() та периметр прямокутника - double PerimeterCalculator().
//Створити дві властивості double Area та double Perimeter з одним методом доступу get.
//Написати програму, яка приймає від користувача довжини двох сторін прямокутника і виводить на екран периметр та площу.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter side1");
        var input1 = Console.ReadLine();
        double.TryParse(input1, out double side1);
        
        Console.WriteLine("Enter side1");
        var input2 = Console.ReadLine();
        double.TryParse(input2, out double side2);

        Rectangle rectangle = new Rectangle(side1, side2);

        double area = rectangle.AreaCalculator;

        double perimetr = rectangle.PerimeterCalculator;

        Console.WriteLine($"{area}, {perimetr}");

    }

    //static void Rectangle(double side1, double side2)
    //{
    //    
    //}
}


class Rectangle
{
    private double side1;
    private double side2;
    
    public Rectangle(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }
    public double AreaCalculator
    {
        get
        {
            return side1 * side2;
        }
        
    }

    public double PerimeterCalculator
    {
        get
        {
            return 2 * (side1 + side2);
        }
    }
    
    
}