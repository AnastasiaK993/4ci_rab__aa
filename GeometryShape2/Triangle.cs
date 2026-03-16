using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShape2
{
    public class Triangle : Shape
    {
        public double SideA;
        public double SideB;
        public double SideC;

        public Triangle(double one, double two, double cooltri)
        {
            if (one < 1 || two < 1 || cooltri < 1 || (double)one > double.MaxValue || (double)two > double.MaxValue || (double)cooltri > double.MaxValue)
            {
                throw new ArgumentOutOfRangeException("несоответствие диапозону значений для длины и ширины");
            }
            SideA = one;
            SideB = two;
            SideC = cooltri;
        }
        public override double Area()//площадь
        {
            double p = Perimeter() / 2;
            double area = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
            return area;
        }
        public override double Perimeter()//периметр
        {
            double perimeter = SideA + SideB + SideC;
            return perimeter;
        }
        public override string ToString()//информация
        {
            return $"{SideA}.{SideB}.{SideC}.{Area()}.{Perimeter()}";
        }
    }
}
