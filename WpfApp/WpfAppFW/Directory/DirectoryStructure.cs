using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppFW
{
    /// <summary>
    /// A helper class to query information about directories
    /// </summary>
    public static class DirectoryStructure
    {
        /// <summary>
        /// Get all logical drive on the computer
        /// </summary>
        /// <returns></returns>
        public static List<DirectoryItem> GetLogicalDrives()
        {
            // Get every logical drive of the machine
            return Directory.GetLogicalDrives().Select(drive => new DirectoryItem() { FullPath = drive, Type = DirectoryItemType.Drive }).ToList();
        }

        /// <summary>
        /// Gets the directories top-level content
        /// </summary>
        /// <param name="fullPath">The full path to the directory</param>
        /// <returns></returns>
        public static List<DirectoryItem> GetDirectoryContents(string fullPath)
        {
            var items = new List<DirectoryItem>();

            // Try and get directories from the folder
            // Ignoring any issues doing so
            try
            {
                var dirs = Directory.GetDirectories(fullPath);
                if (dirs.Length > 0)
                    items.AddRange(dirs.Select(dir => new DirectoryItem() { FullPath = dir, Type = DirectoryItemType.Folder }));
            }
            catch { }

            // Try and get files from the folder
            // Ignoring any issues doing so
            try
            {
                var fs = Directory.GetFiles(fullPath);
                if (fs.Length > 0)
                    items.AddRange(fs.Select(file => new DirectoryItem() { FullPath = file, Type = DirectoryItemType.File }));
            }
            catch { }

            return items;
        }

        /// <summary>
        /// Find the file or folder name from a full path
        /// </summary>
        /// <param name="path">The full path</param>
        /// <returns></returns>
        public static string GetFileFolderName(string path)
        {
            // C:\Something\folder
            // C:\Something\file.png

            // If there is no path,  return empty
            if (string.IsNullOrEmpty(path))
                return string.Empty;

            // Make all slashe backslashes
            var normalizedPath = path.Replace('/', '\\');

            // Find the last index backslash in the path
            var lastIndex = normalizedPath.LastIndexOf('\\');

            // If we don't find a backslash, return the path itself
            if (lastIndex <= 0)
                return path;

            // Return the name after the last backslash
            return normalizedPath.Substring(lastIndex + 1);
        }
    }
}
