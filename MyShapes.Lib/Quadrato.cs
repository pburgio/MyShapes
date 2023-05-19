using System.Diagnostics;
using System.Drawing;

namespace MyShapes
{
    public class Quadrato : Shape
    {
        private int _width;

        public Quadrato(int width)
        {
            _width = width;
        }

        public int GetWidth() => _width;
        public void SetWidth(int width) => _width = width;
        
        public override int CalcArea() => _width * _width;
    }

    /// <summary>
    /// This implementation breaks Liskov if Quadrato inherits from Rettangolo.
    /// From this perspective, a Quadrato is *not* a Rettangolo
    /// </summary>
    public class Quadrato_ThisBreaks_Liskov : Rettangolo
    {
        public Quadrato_ThisBreaks_Liskov(int width) : base(width, width)
        {
            
        }
    }
}
