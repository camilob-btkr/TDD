namespace Yatzy.Core.Categorias;

public class CategoriaTwos : IEstrategia
{
    public int Puntuar(int[] valoresDados)
    {
        return valoresDados.Where(x => x == 2).Sum();
    }
}