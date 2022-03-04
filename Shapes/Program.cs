using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeInventory SI = new ShapeInventory();
            SI.add(new Circle(3, 5, 2));
            SI.add(new Circle(1, 2, 1));
            SI.add(new Square(3, 9, 2));
            SI.add(new EditBox(3, 5, 2, 7));
            SI.listElements();
            Console.ReadKey();
        }
    }
}

