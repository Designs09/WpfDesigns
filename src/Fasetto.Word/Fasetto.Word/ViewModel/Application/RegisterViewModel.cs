using Dna;
using Fasetto.Word.Core;
using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Fasetto.Word
{
    /// <summary>
    /// The View Model for a register screen
    /// </summary>
    public class RegisterViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The email of the user
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The username of the user
        /// </summary>
        public string Username { get; set; }

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
        /// A flag indicating if the register command is running
        /// </summary>
        public bool RegisterIsRunning { get; set; }

        #endregion

        #region Constructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="window"></param>
        public RegisterViewModel()
        {
            // Create commands
            RegisterCommand = new RelayParameterizedCommand(async (parameter) => await RegisterAsync(parameter));

            LoginCommand = new RelayCommand(async () => await LoginAsync());
        }

        #endregion

        /// <summary>
        /// Attempts to register a new user
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        private async Task RegisterAsync(object parameter)
        {
            await RunCommandAsync(() => this.RegisterIsRunning, async () =>
            {
                // Call the server and attempt to register with credentials
                // TODO: Move all URLs and API routes to static class in core
                var result = await WebRequests.PostAsync<ApiResponse<RegisterResultApiModel>>("https://localhost:44325/api/register",
                    new RegisterCredentialsApiModel
                    {
                        Username = Username,
                        Email = Email,
                        //// IMPORTANT: never store unsecure password in variable like this
                        Password = (parameter as IHasPassword).SecurePassword.Unsecure(),
                    });

                // If the response has an error...
                if (await result.DisplayErrorIfFailedAsync("Register Failed"))
                    // We are done
                    return;

                // OK successfully registered (and logged in)... now get users data
                var loginResult = result.ServerResponse.Response;

                // Let the application view model handle what happens
                // with the successful login
                await DI.ViewModelApplication.HandleSuccessfulLoginAsync(loginResult);
            });
        }

        /// <summary>
        /// Take the user to the login page
        /// </summary>
        /// <returns></returns>
        private async Task LoginAsync()
        {
            DI.ViewModelApplication.GoToPage(ApplicationPage.Login);

            await Task.Delay(1);
        }
    }
}
