namespace Yatzy.Core.Categorias;

public class CategoriaTwos : IEstrategiaPuntuacion
{
    public int Puntuar(int[] valoresDados)
    {
        return valoresDados.Where(x => x == 2).Sum();
    }
}