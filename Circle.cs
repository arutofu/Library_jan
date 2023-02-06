using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_jan
{
    //Circle наследуется от базового класса Shape.
    public class Circle : Shape
    {
        public double Radius { get; set; }

        //Circle состоит из радиуса и названия фигуры.
        public Circle(string typeName, double radius) : base(typeName)
        {
            if (isExist(radius))
            {
                Radius = radius;
            }
        }

        //Проверка на то, существует ли фигура по некоторым условиям.
        private bool isExist(double r)
        {
            //Радиус меньше, либо равен нулю.
            if (r <= 0)
            {
                throw new CircleException("Такого круга не существует, радиус меньше, либо равен 0");
            }

            return true;
        }

        //Переопределение метода,рассчитывающего площадь из класса Shape.
        public override double Square()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 1);
        }

    }
}
