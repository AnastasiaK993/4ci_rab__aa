using System;
using GeometryShape2;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class triangletest
    {
        [Theory]
        [InlineData(1, 0, 1)]
        [InlineData(0, 1, 1)]
        [InlineData(1, 1, 0)]
        //[InlineData(double.MaxValue+11,1 )]
        //[InlineData(11, double.MaxValue + 11)]
        public void GeometryShape_if_input_data_be_incorrect_Triangle(double a, double b, double c)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(a, b, c));
        }

        [Theory]
        [InlineData(5, 5, 5)]
        public void GeometryShape_Area_Triangle(double a, double b, double c)
        {
            Triangle Triangle_object = new Triangle(a, b, c);
            double p = Triangle_object.Perimeter() / 2;
            double Rezult = Math.Sqrt(p * (p - Triangle_object.SideA) * (p - Triangle_object.SideB) * (p - Triangle_object.SideC));

            Assert.Equal(Rezult, Triangle_object.Area());
        }
        [Theory]
        [InlineData(5, 5, 5)]
        public void GeometryShape_Perimeter_Triangle(double a, double b, double c)
        {
            Triangle Triangle_object = new Triangle(a, b, c);
            double Rezult = a + b + c;
            Assert.Equal(Rezult, Triangle_object.Perimeter());
        }
        [Theory]
        [InlineData(5, 5, 5)]
        public void GeometryShape_ToString_Triangle(double a, double b, double c)
        {
            Triangle Triangle_object = new Triangle(a, b, c);

            Assert.Equal($"{Triangle_object.SideA}.{Triangle_object.SideB}.{Triangle_object.SideC}.{Triangle_object.Area()}.{Triangle_object.Perimeter()}", Triangle_object.ToString());
        }


    }
}
