
namespace Fasetto.Word.Core
{
    /// <summary>
    /// A design-time data for a <see cref="ChatAttachmentPopupMenuViewModel"/>
    /// </summary>
    public class ChatAttachmentPopupMenuDesignModel : ChatAttachmentPopupMenuViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static ChatAttachmentPopupMenuDesignModel Instance => new ChatAttachmentPopupMenuDesignModel();

        #endregion


        #region Constructor

        public ChatAttachmentPopupMenuDesignModel()
        {
        }

        #endregion
    }
}
