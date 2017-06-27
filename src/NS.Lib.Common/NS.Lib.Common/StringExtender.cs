using System;

namespace NS.Lib.Common
{
    /// <summary>
    /// Extender String
    /// </summary>
    public static class StringExtender
    {
        /// <summary>
        /// Pega parte de uma string contido a esquerda
        /// </summary>
        /// <param name="param">string completa</param>
        /// <param name="length">Quantidade de caracteres que deseja pegar</param>
        /// <returns>Parte da string</returns>
        public static string Left(this string param, int length)
        {
            string result = param.Substring(0, length);
            return result;
        }

        /// <summary>
        /// Pega parte de uma string contido a direita
        /// </summary>
        /// <param name="param">string completa</param>
        /// <param name="length">Quantidade de caracteres que deseja pegar</param>
        /// <returns>Parte da string</returns>
        public static string Right(this string param, int length)
        {
            string result = param.Substring(param.Length - length, length);
            return result;
        }

        /// <summary>
        /// Pega uma parte de uma string
        /// </summary>
        /// <param name="param">string completa</param>
        /// <param name="startIndex">valor de inicio</param>
        /// <returns>Parte da string desejada</returns>
        public static string Mid(this string param, int startIndex)
        {
            string result = param.Substring(startIndex);
            return result;
        }

        /// <summary>
        /// Pega uma parte de uma string
        /// </summary>
        /// <param name="param">string completa</param>
        /// <param name="startIndex">valor de inicio</param>
        /// <param name="length">Quantidade de caracteres a ser capturado</param>
        /// <returns>Parte da string desejada</returns>
        public static string Mid(this string param, int startIndex, int length)
        {
            string result = param.Substring(startIndex, length);
            return result;
        }

        /// <summary>
        /// Tira a ultima string de uma sentença
        /// String padrão virgula (,)
        /// </summary>
        /// <param name="strDados">Sentença a ser retirada</param>
        /// <returns>String</returns>
        public static string TiraUltimaString(this string strDados)
        {
            return TiraUltimaString(strDados, ",");
        }

        /// <summary>
        /// Tira a ultima string de um contexto
        /// </summary>
        /// <param name="strDados">Contexto a ser analisado</param>
        /// <param name="strFind">valor a ser retirado</param>
        /// <returns>Retorno tratado</returns>
        public static string TiraUltimaString(this string strDados, string strFind)
        {
            string results = string.Empty;

            int i;

            i = strDados.LastIndexOf(strFind);

            if (i <= 0) throw new Exception(string.Format("Não foi encontrador a string [{0}];", strFind));

            results = strDados.Substring(0, i);

            return results;
        }

        /// <summary>
        /// Pega primeira string separado por virgula
        /// </summary>
        /// <param name="strDados">Contexto a ser pesquisado</param>
        /// <returns>retorno da sentença</returns>
        public static string PegaPrimeiraSentenca(this string strDados)
        {
            return PegaPrimeiraSentenca(strDados, ",");
        }

        /// <summary>
        /// Pega primeira string
        /// </summary>
        /// <param name="strDados">Contexto</param>
        /// <param name="strFind">valor a pesquisar</param>
        /// <returns>retorno da sentença</returns>
        public static string PegaPrimeiraSentenca(this string strDados, string strFind)
        {
            string results = string.Empty;

            int i;

            i = strDados.IndexOf(strFind);
            if (i == 0) throw new Exception(string.Format("Não foi encontrador a string [{0}];", strFind));
            results = strDados.Substring(0, i - 1);

            return results;
        }

        /// <summary>
        /// Pega a ultima parte de uma string
        /// </summary>
        /// <param name="strDados"></param>
        /// <param name="strFind"></param>
        /// <returns></returns>
        public static string PegaUltimaString(this string strDados, string strFind)
        {
            string results = string.Empty;

            int i;

            i = strDados.LastIndexOf(strFind);

            if (i <= 0) throw new Exception(string.Format("Não foi encontrador a string [{0}];", strFind));

            results = strDados.Substring(i + 1);

            return results;
        }

        /// <summary>
        /// Completa uma string com caractes
        /// </summary>
        /// <param name="caracter"></param>
        /// <param name="length"></param>
        /// <param name="with"></param>
        /// <returns></returns>
        public static string CompletaCaracter(this string caracter, int length, string with)
        {
            string resutls = string.Empty;
            int count = length - caracter.Length;
            string aux = string.Empty;

            for (int i = 0; i < count; i++)
            {
                aux += with;
            }
            resutls = caracter + aux;
            return resutls;
        }

    }
}
