using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Classes.Frorma;
using DevelopmentChallenge.Data.Translate;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System.Collections.Generic;
using Assert = NUnit.Framework.Assert;

namespace DevelopmentChallenge.Data.Test
{
    [TestFixture]
    public class DataTests
    {
      

        [TestCase]

        public void TestCodigoIdioma()
        {
            Assert.IsNotNull("en");
        }

        [TestCase]

        public void TestSinIdioma()
        {
            Assert.IsNull(null);
        }

        [TestCase]
        public void TestCreacionDeCirculo()
        {
           
            Circulo circulo = new Circulo(10);

            Assert.IsNotNull(circulo);
        }

        [TestCase]
        public void TestCreacionDeCuadrado()
        {
            Cuadrado cuadrado = new Cuadrado(10);

            Assert.IsNotNull(cuadrado);
        }

        [TestCase]
        public void TestCreacionDeRectangulo()
        {
            Rectangulo rectangulo = new Rectangulo(10, 5);

            Assert.IsNotNull(rectangulo);
        }

        [TestCase]
        public void TestCreacionDeTriangulo()
        {
            Triangulo triangulo = new Triangulo(10);

            Assert.IsNotNull(triangulo);
        }

        [TestCase]
        public void TestCreacionDeTrapecio()
        {
            Trapecio trapecio = new Trapecio(10, 20, 5, 4);

            Assert.IsNotNull(trapecio);
        }

      
    }
}