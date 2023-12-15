using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.Frorma
{
    public class Circulo : FormaGeometrica, IForma
    {
     
        public Circulo(decimal radio)
        {
            this.lado = radio;
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
            return (decimal)Math.PI * (decimal)Math.Pow((double)this.lado, 2);
        }

      
        protected override decimal CalcularPerimetro()
        {
            return 2 * (decimal)Math.PI * this.lado;
        }
    }
}
