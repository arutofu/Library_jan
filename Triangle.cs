using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_jan
{
    //Triangle наследуется от базового класса Shape.
    public class Triangle : Shape
    {
        public double EdgeA { get; set; }
        public double EdgeB { get; set; }
        public double EdgeC { get; set; }

        //Triangle состоит из трех сторон и названия фигуры.
        public Triangle(string typeName, double a, double b, double c) : base(typeName)
        {
            if (isExist(a, b, c))
            {
                EdgeA = a;
                EdgeB = b;
                EdgeC = c;
            }
        }
        
        //Переопределение метода,рассчитывающего площадь из класса Shape.
        public override double Square()
        {
            var p = (EdgeA + EdgeB + EdgeC) / 2;
            var square = Math.Sqrt(p * (p - EdgeA) * (p - EdgeB) * (p - EdgeC));
            return square;
        }

        //Проверка на то, существует ли фигура по некоторым условиям.
        private bool isExist(double a, double b, double c)
        {
            //Как минимум одна из сторон меньше, либо равна нулю.
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new TriangleException("Такого треугольника не существует (сторона(ы) меньше, либо равна(ы) 0)");
            }

            //Одна из сторон больше суммы двух других.
            if (a > (b + c) || b > (a + c) || c > (a + b))
            {
                throw new TriangleException("Такого треугольника не существует (сторона больше суммы двух других)");
            }

            return true;
        }

        //Проверка на то, является ли треугольник прямоугольным.
        public bool isStraightTriangle()
        {
            //Формула A^2 = B^2 + C^2.
            bool isStraight = (EdgeA == Math.Sqrt(Math.Pow(EdgeB, 2) + Math.Pow(EdgeC, 2))
                            || EdgeB == Math.Sqrt(Math.Pow(EdgeA, 2) + Math.Pow(EdgeC, 2))
                            || EdgeC == Math.Sqrt(Math.Pow(EdgeA, 2) + Math.Pow(EdgeB, 2)));

            return isStraight;
        }
    }
}
