using System;
using System.Text;

namespace Core.Methods
{
    public static class StringExtension
    {
        /// <summary>
        /// Ao enviar uma String o primeiro caractere de cada palavra se torna maiúscula.
        /// </summary>
        /// <param name="StringToWork">String a ser trabalhada</param>
        /// <returns></returns>
        public static string FistUppercaseAllWords(this string StringToWork)
        {
            string strResult = "";
            bool booPrimeira = true;
            if (StringToWork.Length > 0)
            {
                for (int intCont = 0; intCont <= StringToWork.Length - 1; intCont++)
                {
                    if ((booPrimeira) && (!StringToWork.Substring(intCont, 1).Equals(" ")))
                    {
                        strResult += StringToWork.Substring(intCont, 1).ToUpper();
                        booPrimeira = false;
                    }
                    else
                    {
                        strResult += StringToWork.Substring(intCont, 1).ToLower();
                        if (StringToWork.Substring(intCont, 1).Equals(" "))
                        {
                            booPrimeira = true;
                        }
                    }
                }
            }
            return strResult.Trim();
        }
        public static string Base64Encode(string StringToWork)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(StringToWork);
            return Convert.ToBase64String(plainTextBytes);
        }
        public static string GetBetween(string strSource, string strStart, string strEnd)
        {
            int Start, End;
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }
            else
            {
                return "";
            }
        }
        public static string ReplaceAt(this string str, int index, int length, string replace)
        {
            return str.Remove(index, Math.Min(length, str.Length - index))
                    .Insert(index, replace);
        }
    }
}
