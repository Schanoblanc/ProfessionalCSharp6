﻿using static System.Console;

namespace InheritanceWithConstructors
{
    public class Rectangle : Shape
    {
        public Rectangle(int width, int height, int x, int y)
            : base(width, height, x, y)
        {

        }

        public Rectangle()
            : base(width: 0, height: 0, x: 0, y: 0)
        {

        }

        public override void Draw() =>
            WriteLine($"Rectangle with {Position} and {Size}");

        public override void Move(Position newPosition)
        {
            Write("Rectangle ");
            base.Move(newPosition);
        }

    }

}