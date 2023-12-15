using DevelopmentChallenge.Data.Interfaces;
using System;

namespace DevelopmentChallenge.Data.Classes.Frorma
{
    public class Triangulo : FormaGeometrica, IForma
    {
   
        public Triangulo(decimal lado)
        {
            this.lado = lado;
        }


        public decimal ObtenerArea
        {
            get
            {
                return CalcularArea();
            }
        }

        public decimal ObtenerPerimetro
        {
            get
            {
                return CalcularPerimetro();
            }
        }


        protected override decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * this.lado * this.lado;
        }

        protected override decimal CalcularPerimetro()
        {
            return this.lado * 3;
        }
    }
}
