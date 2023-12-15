using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Cuadrado : FormaGeometrica, IForma
    {
      
        public Cuadrado(decimal lado)
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
            return this.lado * this.lado;
        }

        protected override decimal CalcularPerimetro()
        {
            return this.lado * 4;
        }
    }
}
