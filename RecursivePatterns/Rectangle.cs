﻿namespace RecursivePatterns
{
    class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public void Deconstruct(out int width, out int height, out Point point)
        {
            width = Width;
            height = Height;
            point = Point;
        }
    }
}
