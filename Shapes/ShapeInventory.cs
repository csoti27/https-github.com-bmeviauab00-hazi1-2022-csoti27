using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class ShapeInventory
    {
        private List<IShape> shapeList;

        public ShapeInventory()
        {
            shapeList = new List<IShape>();
        }

        public void add(IShape s)
        {
            shapeList.Add(s);
        }

        public void listElements()
        {
            foreach (IShape sb in shapeList)
            {
                Console.WriteLine("A(n) {0} at coordinates ({1},{2}) with the are of: {3}", sb.getType(), sb.getX(), sb.getY(), sb.getArea());

            }
        }
    }
}
