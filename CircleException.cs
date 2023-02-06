using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_jan
{
    //Класс для вызова исключений при работе с Кругом. Исключения описываются в классе Circle.
    public class CircleException : Exception
    {
        public CircleException(string message) : base(message)
        {

        }
    }
}
