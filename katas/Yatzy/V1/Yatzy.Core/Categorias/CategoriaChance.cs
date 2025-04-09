namespace Yatzy.Core.Categorias
{
    public class CategoriaChance : IEstrategia
    {
        public int Puntuar(int[] valoresDados)
        {
            return valoresDados.Sum();
        }
    }
}