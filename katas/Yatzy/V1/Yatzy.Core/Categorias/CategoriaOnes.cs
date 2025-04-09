namespace Yatzy.Core.Categorias;

public class CategoriaOnes : IEstrategia
{
    public int Puntuar(int[] valoresDados)
    {
        return valoresDados.Where(x => x == 1).Sum();
    }
}