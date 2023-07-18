using MindBox.Library;

namespace MindBox.Task
{
    /*
     Задание:
     Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. 
        Дополнительно к работоспособности оценим:
            - Юнит-тесты
            - Легкость добавления других фигур
            - Вычисление площади фигуры без знания типа фигуры в compile-time
            - Проверку на то, является ли треугольник прямоугольным
     */

    // Test project for MindBox.Library
    internal class Program
    {
        static void Main(string[] args)
        {
            // для примера, ToString()
            var circle = new Circle("Circle 1", 4);
            Console.WriteLine(circle.ToString());
            var triangle = new Triangle(8, 2, 2);
            
            Console.WriteLine($"Площадь {triangle.IsRightTriangle()}");

            var square = new Square(4);
            Console.WriteLine(square.ToString());

            Console.ReadKey();
        }
    }
}