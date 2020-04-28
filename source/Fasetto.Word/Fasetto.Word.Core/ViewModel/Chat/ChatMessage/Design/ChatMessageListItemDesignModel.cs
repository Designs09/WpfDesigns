using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// The design time data for a <see cref="ChatMessageListItemDesignModel"/>
    /// </summary>
    public class ChatMessageListItemDesignModel : ChatMessageListItemViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static ChatMessageListItemDesignModel Instance => new ChatMessageListItemDesignModel(); 

        #endregion

        #region Constructor

        public ChatMessageListItemDesignModel()
        {
            Initials = "LM";
            SenderName = "Luke";
            Message = "This chat app is awesome! I bet it will be fast too.";
            ProfilePictureRGB = "3099c5";
            SendByMe = true;
            MessageSentTime = DateTimeOffset.UtcNow;
        }

        #endregion
    }
}
