using System.Security.Cryptography;

namespace Yatzy.Core.Tests
{
    public class YatzyGameCore
    {
        [Fact]
        public void Debe_Lanzar_ArgumentException_cuando_la_cantidad_de_valores_de_dados_sea_distinta_de_5()
        {
            //Arrange
            string categoria = String.Empty;
            IEnumerable<int> valoresDados = Array.Empty<int>();

            //Act
            Action accionPuntuar = () => YatzyGame.Puntuar(valoresDados, categoria);

            //Assert
            var excepion = Assert.Throws<ArgumentException>(accionPuntuar);
            Assert.Equal("Se esperaban 5 valores de dados", excepion.Message);
        }

        [Fact]
        public void Debe_Lanzar_ArgumentException_cuando_alguno_de_los_valores_de_dado_esté_fuera_del_rango_1_a_6()
        {
            //Arrange
            string categoria = String.Empty;
            IEnumerable<int> valoresDados = [1, 2, 3, 6, 7];


            //Act
            Action accionPuntuar = () => YatzyGame.Puntuar(valoresDados, categoria);

            //Assert
            var exception = Assert.Throws<ArgumentException>(accionPuntuar);
            Assert.Equal("Todos los valores de los dados deben estar entre 1 y 6 inclusive", exception.Message);
        }

        [Theory]
        [InlineData(new int[] { 1, 1, 3, 3, 6 } , 14)]
        [InlineData(new int[] { 4, 5, 5, 6, 1 }, 21)]
        public void Debe_Retornar_la_suma_de_todos_los_valores_cuando_la_categoria_es_Chance(
            IEnumerable<int> valoresDados , int puntuacionEsperada)
        {
            //Arrange
            string categoria = "Chance";

            //Act
            int puntuacion = YatzyGame.Puntuar(valoresDados, categoria);

            //Assert
            Assert.Equal(puntuacionEsperada, puntuacion);
        }

        [Fact]
        public void Debe_Retornar_50_cuando_la_categoria_es_Yatzy_y_todos_los_valores_son_iguales()
        {
            //Arrange
            IEnumerable<int> valoresDados = [1, 1, 1, 1, 1];
            string categoria = "Yatzy";

            //Act
            int puntuacion = YatzyGame.Puntuar(valoresDados, categoria);

            //Assert
            Assert.Equal(50,puntuacion);
        }

    }

    public class YatzyGame
    {
        public static int Puntuar(IEnumerable<int> valoresDados, string categoria)
        {
            if (valoresDados.Count() != 5)
                throw new ArgumentException("Se esperaban 5 valores de dados");

            if (valoresDados.Any(valor => valor is < 1 or > 6))
                throw new ArgumentException("Todos los valores de los dados deben estar entre 1 y 6 inclusive");

            if (categoria == "Chance")
                return valoresDados.Sum();

            if (categoria == "Yatzy")
                return 50;

            return 0;
        }
    }
}