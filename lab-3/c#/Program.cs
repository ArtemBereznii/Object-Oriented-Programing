using System;

class Program
{
    static void Main(string[] args)
    {
        Vector2D Z1 = new Vector2D(); 
        Vector2D Z2 = new Vector2D(3.0, 0.0); 
        Vector2D Z3 = new Vector2D(Z2); 

        Console.WriteLine("Initial vectors:");
        Console.Write("Z1: "); Z1.Print();
        Console.Write("Z2: "); Z2.Print();
        Console.Write("Z3: "); Z3.Print();

        Z3 = Z3 * 2;
        Console.WriteLine("\nAfter scaling Z3 by 2:");
        Console.Write("Z3: "); Z3.Print();

        Z3.Rotate(Math.PI / 2);
        Console.WriteLine("\nAfter rotating Z3 by 90 degrees:");
        Console.Write("Z3: "); Z3.Print();

        Z1 = Z2 + Z3;
        Console.WriteLine("\nAfter adding Z2 and Z3 (result in Z1):");
        Console.Write("Z1: "); Z1.Print();
    }
}