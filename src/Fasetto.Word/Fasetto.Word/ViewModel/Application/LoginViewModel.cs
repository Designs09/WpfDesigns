﻿using Dna;
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

                // If the response has an error...
                if (await result.DisplayErrorIfFailedAsync("Login Failed"))
                    // We are done
                    return;

                // OK successfully logged in... now get users data
                var loginResult = result.ServerResponse.Response;

                // Let the application view model handle what happens
                // with the successful login
                await DI.ViewModelApplication.HandleSuccessfulLoginAsync(loginResult);
            });
        }

        /// <summary>
        /// Take the user to the register page
        /// </summary>
        /// <returns></returns>
        private async Task RegisterAsync()
        {
            DI.ViewModelApplication.GoToPage(ApplicationPage.Register);

            await Task.Delay(1);
        }
    }
}
