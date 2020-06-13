using Dna;
using Fasetto.Word.Core;
using Fasetto.Word.Relational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Xsl;

namespace Fasetto.Word
{
    /// <summary>
    /// The settings state as a view model
    /// </summary>
    public class SettingsViewModel : BaseViewModel
    {
        #region Private Members

        // The text to show while loading
        private const string LoadingText = "...";

        #endregion

        #region Public Properties

        /// <summary>
        /// The current users first name
        /// </summary>
        public TextEntryViewModel FirstName { get; set; }

        /// <summary>
        /// The current users last name
        /// </summary>
        public TextEntryViewModel LastName { get; set; }

        /// <summary>
        /// The current users username
        /// </summary>
        public TextEntryViewModel Username { get; set; }

        /// <summary>
        /// The current users password
        /// </summary>
        public PasswordEntryViewModel Password { get; set; }

        /// <summary>
        /// The current users email
        /// </summary>
        public TextEntryViewModel Email { get; set; }

        /// <summary>
        /// The text for the logout button
        /// </summary>
        public string LogoutButtonText { get; set; }

        #endregion

        #region Transactional Properties

        /// <summary>
        /// Indicates if the first name is currently being saved
        /// </summary>
        public bool FirstNameIsSaving { get; set; }

        /// <summary>
        /// Indicates if the last name is currently being saved
        /// </summary>
        public bool LastNameIsSaving { get; set; }

        /// <summary>
        /// Indicates if the username is currently being saved
        /// </summary>
        public bool UsernameIsSaving { get; set; }

        /// <summary>
        /// Indicates if the email is currently being saved
        /// </summary>
        public bool EmailIsSaving { get; set; }

        /// <summary>
        /// Indicates if the password is currently being changed
        /// </summary>
        public bool PasswordIsChanging { get; set; }

        #endregion

        #region Public Commands

        /// <summary>
        /// The command to close the settings menu
        /// </summary>
        public ICommand CloseCommand { get; set; }

        /// <summary>
        /// The command to open the settings menu
        /// </summary>
        public ICommand OpenCommand { get; set; }

        /// <summary>
        /// The command to logout of the application
        /// </summary>
        public ICommand LogoutCommand { get; set; }

        /// <summary>
        /// The command to clear the users data from the view model
        /// </summary>
        public ICommand ClearUserDataCommand { get; set; }

        /// <summary>
        /// Loads the settings data from the client data store
        /// </summary>
        public ICommand LoadCommand { get; set; }

        /// <summary>
        /// Saves the current first name to the server
        /// </summary>
        public ICommand SaveFirstNameCommand { get; set; }

        /// <summary>
        /// Saves the current last name to the server
        /// </summary>
        public ICommand SaveLastNameCommand { get; set; }

        /// <summary>
        /// Saves the current username to the server
        /// </summary>
        public ICommand SaveUsernameCommand { get; set; }

