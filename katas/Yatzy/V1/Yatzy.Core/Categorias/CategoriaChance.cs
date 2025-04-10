namespace Yatzy.Core.Categorias
{
    public class CategoriaChance : IEstrategiaPuntuacion
    {
        public int Puntuar(int[] valoresDados)
        {
            return valoresDados.Sum();
        }
    }
}