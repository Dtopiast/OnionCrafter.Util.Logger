using Microsoft.Extensions.Logging;

namespace OnionCrafter.Util.Logger
{
    /// <summary>
    /// Interface representing a log action.
    /// </summary>
    public interface ILogAction : IBaseLogAction
    {
        /// <summary>
        /// Gets or sets the success message for the log action.
        /// </summary>
        string? SuccessMessage { get; set; }

        /// <summary>
        /// Gets or sets the log level for the success message.
        /// </summary>
        LogLevel SuccessLogLevel { get; set; }

        /// <summary>
        /// Gets or sets the failure message for the log action.
        /// </summary>
        string? FailureMessage { get; set; }

        /// <summary>
        /// Gets or sets the log level for the failure message.
        /// </summary>
        LogLevel FailureLogLevel { get; set; }

        /// <summary>
        /// Gets or sets the informational message for the log action.
        /// </summary>
        string? InfoMessage { get; set; }

        /// <summary>
        /// Gets or sets the log level for the informational message.
        /// </summary>
        LogLevel InfoLogLevel { get; set; }

        /// <summary>
        /// Gets or sets the warning message for the log action.
        /// </summary>
        string? WarningMessage { get; set; }

        /// <summary>
        /// Gets or sets the log level for the warning message.
        /// </summary>
        LogLevel WarningLogLevel { get; set; }

        /// <summary>
        /// Gets or sets the error message for the log action.
        /// </summary>
        string? ErrorMessage { get; set; }

        /// <summary>
        /// Gets or sets the log level for the error message.
        /// </summary>
        LogLevel ErrorLogLevel { get; set; }
    }
}