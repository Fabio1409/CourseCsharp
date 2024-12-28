using System;
using HerdarVsCumprirContrato.Model.Entities;
using HerdarVsCumprirContrato.Model.Enums;
namespace HerdarVsCumprirContrato
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape s1 = new Circle()
            {
                Radius = 2.0,
                Color = Color.White

            };
            IShape s2 = new Rectangle() {width = 3.5, height = 4.2, Color = Color.Black };

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
