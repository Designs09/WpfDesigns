using Dna;
using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// The View Model for a login screen
    /// </summary>
    public class LoginViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The email of user
        /// </summary>
        public string Email { get; set; }

        #endregion

        #region Commands

        /// <summary>
        /// The command to show the system menu of the window
        /// </summary>
        public ICommand LoginCommand { get; set; }

        /// <summary>
        /// The command to register for a new account
        /// </summary>
        public ICommand RegisterCommand { get; set; }

        /// <summary>
        /// A flag indicating if the login command is running
        /// </summary>
        public bool LoginIsRunning { get; set; }

        #endregion

        #region Constructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="window"></param>
        public LoginViewModel()
        {
            // Create commands
            LoginCommand = new RelayParameterizedCommand(async (parameter) => await LoginAsync(parameter));

            RegisterCommand = new RelayCommand(async () => await RegisterAsync());
        }

        #endregion

        /// <summary>
        /// Attempts to log the user in
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        private async Task LoginAsync(object parameter)
        {
            await RunCommandAsync(() => this.LoginIsRunning, async () =>
            {
                // Call the server and attempt to login with credentials
                // TODO: Move all URLs and API routes to static class in core
                var result = await WebRequests.PostAsync<ApiResponse<LoginResultApiModel>>("https://localhost:44325/api/login",
                    new LoginCredentialsApiModel
                    {
                        UsernameOrEmail = Email,
                        //// IMPORTANT: never store unsecure password in variable like this
                        Password = (parameter as IHasPassword).SecurePassword.Unsecure(),
                    });

                // If there was no respones, bad data, or a response with a error message...
                if (result == null || result.ServerResponse == null || !result.ServerResponse.Successful)
                {
                    // Default error message
                    var message = "Unknow error from server call";

                    // If we got response from the server...
                    if (result?.ServerResponse != null)
                        // Set message to servers response
                        message = result.ServerResponse.ErrorMessage;
                    // If we have a result but deserialize failed...
                    else if (!string.IsNullOrWhiteSpace(result?.RawServerResponse))
                        // Set error message
                        message = $"Unexcepted response from server. {result.RawServerResponse}";
                    // If we have no result at all
                    else if (result != null)
                        // Set message to standard HTTP server response details
                        message = $"Failed to communicate with server. Status code {result.StatusCode}. {result.StatusDescription}";

                    // Display error
                    await IoC.UI.ShowMessage(new MessageBoxDialogViewModel
                    {
                        // TODO: Localize strings
                        Title = "Login failed",
                        Message = message,
                    });

                    return;
                }

                // OK successfully logged in... now get users data
                var userData = result.ServerResponse.Response;

                // Store this in the client data store
                await IoC.ClientDataStore.SaveLoginCredentialsAsync(new LoginCredentialsDataModel
                {
                    Id = Guid.NewGuid().ToString("N"),
                    Email = userData.Email,
                    FirstName = userData.FirstName,
                    LastName = userData.LastName,
                    Username = userData.Username,
                    Token = userData.Token,
                });

                IoC.Settings.Name = new TextEntryViewModel() { Label = "Name", OriginalText = $"{userData.FirstName} {userData.LastName}" };
                IoC.Settings.Username = new TextEntryViewModel() { Label = "Username", OriginalText = userData.Username };
                IoC.Settings.Password = new PasswordEntryViewModel() { Label = "Password", FakePassword = "********" };
                IoC.Settings.Email = new TextEntryViewModel() { Label = "Email", OriginalText = userData.Email };

                // Go to chat page
                IoC.Application.GoToPage(ApplicationPage.Chat);

                //var email = this.Email;


            });
        }

        /// <summary>
        /// Take the user to the register page
        /// </summary>
        /// <returns></returns>
        private async Task RegisterAsync()
        {
            IoC.Application.GoToPage(ApplicationPage.Register);

            await Task.Delay(1);
        }
    }
}
