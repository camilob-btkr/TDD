namespace Yatzy.Core.Categorias;

public class CategoriaThress : IEstrategiaPuntuacion
{
    public int Puntuar(int[] valoresDados)
    {
        return valoresDados.Where(x => x == 3).Sum();
    }
}