using DevelopmentChallenge.Data.Interfaces;

namespace DevelopmentChallenge.Data.Classes.Frorma
{
    public class Rectangulo : FormaGeometrica, IForma
    {
        private decimal ladoMayor;

    
        public Rectangulo(decimal lado, decimal ladoMayor)
        {
            this.lado = lado;
            this.ladoMayor = ladoMayor;
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
            return this.lado * this.ladoMayor;
        }

    
        protected override decimal CalcularPerimetro()
        {
            return 2 * (this.lado + this.ladoMayor);
        }
    }
}
