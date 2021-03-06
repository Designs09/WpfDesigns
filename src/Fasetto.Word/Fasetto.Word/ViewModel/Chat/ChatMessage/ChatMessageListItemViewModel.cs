﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasetto.Word
{
    /// <summary>
    /// A view model for each chat message thread item in the chat thread
    /// </summary>
    public class ChatMessageListItemViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The display name of the sender of the message
        /// </summary>
        public string SenderName { get; set; }

        /// <summary>
        /// The latest message from this chat
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// The initials to show for the profile picture
        /// </summary>
        public string Initials { get; set; }

        /// <summary>
        /// The RGB values (in hex) for the background color of the profile picture
        /// For example FF00FF for Red and Blue mixed
        /// </summary>
        public string ProfilePictureRGB { get; set; }

        /// <summary>
        /// True if this item is selected
        /// </summary>
        public bool IsSelected { get; set; }

        /// <summary>
        /// True if this message war sent by signed in user
        /// </summary>
        public bool SendByMe { get; set; }

        /// <summary>
        /// The time the message was read, or <see cref="DateTimeOffset.MinValue"/> if not read
        /// </summary>
        public DateTimeOffset MessageReadTime { get; set; }

        /// <summary>
        /// True if this message has been read
        /// </summary>
        public bool MessageRead => MessageReadTime > DateTimeOffset.MinValue;

        /// <summary>
        /// The time the message was sent
        /// </summary>
        public DateTimeOffset MessageSentTime { get; set; }

        /// <summary>
        /// A flag indicating if this item was added since the first mail list of items was created
        /// Used as flag for animating in
        /// </summary>
        public bool NewItem { get; set; }

        /// <summary>
        /// The attachment to the message, if it is of an image type
        /// </summary>
        public ChatMessageListItemImageAttachmentViewModel ImageAttachment { get; set; }

        /// <summary>
        /// A flag indicating if we have a message or not
        /// </summary>
        public bool HasMessage => Message != null;

        /// <summary>
        /// A flag indicating if we have a image attached to this message
        /// </summary>
        public bool HasImageAttachment => ImageAttachment != null;

        #endregion
    }
}
