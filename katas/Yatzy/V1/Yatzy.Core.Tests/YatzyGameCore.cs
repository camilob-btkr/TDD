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
    }

    public class YatzyGame
    {
        public static void Puntuar(IEnumerable<int> valoresDados, string categoria)
        {
            throw new NotImplementedException();
        }
    }
}
