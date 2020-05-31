﻿using System;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// Log the messages to the Console
    /// </summary>
    public class ConsoleLogger : ILogger
    {
        /// <summary>
        /// Logs the given message to the system Console
        /// </summary>
        /// <param name="message">The message to log</param>
        /// <param name="level">The level of the message</param>
        public void Log(string message, LogFactoryLevel level)
        {
            // Write message to Console
            Console.WriteLine($"[{level}]".PadRight(13, ' ') + message);
        }
    }
}
