using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasetto.Word
{
    /// <summary>
    /// A design-time data for a <see cref="ChatListViewModel"/>
    /// </summary>
    public class ChatListDesignModel : ChatListViewModel
    {
        #region Constructor

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static ChatListDesignModel Instance => new ChatListDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ChatListDesignModel()
        {
            Items = new List<ChatListItemViewModel>
            {
                new ChatListItemViewModel()
                {
                    Name = "Luke",
                    Initials = "LM",
                    Message = "This chat app is awesome! I bet it will be fast too",
                    ProfilePictureRGB = "3099c5",
                    NewContentAvaliable = true,
                },
                new ChatListItemViewModel()
                {
                    Name = "Jesse",
                    Initials = "JA",
                    Message = "Hey dude, here are the new icons",
                    ProfilePictureRGB = "ffa800",
                    NewContentAvaliable = false,
                },
                new ChatListItemViewModel()
                {
                    Name = "Parnell",
                    Initials = "PL",
                    Message = "The new server is up, got 192.168.1.1",
                    ProfilePictureRGB = "00d405",
                    NewContentAvaliable = false,
                    IsSelected = true,
                },
            };
        }

        #endregion
    }
}
