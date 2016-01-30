using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    /// <summary>
    /// Esta clase almacena y puede brindar la información de la cuenta de sanborns necesaria para la subida
    /// de archivos XML
    /// </summary>
    public static class SanbornsProviderAccount
    {
        private const string providerNumber = "748716";
        private const string providerRfc = "MOMJ650217D2A";

        /// <summary>
        /// 
        /// </summary>
        /// <returns>El numero de proveedor de la cuenta Sanborns</returns>
        public static string GetProviderNumber()
        {
            return providerNumber;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>El rfc de la cuenta Sanborns</returns>
        public static string GetProviderRfc()
        {
            return providerRfc;
        }
    }
}
