using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Creating a list of shapes
        List<Shape> shapes = new List<Shape>();

        // Adding different shapes to the list
        shapes.Add(new Square("Red", 4));
        shapes.Add(new Rectangle("Blue", 5, 3));
        shapes.Add(new Circle("Green", 2.5));

        // Iterating through the list and displaying each shape's color and area
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea():F2}\n");
        }
    }
}
