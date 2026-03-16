using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShape2
{
    public class Rectangle : Shape
    {
        public double Width;
        public double Height;
        public Rectangle(double one, double two)
        {
            if (one < 1 || two < 1 || (double)one > double.MaxValue || (double)two > double.MaxValue)
            {
                throw new ArgumentOutOfRangeException("несоответствие диапозону значений для длины и ширины");
            }
            Width = one;
            Height = two;
        }
        public override double Area()//площадь
        {

            double area = Width * Height;
            return area;
        }
        public override double Perimeter()//периметр
        {
            double perimeter = (Width + Height) * 2;
            return perimeter;
        }
        public override string ToString()//информация
        {
            return $"ширина={Width},высота={Height},площадь={Area()},периметр={Perimeter()}";
        }
    }
}
