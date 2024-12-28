using HerdarVsCumprirContrato.Model.Enums;


namespace HerdarVsCumprirContrato.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
