using System;
using System.Collections.Generic;
using System.Text;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// The user profile for API client to update the server settings
    /// </summary>
    public class UpdateUserProfileApiModel
    {
        /// <summary>
        /// The users first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The users last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The users username
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// The users email
        /// </summary>
        public string Email { get; set; }

    }
}
