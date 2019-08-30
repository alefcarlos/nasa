namespace Sonda.Nasa.ConsoleApp
{
    public class Sonda
    {
        public Sonda(uint x, uint y, EApontamentos olhandoPara)
        {
            PosicaoInicial = Posicao = new Posicao(x, y, olhandoPara);
        }

        public Posicao Posicao { get; private set; }
        public Posicao PosicaoInicial { get; private set; }

        public Planalto Area { get; private set; }

        public uint X => Posicao.XY.X;
        public uint Y => Posicao.XY.Y;

        public EApontamentos OlhandoPara => Posicao.OlhandoPara;

        public override string ToString() => Posicao.ToString();

        private bool MoveX => OlhandoPara == EApontamentos.E || OlhandoPara == EApontamentos.W;

        private bool MoveY => !MoveX;
        public void SetArea(Planalto area)
        {
            Area = area;
        }

        public void Acao(EAcao acao)
        {
            switch (acao)
            {
                case EAcao.L:
                    GirarEsquerda();
                    break;

                case EAcao.R:
                    GirarDireita();
                    break;

                case EAcao.M:
                    Mover();
                    break;
            }
        }

        private (uint X, uint Y) NovasCoordenadas()
        {
            if (MoveX)
            {
                var subtratirX = MoveX && OlhandoPara == EApontamentos.W;

                if (subtratirX)
                {
                    //Validar bordas
                    if (X == 0)
                        return (X, Y);

                    return (X - 1, Y);
                }

                return (X + 1, Y);
            }


            //Então devemos mover Y
            var subtratirY = MoveY && OlhandoPara == EApontamentos.S;

            if (subtratirY)
            {
                //Validar bordas
                if (Y == 0)
                    return (X, Y);

                return (X, Y - 1);
            }

            return (X, Y + 1);
        }

        private void Mover()
        {
            //Devemos acrescentar ou diminuir
            var xy = NovasCoordenadas();

            //Nossa sonda não pode ultrapassar as boardas
            if (xy.X >= Area.Cartesiano.X)
                xy.X = Area.Cartesiano.X;

            //Nossa sonda não pode ultrapassar as boardas
            if (xy.Y >= Area.Cartesiano.Y)
                xy.Y = Area.Cartesiano.Y;

            Posicao.Atualizar(xy.X, xy.Y);
        }

        private void GirarEsquerda()
        {
            switch (Posicao.OlhandoPara)
            {
                case EApontamentos.N:
                    Posicao.OlhandoPara = EApontamentos.W;
                    break;

                case EApontamentos.W:
                    Posicao.OlhandoPara = EApontamentos.S;
                    break;

                case EApontamentos.S:
                    Posicao.OlhandoPara = EApontamentos.E;
                    break;

                case EApontamentos.E:
                    Posicao.OlhandoPara = EApontamentos.N;
                    break;
            }
        }

        private void GirarDireita()
        {
            switch (Posicao.OlhandoPara)
            {
                case EApontamentos.N:
                    Posicao.OlhandoPara = EApontamentos.E;
                    break;

                case EApontamentos.E:
                    Posicao.OlhandoPara = EApontamentos.S;
                    break;

                case EApontamentos.S:
                    Posicao.OlhandoPara = EApontamentos.W;
                    break;

                case EApontamentos.W:
                    Posicao.OlhandoPara = EApontamentos.N;
                    break;
            }
        }
    }
}