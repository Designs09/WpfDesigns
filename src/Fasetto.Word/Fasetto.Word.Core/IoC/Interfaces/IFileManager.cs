﻿using System;
using System.Threading.Tasks;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// Handles reading/writing and querying the file system
    /// </summary>
    public interface IFileManager
    {
        /// <summary>
        /// Writes the text to the specified file
        /// </summary>
        /// <param name="text">The text to write</param>
        /// <param name="path">The path of the file to write to</param>
        /// <param name="append">If true, write the text to the end of the file, otherwise overrides any existing file</param>
        /// <returns></returns>
        Task WriteAllTextToFileAsync(string text, string path, bool append = false);
    }
}
