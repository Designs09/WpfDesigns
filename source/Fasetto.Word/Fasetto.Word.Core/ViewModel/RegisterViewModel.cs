using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// The View Model for a register screen
    /// </summary>
    public class RegisterViewModel : BaseViewModel
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
                await Task.Delay(5000);
            });
        }

        /// <summary>
        /// Take the user to the login page
        /// </summary>
        /// <returns></returns>
        private async Task LoginAsync()
        {
            IoC.Application.GoToPage(ApplicationPage.Login);

            await Task.Delay(1);
        }
    }
}
