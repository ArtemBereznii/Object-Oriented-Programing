using System;

class Program
{
    static void Main()
    {
        Segment segment = new Segment(0, 0, 3, 4);

        Console.WriteLine($"Coordinates: ({segment.X1}, {segment.Y1}) to ({segment.X2}, {segment.Y2})");
        Console.WriteLine($"Length: {segment.CalculateLength()}");
        Console.WriteLine($"Angle with OY axis: {segment.CalculateAngleWithOY()} degrees");
    }
}