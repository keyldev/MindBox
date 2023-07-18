using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox.Library
{
    public class Circle : Shape
    {
        private double _radius = 0.0;

        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }
        public double Square { get; private set; }

        public Circle(string shapeName, double radius)
        {
            ShapeName = shapeName;
            _radius = radius;
            validateCircle();
        }
        public override double CalculateSquare()
        {
            //S = π × r2 
            Square = Math.PI * _radius * _radius;
            return Math.Round(Square, 1);

        }
        private void validateCircle()
        {
            if (_radius <= 0.0)
            {
                throw new ArgumentOutOfRangeException("Радиус не может быть меньше или равен нулю");
            }
        }
    }
}
