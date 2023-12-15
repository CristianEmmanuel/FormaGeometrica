using DevelopmentChallenge.Data.Model;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;

namespace DevelopmentChallenge.Data.Translate
{
    public static class Traductor
    {
        const string APIKEY = "trnsl.1.1.20190304T020345Z.b99ec5be58d48529.286d0502c26fb04e1b3d3963e225cfb5e74fdf48";

        public static string Traducir(string texto, string idioma)
        {
            try
            {
                string uri = ObtenerUri(APIKEY, idioma, texto);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    var datos = reader.ReadToEnd();
                    IdiomaModel model = JsonConvert.DeserializeObject<IdiomaModel>(datos);
                    return model.text[0];
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private static string ObtenerUri(string key, string idioma, string texto)
        {
            return @"https://translate.yandex.net/api/v1.5/tr.json/translate?key=" + key + "&text=" + texto + "&lang=es-" + idioma + "&format=plain";
        }

    }
}