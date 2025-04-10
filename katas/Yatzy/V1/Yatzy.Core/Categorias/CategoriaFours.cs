namespace Yatzy.Core.Categorias
{
    public class CategoriaFours : IEstrategiaPuntuacion
    {
        public int Puntuar(int[] valoresDados)
        {
            return valoresDados.Where(x => x == 4).Sum();
        }
    }
}