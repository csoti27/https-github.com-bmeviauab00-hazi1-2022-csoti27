using System;

namespace Shapes
{
    abstract class ShapeBase : IShape
    {
        protected int x;
        protected int y;

        protected ShapeBase(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public abstract string getType();
        public abstract int getArea();
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
    }

    class Square : ShapeBase
    {
        private int sideLength;

        public Square(int x, int y, int a) : base(x, y)
        {
            sideLength = a;
        }

        public override int getArea()
        {
            return sideLength * sideLength;
        }

        public override string getType()
        {
            return "Square";
        }
    }

    class Circle : ShapeBase
    {
        private int radius;

        public Circle(int x, int y, int radius) : base(x, y)
        {
            this.radius = radius;
        }

        public override int getArea()
        {
            return (int)(3.14 * radius * radius);
        }

        public override string getType()
        {
            return "Circle";
        }
    }

    class EditBox : Controls.Textbox, IShape
    {
        public EditBox(int x, int y, int w, int h) : base(x, y, w, h)
        { }
        public int getArea()
        {
            return GetWidth() * GetHeight();
        }

        public string getType()
        {
            return "EditBox";
        }

        public int getX()
        {
            return GetX();
        }

        public int getY()
        {
            return GetY();
        }
    }



}