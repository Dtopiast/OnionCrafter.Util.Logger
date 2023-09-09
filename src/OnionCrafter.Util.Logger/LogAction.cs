using Microsoft.Extensions.Logging;

namespace OnionCrafter.Util.Logger
{
    /// <summary>
    /// Represents a log action.
    /// </summary>
    public class LogAction : ILogAction
    {
        /// <inheritdoc/>
        public string? SuccessMessage { get; set; }

        /// <inheritdoc/>
        public LogLevel SuccessLogLevel { get; set; }

        /// <inheritdoc/>
        public string? FailureMessage { get; set; }

        /// <inheritdoc/>
        public LogLevel FailureLogLevel { get; set; }

        /// <inheritdoc/>
        public string? InfoMessage { get; set; }

        /// <inheritdoc/>
        public LogLevel InfoLogLevel { get; set; }

        /// <inheritdoc/>
        public string? WarningMessage { get; set; }

        /// <inheritdoc/>
        public LogLevel WarningLogLevel { get; set; }

        /// <inheritdoc/>
        public string? ErrorMessage { get; set; }

        /// <inheritdoc/>
        public LogLevel ErrorLogLevel { get; set; }
    }
}