using Fasetto.Word.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Fasetto.Word
{
    /// <summary>
    /// The settings state as a view model
    /// </summary>
    public class SettingsViewModel : BaseViewModel
    {
        #region Private Members

        /// <summary>
        /// A flag indicating if we have loaded any values since being created
        /// </summary>
        private bool mLoadedOnce;

        #endregion

        #region Public Properties

        /// <summary>
        /// The current users name
        /// </summary>
        public TextEntryViewModel Name { get; set; }

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
        /// Saves the current name to the server
        /// </summary>
        public ICommand SaveNameCommand { get; set; }

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
            // The text to show while loading
            var loadingText = "...";

            // Create Name 
            Name = new TextEntryViewModel()
            {
                Label = "Name",
                OriginalText = loadingText,
                CommitAction = SaveNameAsync,
            };
            // Create Username 
            Username = new TextEntryViewModel()
            {
                Label = "Username",
                OriginalText = loadingText,
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
                OriginalText = loadingText,
                CommitAction = SaveEmailAsync,
            };

            // Create commands
            CloseCommand = new RelayCommand(Close);
            OpenCommand = new RelayCommand(Open);
            LogoutCommand = new RelayCommand(async () => await LogoutAsync());
            ClearUserDataCommand = new RelayCommand(ClearUserData);
            LoadCommand = new RelayCommand(async () => await LoadAsync());
            SaveNameCommand = new RelayCommand(async () => await SaveNameAsync());
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
            var loadingText = "...";
            Name.OriginalText = loadingText;
            Username.OriginalText = loadingText;
            Email.OriginalText = loadingText;
        }

        /// <summary>
        /// Sets the settings view model properties based on the data in the client data store
        /// </summary>
        public async Task LoadAsync()
        {
            // TODO: Remove once done
            await Task.Delay(5000);

            await UpdateValuesFromLocalStoreAsync();

            // TODO: Load from server

        }

        /// <summary>
        /// Saves the new name to the server
        /// </summary>
        /// <returns>Returns true if successful, false otherwise</returns>
        public async Task<bool> SaveNameAsync()
        {
            // TODO: Update with server
            await Task.Delay(3000);

            // Return fail
            return false;
        }

        /// <summary>
        /// Saves the new username to the server
        /// </summary>
        /// <returns>Returns true if successful, false otherwise</returns>
        public async Task<bool> SaveUsernameAsync()
        {
            // TODO: Update with server
            await Task.Delay(3000);

            // Return success
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

            // Set name
            Name.OriginalText = $"{storedCredentials?.FirstName} {storedCredentials?.LastName}";

            // Set username
            Username.OriginalText = storedCredentials?.Username;

            // Set email
            Email.OriginalText = storedCredentials?.Email;
        }


        #endregion
    }
}
