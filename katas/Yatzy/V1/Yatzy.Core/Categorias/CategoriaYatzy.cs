namespace Yatzy.Core.Categorias
{
    public class CategoriaYatzy : IEstrategia
    {
        public int Puntuar(int[] valoresDados)
        {
            if (valoresDados.All(x => x == valoresDados.First()))
                return 50;
            return 0;
        }
    }
}