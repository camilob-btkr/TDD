namespace Yatzy.Core.Categorias;

public class CategoriaOnes : IEstrategiaPuntuacion
{
    public int Puntuar(int[] valoresDados)
    {
        return valoresDados.Where(x => x == 1).Sum();
    }
}