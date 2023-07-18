namespace MindBox.Library
{
    public abstract class Shape
    {
        public string? ShapeName { get; set; } = "Shape";



        public abstract double CalculateSquare();
        public override string ToString()
        {
            return $"Площадь {ShapeName} равна " + CalculateSquare();
        }
    }
}