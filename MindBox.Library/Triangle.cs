using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox.Library
{
    public class Triangle : Shape
    {
        public double Square { get; private set; }

        private double _ab = 0.0, _bc = 0.0, _ca = 0.0;

        public Triangle(double ab, double bc, double ca, string shapeName = "Triangle")
        {
            _ab = ab;
            _bc = bc;
            _ca = ca;
            ShapeName = shapeName;
        }
        public bool IsRightTriangle()
        {
            return (_ab == (_bc * _bc + _ca * _ca)) || (_bc == (_ca * _ca + _ab * _ab)) || (_ca == (_ab * _ab + _bc * _bc));
        }
        private void validateTriangle()
        {
            if (_ab < 0 || _bc < 0 || _ca < 0)
            {
                throw new ArgumentOutOfRangeException("Длинны сторон не могут быть меньше нуля");
            }
            if (_ab > (_ca + _bc) || _ca > (_bc + _ab) || _bc > (_ab + _ca))
            {
                throw new ArgumentOutOfRangeException("Одна из сторон больше суммы двух сторон. Это неканоничное событие.");
            }
        }

        public override double CalculateSquare()
        {
            validateTriangle();
            double p = (_ab + _bc + _ca) / 2;
            Square = Math.Sqrt((p) * (p - _ab) * (p - _bc) * (p - _ca));
            return Math.Round(Square, 1);
        }
    }
}
