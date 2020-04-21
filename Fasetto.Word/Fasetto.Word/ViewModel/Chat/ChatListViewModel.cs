using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasetto.Word
{
    /// <summary>
    /// A view model for the overview chat list
    /// </summary>
    public class ChatListViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The chat list items for the list
        /// </summary>
        public List<ChatListItemViewModel> Items { get; set; }

        #endregion
    }
}
