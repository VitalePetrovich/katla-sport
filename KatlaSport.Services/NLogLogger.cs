using System;

namespace KatlaSport.Services
{
    /// <summary>
    /// NLog class logger.
    /// </summary>
    public class NLogLogger : ILogger
    {
        private readonly NLog.Logger _logger = NLog.LogManager.GetCurrentClassLogger();

        /// <inheritdoc/>
        public void Info(string msg)
            => _logger.Info(msg);

        /// <inheritdoc/>
        public void Warning(Exception ex, string msg)
            => _logger.Warn(ex, msg);

        /// <inheritdoc/>
        public void Warning(Exception ex)
            => _logger.Warn(ex);

        /// <inheritdoc/>
        public void Fatal(Exception ex)
            => _logger.Fatal(ex);
    }
}
