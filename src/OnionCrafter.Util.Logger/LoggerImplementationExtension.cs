using Microsoft.Extensions.Logging;
using OnionCrafter.Util.Logger.Exception;
using OnionCrafter.Utils.Exception;

namespace OnionCrafter.Util.Logger
{  /// <summary>
   /// Utility class for checking logger implementation.
   /// </summary>
    public static class LoggerImplementationExtension
    {
        /// <summary>
        /// Checks if the logger is implemented when it is expected to be enabled.
        /// </summary>
        /// <param name="logger">The logger instance.</param>
        /// <param name="isEnabled">Flag indicating if the logger is enabled.</param>
        /// <exception cref="NotImplementedLoggerException">Thrown when the logger is not implemented but it is expected to be enabled.</exception>
        public static TLogger? CheckLoggerImplementation<TLogger>(this TLogger? logger, bool isEnabled)
            where TLogger : ILogger
        {
            logger?.ThrowIf<TLogger, NotImplementedLoggerException>(logger == null, isEnabled);

            return logger;
        }
    }
}