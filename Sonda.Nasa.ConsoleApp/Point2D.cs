namespace Sonda.Nasa.ConsoleApp
{
    public struct Point2D
    {
        public Point2D(uint x, uint y)
        {
            X = x;
            Y = y;
        }
        
        public uint X { get; private set; }
        public uint Y { get; private set; }
    }
}