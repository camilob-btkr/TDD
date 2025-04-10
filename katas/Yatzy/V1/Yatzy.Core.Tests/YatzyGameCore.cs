namespace Yatzy.Core.Tests
{
    public class YatzyGameCore
    {
        [Fact]
        public void Debe_Lanzar_ArgumentException_cuando_la_cantidad_de_valores_de_dados_sea_distinta_de_5()
        {
            //Arrange
            var categoria = Categoria.Chance;
            int[] valoresDados = [];

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
            var categoria = Categoria.Chance;
            int[] valoresDados = [1, 2, 3, 6, 7];


            //Act
            Action accionPuntuar = () => YatzyGame.Puntuar(valoresDados, categoria);

            //Assert
            var exception = Assert.Throws<ArgumentException>(accionPuntuar);
            Assert.Equal("Todos los valores de los dados deben estar entre 1 y 6 inclusive", exception.Message);
        }

        [Theory]
        [InlineData(new int[] { 1, 1, 3, 3, 6 }, 14)]
        [InlineData(new int[] { 4, 5, 5, 6, 1 }, 21)]
        public void Debe_Retornar_la_suma_de_todos_los_valores_cuando_la_categoria_es_Chance(
            int[] valoresDados, int puntuacionEsperada)
        {
            //Arrange
            var categoria = Categoria.Chance;

            //Act
            var puntuacion = YatzyGame.Puntuar(valoresDados, categoria);

            //Assert
            Assert.Equal(puntuacionEsperada, puntuacion);
        }

        [Fact]
        public void Debe_Retornar_50_cuando_la_categoria_es_Yatzy_y_todos_los_valores_son_iguales()
        {
            //Arrange
            int[] valoresDados = [1, 1, 1, 1, 1];
            var categoria = Categoria.Yatzy;

            //Act
            var puntuacion = YatzyGame.Puntuar(valoresDados, categoria);

            //Assert
            Assert.Equal(50, puntuacion);
        }

        [Fact]
        public void Debe_Retornar_0_cuando_la_categoria_es_Yatzy_y_al_menos_un_valor_es_diferente()
        {
            //Arrange
            int[] valoresDados = [1, 1, 2, 1, 1];
            var categoria = Categoria.Yatzy;

            //Act
            var puntuacion = YatzyGame.Puntuar(valoresDados, categoria);

            //Assert
            Assert.Equal(0, puntuacion);
        }

        [Fact]
        public void Debe_Retornar_la_suma_de_los_unos_cuando_la_categoria_es_Ones_y_hay_unos_en_los_valores()
        {
            //Arragange
            int[] valoresDados = [1, 2, 3, 4, 5];
            var categoria = Categoria.Ones;

            //Act
            var puntuacion = YatzyGame.Puntuar(valoresDados, categoria);

            //Assert
            Assert.Equal(1, puntuacion);
        }

        [Fact]
        public void Debe_Retornar_0_cuando_la_categoria_es_Ones_y_no_hay_unos_en_los_valores()
        {
            //Arragange
            int[] valoresDados = [2, 2, 3, 4, 5];
            var categoria = Categoria.Ones;

            //Act
            var puntuacion = YatzyGame.Puntuar(valoresDados, categoria);

            //Assert
            Assert.Equal(0, puntuacion);
        }

        [Fact]
        public void Debe_Retornar_0_cuando_la_categoria_es_Twos_y_no_hay_dos_en_los_valores()
        {
            //Arrange
            int[] valoresDados = [1, 3, 4, 5, 6];
            var categoria = Categoria.Twos;

            //Act
            var puntuacion = YatzyGame.Puntuar(valoresDados, categoria);

            //Assert
            Assert.Equal(0, puntuacion);
        }

        [Fact]
        public void Debe_Retornar_la_suma_de_los_dos_cuando_la_categoria_es_Twos_y_hay_dos_en_los_valores()
        {
            //Arrange
            int[] valoresDados = [2, 2, 4, 5, 2];
            var categoria = Categoria.Twos;

            //Act
            var puntuacion = YatzyGame.Puntuar(valoresDados, categoria);

            //Assert
            Assert.Equal(6, puntuacion);
        }

        [Fact]
        public void Debe_Retornar_0_cuando_la_categoria_es_Threes_y_no_hay_tres_en_los_valores()
        {
            //Arrange
            int[] valoresDados = [1, 2, 4, 5, 6];
            var categoria = Categoria.Threes;

            //Act
            var puntuacion = YatzyGame.Puntuar(valoresDados, categoria);

            //Assert
            Assert.Equal(0, puntuacion);
        }

        [Fact]
        public void Debe_Retornar_la_suma_de_los_tres_cuando_la_categoria_es_Threes_y_hay_tres_en_los_valores()
        {
            //Arrange
            int[] valoresDados = [3, 3, 2, 3, 5];
            var categoria = Categoria.Threes;

            //Act
            var puntuacion = YatzyGame.Puntuar(valoresDados, categoria);

            //Assert
            Assert.Equal(9, puntuacion);
        }

        [Fact]
        public void Debe_Retornar_0_cuando_la_categoria_es_Fours_y_no_hay_cuatros_en_los_valores()
        {
            //Arrange
            int[] valoresDados = [6, 5, 2, 3, 5];
            var categoria = Categoria.Fours;

            //Act
            var puntuacion = YatzyGame.Puntuar(valoresDados, categoria);

            //Assert
            Assert.Equal(0, puntuacion);
        }

        [Fact]
        public void Debe_Retornar_la_suma_de_los_cuatros_cuando_la_categoria_es_Fours_y_hay_cuatros_en_los_valores()
        {
            //Arrange
            int[] valoresDados = [4, 5, 2, 3, 5];
            var categoria = Categoria.Fours;

            //Act
            var puntuacion = YatzyGame.Puntuar(valoresDados, categoria);

            //Assert
            Assert.Equal(4, puntuacion);
        }

        [Fact]
        public void Debe_Retornar_0_cuando_la_categoria_es_Fives_y_no_hay_cincos_en_los_valores()
        {
            //Arrange
            int[] valoresDados = [6, 1, 2, 3, 4];
            var categoria = Categoria.Fives;

            //Act
            var puntuacion = YatzyGame.Puntuar(valoresDados, categoria);

            //Assert
            Assert.Equal(0, puntuacion);
        }


    }
}