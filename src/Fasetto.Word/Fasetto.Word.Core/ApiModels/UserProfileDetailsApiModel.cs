using System;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// The result of a successful login request via API
    /// </summary>
    public class UserProfileDetailsApiModel
    {
        #region Public Properties

        /// <summary>
        /// The authentication token used to stay authenticated through future requests
        /// </summary>
        public string Token { get; set; }

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

        #endregion

        #region Public Helper Methods

        /// <summary>
        /// Creates a new <see cref="LoginCredentialsDataModel"/>
        /// from this model
        /// </summary>
        /// <returns></returns>
        public LoginCredentialsDataModel ToLoginCredentialsDataModel()
        {
            return new LoginCredentialsDataModel
            {
                Id = Guid.NewGuid().ToString("N"),
                Email = Email,
                FirstName = FirstName,
                LastName = LastName,
                Username = Username,
                Token = Token,
            };
        }

        #endregion
    }
}
