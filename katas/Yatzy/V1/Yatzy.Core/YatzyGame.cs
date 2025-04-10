using Yatzy.Core.Categorias;


namespace Yatzy.Core;

public class YatzyGame
{
    public static int Puntuar(int[] valoresDados, Categoria categoria)
    {
        ValidarValoresDados(valoresDados);

        return PuntuarConEstrategia(valoresDados, categoria);
    }

    private static int PuntuarConEstrategia(int[] valoresDados, Categoria categoria)
    {
        if (categoria == Categoria.Chance)
            return new CategoriaChance().Puntuar(valoresDados);

        if (categoria == Categoria.Yatzy)
            return new CategoriaYatzy().Puntuar(valoresDados);

        if (categoria == Categoria.Ones)
            return new CategoriaOnes().Puntuar(valoresDados);

        if (categoria == Categoria.Twos)
            return new CategoriaTwos().Puntuar(valoresDados);

        if (categoria == Categoria.Threes)
            return new CategoriaThress().Puntuar(valoresDados);

        if (categoria == Categoria.Fours)
            return new CategoriaFours().Puntuar(valoresDados);

        if (categoria == Categoria.Fives)
            return new CategoriaFives().Puntuar(valoresDados);

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