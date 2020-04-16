using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppFW
{
    /// <summary>
    /// The type of a directory item
    /// </summary>
    public enum DirectoryItemType
    {
        /// <summary>
        ///  The logical item
        /// </summary>
        Drive,
        /// <summary>
        /// The physical file
        /// </summary>
        File,
        /// <summary>
        /// The folder
        /// </summary>
        Folder
    }
}
