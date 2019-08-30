using System;
using System.Collections.Generic;

namespace Sonda.Nasa.ConsoleApp
{
    public class Planalto
    {
        public Planalto(uint x, uint y)
        {
            Sondas = new List<Sonda>();
            Cartesiano = new Point2D(x, y);
        }

        private List<Sonda> Sondas { get; set; }

        public Point2D Cartesiano { get; set; }

        public Sonda AddSonda(Sonda sonda)
        {
            if (sonda.X >= Cartesiano.X)
                throw new ArgumentException("O X da sonda é maior do que do planalto!");

            if (sonda.Y >= Cartesiano.Y)
                throw new ArgumentException("O Y da sonda é maior do que do planalto!");

            sonda.SetArea(this);
            Sondas.Add(sonda);
            return sonda;
        }
    }
}