﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// Stores and retrives information about the client application
    /// such as login credentials, messages, settings and so on
    /// </summary>
    public interface IClientDataStore
    {
        /// <summary>
        /// Make sure the client data store is correctly set up
        /// </summary>
        /// <returns>Returns a task that will finish once setup is complete</returns>
        Task EnsureDataStoreAsync();

        /// <summary>
        /// Determines if the current user has logged in credentials
        /// </summary>
        Task<bool> HasCredentialsAsync();

        /// <summary>
        /// Gets the stored login credentials for this client
        /// </summary>
        /// <returns>Returns the login credentials if they exist, or null if none exist</returns>
        Task<LoginCredentialsDataModel> GetLoginCredentialsAsync();

        /// <summary>
        /// Stores the given login credentials to the backing data store
        /// </summary>
        /// <param name="loginCredentials">The login credentials to save</param>
        /// <returns>Returns a task that will finish once the save is complete</returns>
        Task SaveLoginCredentialsAsync(LoginCredentialsDataModel loginCredentials);

        /// <summary>
        /// Removes all login credentials stored in the data store
        /// </summary>
        /// <returns></returns>
        Task ClearAllLoginCredentialsAsync();
    }
}
