using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common
{
    /// <summary>
    /// Provides loggin
    /// </summary>
    public static class LoggingService
    {
        /// <summary>
        /// Log Action
        /// </summary>
        /// <param name="action"></param>
        /// <returns>a log text</returns>
        public static string LogAction(string action)
        {
            var logText = "Action: " + action;

            return logText;
        }
    }
}
