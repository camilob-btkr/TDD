namespace Yatzy.Core;

public class YatzyGame
{
    public static int Puntuar(int[] valoresDados, Categoria categoria)
    {
        ValidarValoresDados(valoresDados);

        if (categoria == Categoria.Chance)
            return valoresDados.Sum();

        if (categoria == Categoria.Yatzy)
        {
            if (valoresDados.All(x => x == valoresDados.First()))
                return 50;
            return 0;
        }

        if (categoria == Categoria.Ones)
            return valoresDados.Where(x => x==1).Sum();

        if (categoria == Categoria.Twos)
            return 0;

        return -1;
    }

    private static void ValidarValoresDados(int[] valoresDados)
    {
        ValidarCantidadDeValores(valoresDados);

        ValidarValoresPermitidos(valoresDados);
    }

    private static void ValidarValoresPermitidos(IEnumerable<int> valoresDados)
    {
        if (valoresDados.Any(valor => valor is < 1 or > 6))
            throw new ArgumentException("Todos los valores de los dados deben estar entre 1 y 6 inclusive");
    }

    private static void ValidarCantidadDeValores(IEnumerable<int> valoresDados)
    {
        if (valoresDados.Count() != 5)
            throw new ArgumentException("Se esperaban 5 valores de dados");
    }
}