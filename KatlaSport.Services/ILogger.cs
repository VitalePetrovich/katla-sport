using System;

namespace KatlaSport.Services
{
    public interface ILogger
    {
        /// <summary>
        /// Info message.
        /// </summary>
        /// <param name="msg">Message.</param>
        void Info(string msg);

        /// <summary>
        /// Warning message. If exception occurs, but process is still running.
        /// </summary>
        /// <param name="ex">Exception.</param>
        /// <param name="msg">Message.</param>
        void Warning(Exception ex, string msg);

        /// <summary>
        /// Warning message. If exception occurs, but process is still running.
        /// </summary>
        /// <param name="ex">Exception.</param>
        void Warning(Exception ex);

        /// <summary>
        /// Fatal message. If critical exception occurs.
        /// </summary>
        /// <param name="ex">Exception.</param>
        void Fatal(Exception ex);
    }
}
