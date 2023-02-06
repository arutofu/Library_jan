using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Library_jan
{
    internal class Console
    {
        //Выводит текст при открытии программы и после каждого выполнения расчета/ошибки.
        static void WriteText()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("- 1: Площадь круга");
            System.Console.WriteLine("- 2: Площадь треугольника");
            System.Console.WriteLine("- 3: Выход");
            System.Console.WriteLine();
        }

        //Переход к следующей задаче, выбранной пользователем. Повышает читаемость.
        static sbyte GoNext()
        {
            return Convert.ToSByte(System.Console.ReadLine());
        }

        //Проверка введенной пользователем строки. Является ли строка числом.
        public static string isNumber(string number)
        {
            if (double.TryParse(number, out double outValue_Rad) == true)
            {
                return outValue_Rad.ToString();
            }
            else
            {
                return "error";
            }
        }

        static void Main(string[] args)
        {
            WriteText();
            sbyte currentNumber = GoNext();

            while (currentNumber != 3)
            {
                switch (currentNumber)
                {
                    //Площадь круга
                    case 1:
                        try
                        {
                            System.Console.WriteLine("Введите радиус круга");
                            string radius = System.Console.ReadLine();

                            if (isNumber(radius) != "error")
                            {
                                var circle = new Circle("Круг", Convert.ToDouble(radius));

                                string currentShape = circle.ToString();
                                System.Console.WriteLine(currentShape + " Площадь = " + circle.Square());

                                WriteText();
                                currentNumber = GoNext();
                            }
                            else
                            {
                                System.Console.WriteLine("Введенное значение не является числом");
                                WriteText();
                                currentNumber = GoNext();
                                break;
                            }
                            break;
                        }
                        catch (Exception e)
                        {
                            System.Console.WriteLine(e.Message);
                            WriteText();
                            currentNumber = GoNext();
                            System.Console.ReadKey();
                            break;
                        }

                    //Площадь треугольника
                    case 2:
                        double EdgeA, EdgeB, EdgeC;
                        try
                        {
                            System.Console.WriteLine("Введите 1 сторону треугольника из 3");
                            string strTriangle;

                            if (isNumber(strTriangle = System.Console.ReadLine()) != "error")
                            {
                                EdgeA = Convert.ToDouble(strTriangle);
                                System.Console.WriteLine("Введите 2 сторону треугольника из 3");
                                if (isNumber(strTriangle = System.Console.ReadLine()) != "error")
                                {
                                    EdgeB = Convert.ToDouble(strTriangle);
                                    System.Console.WriteLine("Введите 3 сторону треугольника из 3");
                                    if (isNumber(strTriangle = System.Console.ReadLine()) != "error")
                                    {
                                        EdgeC = Convert.ToDouble(strTriangle);
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("Сторона 3 не является числом");
                                        WriteText();
                                        currentNumber = GoNext();
                                        break;
                                    }
                                }
                                else
                                {
                                    System.Console.WriteLine("Сторона 2 не является числом");
                                    WriteText();
                                    currentNumber = GoNext();
                                    break;
                                }
                            }
                            else
                            {
                                System.Console.WriteLine("Сторона 1 не является числом");
                                WriteText();
                                currentNumber = GoNext();
                                break;
                            }
                        var triangle = new Triangle("Треугольник", EdgeA, EdgeB, EdgeC);
                        var result = triangle.Square();
                        string currentShape = triangle.ToString();
                        System.Console.WriteLine(currentShape + " Площадь = " + result);
                        }
                        catch (Exception e)
                        {
                            System.Console.WriteLine(e.Message);
                            WriteText();
                            currentNumber = GoNext();
                            break;
                        }

                        WriteText();
                        currentNumber = GoNext();
                        break;

                    //Выход
                    case 3:
                        currentNumber = 3;
                        break;

                    //Пользователь выбрал case, которого нет в предложенном выборе
                    default:
                        {
                            System.Console.WriteLine("Выберите один из предложенных вариантов");
                            WriteText();
                            currentNumber = GoNext();
                            break;
                        }
                }
            }
        }
    }
}
