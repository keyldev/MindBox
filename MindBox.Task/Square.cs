using MindBox.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBox.Task
{
    internal class Square : Shape
    {
        public double SideA { get; set; }
        public Square(double a)
        {
            SideA = a;
            // or
            //ShapeName = "Name";
        }

        public override double CalculateSquare()
        {
            return Math.Round(SideA * SideA, 1);
        }
    }
}
