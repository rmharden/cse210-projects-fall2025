/*
Rebekah Harden
CSE 210: Programming with Classes
Brother Randall Booth
November 13, 2025

W09 Prepare: Learning Activity
Polymorphism Learning Activity
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning05 World!");

        // Step 7: Build a List
        List<Shape> _shapes = new List<Shape>();

        // Step 5: Test the Square class
        Square s1 = new Square("yellow", 5);
        // Console.WriteLine(s1.GetColor());
        // Console.WriteLine(s1.GetArea());

        //Step 6: Test the Rectangle class
        Rectangle r1 = new Rectangle("orange", 15, 10);
        // Console.WriteLine(r1.GetColor());
        // Console.WriteLine(r1.GetArea());

        // Step 6: Test the Circle class
        Circle c1 = new Circle("red", 5);
        // Console.WriteLine(c1.GetColor());
        // Console.WriteLine(c1.GetArea());

        // Step 7: Build a List
        _shapes.Add(s1);
        _shapes.Add(r1);
        _shapes.Add(c1);

        foreach (Shape shape in _shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}