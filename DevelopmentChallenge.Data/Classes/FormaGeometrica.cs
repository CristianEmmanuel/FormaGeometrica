using DevelopmentChallenge.Data.Interfaces;
using DevelopmentChallenge.Data.Model;
using DevelopmentChallenge.Data.Translate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
{
    public abstract class FormaGeometrica
    {
        #region Atributos
        protected decimal lado;
        #endregion

        #region Metodos

        protected abstract decimal CalcularArea();

    
        protected abstract decimal CalcularPerimetro();

      
        public static string Imprimir(List<FormaGeometrica> formas, Idioma idioma)
        {
            StringBuilder sb = new StringBuilder();
            string codigoIdioma = ObtenerCodigoIdioma(idioma);

            List<FormaModel> datosDeFormasEnLista = new List<FormaModel>();
            Dictionary<string, int> cantidadDeFormas = new Dictionary<string, int>();

            try
            {
                if (!formas.Any())
                {
                    return string.Format("<h1>{0}</h1>", Traductor.Traducir("Lista vacía de formas!", codigoIdioma));
                }

                sb.Append(string.Format("<h1>{0}</h1>", Traductor.Traducir("Reporte de Formas", codigoIdioma)));

                foreach (IForma forma in formas)
                {
                    FormaModel unaForma = new FormaModel();
                    unaForma.TipoForma = forma.GetType().Name; 
                    unaForma.Perimetro = forma.ObtenerPerimetro; 
                    unaForma.Area = forma.ObtenerArea; 

                    int index = datosDeFormasEnLista.FindIndex(a => a.TipoForma == unaForma.TipoForma);

                    if (index > -1)
                    {
                        datosDeFormasEnLista[index].Perimetro += unaForma.Perimetro;
                        datosDeFormasEnLista[index].Area += unaForma.Area;
                    }
                    else
                    {
                        datosDeFormasEnLista.Add(unaForma);
                    }
                    if (!cantidadDeFormas.ContainsKey(unaForma.TipoForma))
                    {
                        cantidadDeFormas.Add(unaForma.TipoForma, 1);
                    }
                    else
                    {
                        cantidadDeFormas[unaForma.TipoForma] += 1;
                    }

                }

                foreach (FormaModel forma in datosDeFormasEnLista)
                {
                    sb.Append(
                        string.Format("{0} {1} | {2}: {3} | {4}: {5} |<br/>",
                                     cantidadDeFormas[forma.TipoForma],
                                     cantidadDeFormas[forma.TipoForma] > 1 ? Traductor.Traducir(forma.TipoForma + "s", codigoIdioma) : Traductor.Traducir(forma.TipoForma, codigoIdioma),
                                     Traductor.Traducir("Perímetro", codigoIdioma),
                                     forma.Perimetro.ToString("#.##"),
                                     Traductor.Traducir("Área", codigoIdioma),
                                     forma.Area.ToString("#.##")
                        )
                    );
                }


                // FOOTER
                sb.Append(string.Format("{0} :<br/>", Traductor.Traducir("total", codigoIdioma).ToUpper()));
                sb.Append(
                    string.Format("{0} {1}",
                                 cantidadDeFormas.Sum(x => x.Value),
                                 cantidadDeFormas.Sum(x => x.Value) > 1 ? Traductor.Traducir("Formas", codigoIdioma) : Traductor.Traducir("Forma", codigoIdioma)
                                 )
                );
                sb.Append(Traductor.Traducir(" Perímetro", codigoIdioma) + ": " + formas.Where(x => x is IForma).Sum(x => ((IForma)x).ObtenerPerimetro).ToString("#.##"));
                sb.Append(Traductor.Traducir(" Área", codigoIdioma) + ": " + formas.Where(x => x is IForma).Sum(x => ((IForma)x).ObtenerArea).ToString("#.##"));

                return sb.ToString();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static string ObtenerCodigoIdioma(Idioma idioma)
        {
            string codigo = string.Empty;

            switch (idioma)
            {
                case Idioma.Ingles:
                    codigo = "en";
                    break;
                case Idioma.Italiano:
                    codigo = "it";
                    break;
                case Idioma.Castellano:
                    codigo = "es";
                    break;
            }

            return codigo;
        }

        #endregion

    }
}
