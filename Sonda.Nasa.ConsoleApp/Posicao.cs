namespace Sonda.Nasa.ConsoleApp
{
    public class Posicao
    {
        public Posicao(uint x, uint y, EApontamentos olhandoPara)
        {
            OlhandoPara = olhandoPara;
            XY = new Point2D(x, y);
        }

        public EApontamentos OlhandoPara { get; set; }

        public Point2D XY { get; private set; }

        public void Atualizar(uint x, uint y)
        {
            XY = new Point2D(x, y);
        }

        public override string ToString() => $"({XY.X}, {XY.Y}, {OlhandoPara})";
    }
}