        /// <summary>
        /// Saves the current email to the server
        /// </summary>
        public ICommand SaveEmailCommand { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public SettingsViewModel()
        {
            // Create FirstName 
            FirstName = new TextEntryViewModel()
            {
                Label = "FirstName",
                OriginalText = LoadingText,
                CommitAction = SaveFirstNameAsync,
            };
            // Create LastName 
            LastName = new TextEntryViewModel()
            {
                Label = "LastName",
                OriginalText = LoadingText,
                CommitAction = SaveLastNameAsync,
            };
            // Create Username 
            Username = new TextEntryViewModel()
            {
                Label = "Username",
                OriginalText = LoadingText,
                CommitAction = SaveUsernameAsync,
            };
            // Create Password 
            Password = new PasswordEntryViewModel()
            {
                Label = "Password",
                FakePassword = "********",
                CommitAction = SavePasswordAsync,
            };
            // Create Email 
            Email = new TextEntryViewModel()
            {
                Label = "Email",
                OriginalText = LoadingText,
                CommitAction = SaveEmailAsync,
            };

            // Create commands
            CloseCommand = new RelayCommand(Close);
            OpenCommand = new RelayCommand(Open);
            LogoutCommand = new RelayCommand(async () => await LogoutAsync());
            ClearUserDataCommand = new RelayCommand(ClearUserData);
            LoadCommand = new RelayCommand(async () => await LoadAsync());
            SaveFirstNameCommand = new RelayCommand(async () => await SaveFirstNameAsync());
            SaveLastNameCommand = new RelayCommand(async () => await SaveLastNameAsync());
            SaveUsernameCommand = new RelayCommand(async () => await SaveUsernameAsync());
            SaveEmailCommand = new RelayCommand(async () => await SaveEmailAsync());

            // TODO: Get from localization
            LogoutButtonText = "Logout";
        }

        #endregion

        #region Command Methods

        /// <summary>
        /// Closes the setting menu
        /// </summary>
        public void Close()
        {
            DI.ViewModelApplication.SettingsMenuVisible = false;
        }

        /// <summary>
        /// Opens the setting menu
        /// </summary>
        public void Open()
        {
            DI.ViewModelApplication.SettingsMenuVisible = true;
        }

        /// <summary>
        /// Logs the user out
        /// </summary>
        public async Task LogoutAsync()
        {
            // TODO: Confirm the user wants to logout

            // Clear any user data/cache
            await DI.ClientDataStore.ClearAllLoginCredentialsAsync();

            // Clear all application level view models that contain
            // any information about the current user
            ClearUserData();

            // Go to login page
            DI.ViewModelApplication.GoToPage(ApplicationPage.Login);
        }

        /// <summary>
        /// Clears any data specific to the current user
        /// </summary>
        public void ClearUserData()
        {
            // Clear all view models containing the users info
            FirstName.OriginalText = LoadingText;
            LastName.OriginalText = LoadingText;
            Username.OriginalText = LoadingText;
            Email.OriginalText = LoadingText;
        }

        /// <summary>
        /// Sets the settings view model properties based on the data in the client data store
        /// </summary>
        public async Task LoadAsync()
        {
            // Update values from local cache
            await UpdateValuesFromLocalStoreAsync();

            // Get the user token
            var token = (await DI.ClientDataStore.GetLoginCredentialsAsync()).Token;

            // If we don't have a token (so we are not logged in...)
            if (string.IsNullOrEmpty(token))
                // Then do nothing more
                return;

            // Load user profile details from server
            var result = await WebRequests.PostAsync<ApiResponse<UserProfileDetailsApiModel>>(
                "https://localhost:44325/api/user/profile", 
                //configureRequest: request => request.Headers.Add("Authorization", "Bearer " + token),
                bearerToken: token
                );

            // If it was successful
            if (result.Successful && string.IsNullOrEmpty(result.ServerResponse.ErrorMessage))
            {
                // TODO: Should we check if the values are different before saving?

                // Create data model from the response
                var dataModel = result.ServerResponse.Response.ToLoginCredentialsDataModel();

                // Re-add our known token
                dataModel.Token = token;

                // Save the new information in the data store
                await DI.ClientDataStore.SaveLoginCredentialsAsync(dataModel);

                // Update values from local cache
                await UpdateValuesFromLocalStoreAsync();
            }
        }

        /// <summary>
        /// Saves the new first name to the server
        /// </summary>
        /// <returns>Returns true if successful, false otherwise</returns>
        public async Task<bool> SaveFirstNameAsync()
        {
            return await RunCommandAsync(() => FirstNameIsSaving, async () =>
            {
                // Update the First Name value on the server...
                return await UpdateUserCredentialsValueAsync(
                    // Diaplay name
                    "First Name", 
                    // Update the first name
                    (credentials) => credentials.FirstName, 
                    // The new value
                    FirstName.OriginalText,
                    // Set Api model value
                    (apiModel, newValue) => apiModel.FirstName = newValue
                    );

            }, true);
        }

        /// <summary>
        /// Saves the new last name to the server
        /// </summary>
        /// <returns>Returns true if successful, false otherwise</returns>
        public async Task<bool> SaveLastNameAsync()
        {
            // Get the current known credentials
            var credentials = await DI.ClientDataStore.GetLoginCredentialsAsync();

            // Set the first name
            credentials.LastName = LastName.OriginalText;

            // Update the server with the details
            var result = await WebRequests.PostAsync<ApiResponse>(
                // TODO: Move URLs into better place
                "https://localhost:44325/api/user/profile/update",
                // Create the user details to send
                new UpdateUserProfileApiModel
                {
                    // Set the new first name
                    LastName = credentials.LastName
                }, bearerToken: credentials.Token);

            // If the response has an error...
            if (await result.DisplayErrorIfFailedAsync("Update Last Name Failed"))
                // Return false
                return false;

            // Store the new user credentials to the data store
            await DI.ClientDataStore.SaveLoginCredentialsAsync(credentials);

            // Return successful
            return true;
        }

        /// <summary>
        /// Saves the new username to the server
        /// </summary>
        /// <returns>Returns true if successful, false otherwise</returns>
        public async Task<bool> SaveUsernameAsync()
        {
            // Get the current known credentials
            var credentials = await DI.ClientDataStore.GetLoginCredentialsAsync();

            // Set the first name
            credentials.Username = Username.OriginalText;

            // Update the server with the details
            var result = await WebRequests.PostAsync<ApiResponse>(
                // TODO: Move URLs into better place
                "https://localhost:44325/api/user/profile/update",
                // Create the user details to send
                new UpdateUserProfileApiModel
                {
                    // Set the new first name
                    Username = credentials.Username
                }, bearerToken: credentials.Token);

            // If the response has an error...
            if (await result.DisplayErrorIfFailedAsync("Update Username Failed"))
                // Return false
                return false;

            // Store the new user credentials to the data store
            await DI.ClientDataStore.SaveLoginCredentialsAsync(credentials);

            // Return successful
            return true;
        }

        /// <summary>
        /// Saves the new email to the server
        /// </summary>
        /// <returns>Returns true if successful, false otherwise</returns>
        public async Task<bool> SaveEmailAsync()
        {
            // TODO: Update with server
            await Task.Delay(3000);

            // Return success
            return true;
        }

        /// <summary>
        /// Saves the new password to the server
        /// </summary>
        /// <returns>Returns true if successful, false otherwise</returns>
        public async Task<bool> SavePasswordAsync()
        {
            // TODO: Update with server
            await Task.Delay(3000);

            // Return success
            return true;
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Loads the settings from local data store and binds them 
        /// to this view model
        /// </summary>
        /// <returns></returns>
        private async Task UpdateValuesFromLocalStoreAsync()
        {
            // Get the stored credentials
            var storedCredentials = await DI.ClientDataStore.GetLoginCredentialsAsync();

            // Set first name
            FirstName.OriginalText = storedCredentials?.FirstName;
           
            // Set last name
            LastName.OriginalText = storedCredentials?.LastName;

            // Set username
            Username.OriginalText = storedCredentials?.Username;

            // Set email
            Email.OriginalText = storedCredentials?.Email;
        }

        /// <summary>
        /// Updates a specific value from the client data store for the user profile details 
        /// and attempts to update the server to match those details.
        /// For example, updating the first name of the user.
        /// </summary>
        /// <param name="displayName">The display name for logging and display purposes of the property we are updating</param>
        /// <param name="propertyToUpdate">The property from the <see cref="LoginCredentialsApiModel"/> to be updated</param>
        /// <param name="newValue">The new value to update the property to</param>
        /// <param name="setApiModel">Sets the correct property in the <see cref="UserProfileDetailsApiModel>"/> model that this property maps to</param>
        /// <returns></returns>
        private async Task<bool> UpdateUserCredentialsValueAsync(string displayName, Expression<Func<LoginCredentialsDataModel, string>> propertyToUpdate, string newValue, Action<UpdateUserProfileApiModel, string> setApiModel)
        {
            // Log it 
            Dna.FrameworkDI.Logger.LogDebugSource($"Saving {displayName}...");

            // Get the current known credentials
            var credentials = await DI.ClientDataStore.GetLoginCredentialsAsync();

            // Get the property to update from the credentials
            var toUpdate = propertyToUpdate.GetPropertyValue(credentials);

            // Log it 
            Dna.FrameworkDI.Logger.LogDebugSource($"{displayName} currently {toUpdate}, updating to {newValue}");

            // Check if the value is the same. If so...
            if (toUpdate == newValue)
            {
                // Log it
                Dna.FrameworkDI.Logger.LogDebugSource($"{displayName} is the same, ignoring");

                // Return true
                return true;
            }

            // Set the property
            propertyToUpdate.SetPropertyValue(credentials, newValue);

            // Create update details
            var updateApiModel = new UpdateUserProfileApiModel();

            // Ask caller to set a appropriate value
            // Set the new property
            setApiModel(updateApiModel, newValue);

            // Update the server with the details
            var result = await WebRequests.PostAsync<ApiResponse>(
                // TODO: Move URLs into better place
                "https://localhost:44325/api/user/profile/update",
                // Create the user details to send
                updateApiModel, 
                bearerToken: credentials.Token);

            // If the response has an error...
            if (await result.DisplayErrorIfFailedAsync($"Update {displayName} Failed"))
            {
                // Log it
                Dna.FrameworkDI.Logger.LogDebugSource($"Failed to update {displayName}. {result.ErrorMessage}");

                // Return false
                return false;
            }

            // Log it
            Dna.FrameworkDI.Logger.LogDebugSource($"Successfully updated {displayName}. Saving to local database cache...");

            // Store the new user credentials to the data store
            await DI.ClientDataStore.SaveLoginCredentialsAsync(credentials);

            // Return successful
            return true;
        }

        #endregion
    }
}
