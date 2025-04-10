namespace Yatzy.Core.Categorias;

public class CategoriaFives : IEstrategiaPuntuacion
{
    public int Puntuar(int[] valoresDados)
    {
        return valoresDados.Where(x => x == 5).Sum();
    }
}