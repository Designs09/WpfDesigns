using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// The type of content in the side menu
    /// </summary>
    public enum SideMenuContent
    {
        /// <summary>
        /// A list of chat threads
        /// </summary>
        Chat = 1,

        /// <summary>
        /// A list of contact
        /// </summary>
        Contacts = 2,

        /// <summary>
        /// A list of media from all chat messages
        /// </summary>
        Media = 3,
    }
}
