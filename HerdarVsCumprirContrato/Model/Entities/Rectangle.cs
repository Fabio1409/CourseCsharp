using System.Globalization;


namespace HerdarVsCumprirContrato.Model.Entities
{
    class Rectangle : AbstractShape
    {
        public double width {  get; set; }
        public double height { get; set; }

        public override double Area()
        {
            return width * height;
        }

        public override string ToString()
        {
            return "Rectangle color = "
                + Color
                + ", width = "
                + width.ToString("f2", CultureInfo.InvariantCulture)
                + ", height = "
                + height.ToString("f2", CultureInfo.InvariantCulture)
                + ", area = "
                + Area().ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
