using System;

public class Vector2D
{
    private double length; // Довжина вектора
    private double angle;  // Кут вектора (в радіанах)

    // Конструктори
    public Vector2D()
    {
        length = 0;
        angle = 0;
    }

    public Vector2D(double l, double a)
    {
        length = l;
        angle = a;
    }

    public Vector2D(Vector2D other)
    {
        length = other.length;
        angle = other.angle;
    }

    // Методи
    public void Rotate(double angle)
    {
        this.angle += angle;
    }

    public double GetLength()
    {
        return length;
    }

    public double GetAngle()
    {
        return angle;
    }

    // Перевантаження оператора додавання
    public static Vector2D operator +(Vector2D v1, Vector2D v2)
    {
        double x1 = v1.length * Math.Cos(v1.angle);
        double y1 = v1.length * Math.Sin(v1.angle);

        double x2 = v2.length * Math.Cos(v2.angle);
        double y2 = v2.length * Math.Sin(v2.angle);

        double x = x1 + x2;
        double y = y1 + y2;

        double newLength = Math.Sqrt(x * x + y * y);
        double newAngle = Math.Atan2(y, x);

        return new Vector2D(newLength, newAngle);
    }

    // Перевантаження оператора множення на скаляр
    public static Vector2D operator *(Vector2D v, double scalar)
    {
        return new Vector2D(v.length * scalar, v.angle);
    }

    // Виведення вектора на екран
    public void Print()
    {
        Console.WriteLine($"Length: {length}, Angle: {angle} radians");
    }
}