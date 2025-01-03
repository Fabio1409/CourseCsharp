﻿
using MetodosAbstratos.Entities.Enums;
namespace MetodosAbstratos.Entities
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
       

        public Rectangle(double width, double height, Color color)
            : base(color)
        {
            Height = height;
            Width = width;
        }

        public override double Area()
        {
            return Width * Height;// retangulo
        }
    }
}
