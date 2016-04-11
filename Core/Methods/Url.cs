using System;

namespace Core.Methods
{
    public class Url
    {/// <summary>
     /// Método para retornar ums string sem caracteres especiais, sem espaços.
     /// </summary>
     /// <param name="url">Strign para qual será a base da URL</param>
     /// <returns>Retorna a URL</returns>
        public static String UrlGenerator(String url)
        {
            //Verificar se já não possui um igual;
            return URLFistStap(url);
        }
        /// <summary>
        /// Método para retornar uma string sem caracteres especiais, sem espaços.
        /// </summary>
        /// <param name="url">Strign para qual será a base da URL</param>
        /// <param name="randomNumber">True para ter número aleatório no final</param>
        /// <returns></returns>
        public static string UrlGenerator(string url, bool randomNumber)
        {
            if (randomNumber)
            {
                Random numeroAleatorio = new Random();
                String urlFinal = URLFistStap(url) + "-" + numeroAleatorio.Next(10000, 99999);
                return urlFinal;
            }
            else
            {
                return URLFistStap(url);
            }
            //Verificar se já não possui um igual;
        }
        /// <summary>
        /// Método para retornar uma string sem caracteres especiais, sem espaços e definindo um número aleatório ao final da url
        /// </summary>
        /// <param name="url">String para qual será a base da URL</param>
        /// <param name="minNumber">Menor número do jogo aleatório (recomendo algum com 3 a 5 digitos)</param>
        /// <param name="maxNumber">Maior número do jogo aleatório (recomendo um número com um digito a mais que o minNumber - 1). </param>
        /// <returns></returns>
        public static String UrlGenerator(String url, bool randomNumber, int minNumber, int maxNumber)
        {
            Random numeroAleatorio = new Random();
            String urlFinal = URLFistStap(url) + "-" + numeroAleatorio.Next(minNumber, maxNumber);
            return urlFinal;
        }
        private static String URLFistStap(String url)
        {
            string[] acentos = new string[] { "ç", "Ç", "á", "é", "í", "ó", "ú", "ý", "Á", "É", "Í", "Ó", "Ú", "Ý", "à", "è", "ì", "ò", "ù", "À", "È", "Ì", "Ò", "Ù", "ã", "õ", "ñ", "ä", "ë", "ï", "ö", "ü", "ÿ", "Ä", "Ë", "Ï", "Ö", "Ü", "Ã", "Õ", "Ñ", "â", "ê", "î", "ô", "û", "Â", "Ê", "Î", "Ô", "Û" };
            string[] semAcento = new string[] { "c", "C", "a", "e", "i", "o", "u", "y", "A", "E", "I", "O", "U", "Y", "a", "e", "i", "o", "u", "A", "E", "I", "O", "U", "a", "o", "n", "a", "e", "i", "o", "u", "y", "A", "E", "I", "O", "U", "A", "O", "N", "a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };
            for (int i = 0; i < acentos.Length; i++)
            {
                url = url.Replace(acentos[i], semAcento[i]);
            }

            //ok 12323
                string[] caracteresEspeciais = { "\\.", ",", ":", "\\(", "\\)", "ª", "\\|", "\\\\", "°" };
            for (int i = 0; i < caracteresEspeciais.Length; i++)
            {
                url = url.Replace(caracteresEspeciais[i], "");
            }
            url = url.Replace(" ", "-");
            url = url.Replace("^\\s+", "-");
            url = url.Replace("\\s+$", "-");
            url = url.Replace("\\s+", "-");
            return url.ToLower();
        }
    }
}
