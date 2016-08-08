using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Web.Contracts
{
    public interface ILogger
    {
        /// <summary>
        /// Logs an info level event.
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="functionName"></param>
        void LogInfoEvent(Exception ex, string functionName = "n/a");

        /// <summary>
        /// Logs an info-level event that may not have an exception associated with it
        /// </summary>
        /// <param name="message"></param>
        /// <param name="functionName"></param>
        void LogInfoEvent(string message, string functionName = "n/a");

        /// <summary>
        /// logs a debug-level event
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="functionName"></param>
        void LogDebugEvent(Exception ex, string functionName = "n/a");

        /// <summary>
        /// Logs an debug-level event that may not have an exception associated with it
        /// </summary>
        /// <param name="message"></param>
        /// <param name="functionName"></param>
        void LogDebugEvent(string message, string functionName = "n/a");

        /// <summary>
        /// logs a error-level event
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="functionName"></param>
        void LogErrorEvent(Exception ex, string functionName = "n/a");

        /// <summary>
        /// Logs an error-level event that may not have an exception associated with it
        /// </summary>
        /// <param name="message"></param>
        /// <param name="functionName"></param>
        void LogErrorEvent(string message, string functionName = "n/a");








    }
}
