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
            var accionPuntuar = () => YatzyGame.Puntuar(valoresDados, categoria);

            //Assert
            var excepion = Assert.Throws<ArgumentException>(accionPuntuar);
            Assert.Equal("Se esperaban 5 valores de dados",excepion.Message);
        }

        [Fact]
        public void Debe_Lanzar_ArgumentException_cuando_alguno_de_los_valores_de_dado_esté_fuera_del_rango_1_a_6()
        {
            //Arrange
            string categoria = String.Empty;
            IEnumerable<int> valoresDados = [1, 2, 3];


            //Act
            var accionPuntuar = () => YatzyGame.Puntuar(valoresDados, categoria);

            //Assert
            var exception = Assert.Throws<ArgumentException>(accionPuntuar);
            Assert.Equal("Todos los valores de los dados deben estar entre 1 y 6 inclusive", exception.Message);

        }
    }

    public class YatzyGame
    {
        public static void Puntuar(IEnumerable<int> valoresDados, string categoria)
        {
            throw new ArgumentException("Se esperaban 5 valores de dados");
        }
    }
}
