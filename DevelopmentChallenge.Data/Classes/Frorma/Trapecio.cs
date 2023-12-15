using DevelopmentChallenge.Data.Interfaces;
using System;

namespace DevelopmentChallenge.Data.Classes.Frorma
{
    public class Trapecio : FormaGeometrica, IForma
    {
        private decimal baseMayor;
        private decimal baseMenor;
        private decimal altura;


        public Trapecio(decimal baseMenor, decimal baseMayor, decimal altura, decimal lado)
        {

            this.lado = lado;
            this.baseMayor = baseMayor;
            this.baseMenor = baseMenor;
            this.altura = altura;

            if (this.baseMenor > this.baseMayor)
                throw new ArgumentException("La base mayor debe ser superior a la base menor");

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
            return (this.baseMayor * this.baseMenor) / 2 * altura;
        }

        protected override decimal CalcularPerimetro()
        {
            return (this.baseMenor + this.baseMayor + (2 * this.lado));
        }
    }
}
