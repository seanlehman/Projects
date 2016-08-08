using ElevenNote.Web.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElevenNote.Web.Fakes
{
    /// <summary>
    /// Fake of an ILogger so we can get on with our work while implementation complete.
    /// </summary>
    public class FakeLogger : ILogger
    {
        public void LogDebugEvent(string message, string functionName = "n/a")
        {
            //simply returns
        }

        public void LogDebugEvent(Exception ex, string functionName = "n/a")
        {
            //simply returns
        }

        public void LogErrorEvent(string message, string functionName = "n/a")
        {
            //simply returns
        }

        public void LogErrorEvent(Exception ex, string functionName = "n/a")
        {
            //simply returns
        }

        public void LogInfoEvent(string message, string functionName = "n/a")
        {
            //simply returns
        }

        public void LogInfoEvent(Exception ex, string functionName = "n/a")
        {
            //simply returns
        }
    }
}