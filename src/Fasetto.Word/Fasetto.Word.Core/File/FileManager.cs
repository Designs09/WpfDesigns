using System.IO;
using System.Threading.Tasks;

namespace Fasetto.Word.Core
{
    public class FileManager : IFileManager
    {
        /// <summary>
        /// Writes the text to the specified file
        /// </summary>
        /// <param name="text">The text to write</param>
        /// <param name="path">The path of the file to write to</param>
        /// <param name="append">If true, write the text to the end of the file, otherwise overrides any existing file</param>
        /// <returns></returns>
        public async Task WriteAllTextToFileAsync(string text, string path, bool append = false)
        {
            // TODO: Add exception catching

            // C:\text/some file.txt
            // C:\text\some file.txt
            // TODO: Normalize and resolve path
            // For Windows, replace forward slash with backslash. For Mac, replace backslash with forward slash.
            //path = Path.GetFullPath(path.Replace('/', '\\').Trim());

            // Lock the task 
            await AsyncAwaiter.AwaitAsync(nameof(FileManager) + path, async () =>
            {
                // TODO: Add IoC.Task.Run that logs to logger on failure
                // Run the synchronous file access as a new task
                await Task.Run(() =>
                {
                    // Write the log message to file
                    using (var fileStream = (TextWriter)new StreamWriter(File.Open(path, append ? FileMode.Append : FileMode.Create, FileAccess.Write)))
                        fileStream.Write(text);
                });
            });
        }
    }
}
