namespace Fasetto.Word.Core
{
    /// <summary>
    /// The serverity of the log message
    /// </summary>
    public enum LogFactoryLevel
    {
        /// <summary>
        /// Logs everything
        /// </summary>
        Debug = 1,

        /// <summary>
        /// Lot all information except debug information
        /// </summary>
        Verbose = 2,

        /// <summary>
        /// Logs all informative message, ignoring any debug and verbose messages
        /// </summary>
        Information = 3,

        /// <summary>
        /// Logs only warnings, errors and standard messages
        /// </summary>
        Normal = 4,

        /// <summary>
        /// Log only critical erroes and warnings, no general information
        /// </summary>
        Critical = 5,

        /// <summary>
        /// The logger will never output anything
        /// </summary>
        Nothing = 6,
    }
}
