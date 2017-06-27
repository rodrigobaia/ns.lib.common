using System;

namespace NS.Lib.Common
{
    /// <summary>
	/// TODO: Update summary.
	/// </summary>
	public static class DateTimeExtender
    {
        /// <summary>
        /// Retorna a hora no formato HH:MM:SS
        /// </summary>
        /// <param name="hora"></param>
        /// <returns></returns>
        public static string ToStringTimer(this DateTime hora)
        {
            string results;
            results = string.Format("{0:T}", hora);
            //results += ":" + string.Format("{0:MM}", hora.Minute);
            //results += ":" + string.Format("{0:ss}", hora.Second);

            return results;
        }

        /// <summary>
        /// Retorna a data com o mês por extenso
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string ObterMesExtenso(this DateTime data)
        {
            string results = DateTime.Now.ToString("dd/MM/yyyy");
            results = string.Format("{0:D}", data);
            string[] ar = results.Split(',');

            return ar[1];
        }

        /// <summary>
        /// Obter Saudações
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string ObterSaudacao(this DateTime dt)
        {
            string results = string.Empty;

            if (dt.Hour >= 0 && (dt.Hour <= 12 && dt.Minute <= 59))
                results = "Bom dia";
            else if (dt.Hour >= 13 && (dt.Hour <= 17 && dt.Minute <= 59))
                results = "Boa Tarde";
            else
                results = "Boa Noite";

            return results;
        }

        /// <summary>
        /// Inverte data
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static int InverteData(this DateTime dt)
        {
            int results = 0;
            string[] data = new string[3];
            data[0] = dt.Year.ToString();
            data[1] = ("00" + dt.Month).Right(2);
            data[2] = ("00" + dt.Day).Right(2);
            results = Convert.ToInt32(data[0] + data[1] + data[2]);

            return results;
        }
    }
}
