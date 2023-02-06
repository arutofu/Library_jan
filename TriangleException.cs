using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_jan
{
    //Класс для вызова исключений при работе с Треугольником. Исключения описываются в классе Triangle.
    public class TriangleException : Exception
    {
        public TriangleException(string message) : base(message)
        {

        }
    }
}
