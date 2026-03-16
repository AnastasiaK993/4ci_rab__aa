using GeometryShape2;
namespace TestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 0)]
        [InlineData(0, 1)]

        public void GeometryShape_if_input_data_be_incorrect_Rectangle(double a, double b)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Rectangle(a, b));
        }

        [Theory]
        [InlineData(5, 5)]
        public void GeometryShape_Area_Rectangle(double a, double b)
        {
            Rectangle Rectangle_object = new Rectangle(a, b);
            double Rezult = a * b;
            Assert.Equal(Rezult, Rectangle_object.Area());
        }
        [Theory]
        [InlineData(5, 5)]
        public void GeometryShape_Perimeter_Rectangle(double a, double b)
        {
            Rectangle Rectangle_object = new Rectangle(a, b);
            double Rezult = (a + b) * 2;
            Assert.Equal(Rezult, Rectangle_object.Perimeter());
        }
        [Theory]
        [InlineData(5, 5)]
        public void GeometryShape_ToString_Rectangle(double a, double b)
        {
            Rectangle Rectangle_object = new Rectangle(a, b);

            Assert.Equal($"{Rectangle_object.Width}.{Rectangle_object.Height}.{Rectangle_object.Area()}.{Rectangle_object.Perimeter()}", Rectangle_object.ToString());
        }




      




    }
}