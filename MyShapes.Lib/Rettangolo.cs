using System.Reflection;

namespace MyShapes
{
    public class Rettangolo : Shape
    {
        private int _width;
        private int _height;

        public Rettangolo(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public int GetWidth() => _width;
        public void SetWidth(int width) => _width = width;

        public override int CalcArea() => _width * _height;
    }
}