using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// The settings state as a view model
    /// </summary>
    public class SettingsViewModel :BaseViewModel
    {
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
        public TextEntryViewModel Password { get; set; }

        /// <summary>
        /// The current users email
        /// </summary>
        public TextEntryViewModel Email { get; set; }

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

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public SettingsViewModel()
        {
            // Create commands
            CloseCommand = new RelayCommand(Close);
            OpenCommand = new RelayCommand(Open);

            // TODO: Remove this with real information pulled from our database in future
            Name = new TextEntryViewModel() { Label = "Name", OriginalText = "Luke Malpass" };
            Username = new TextEntryViewModel() { Label = "Username", OriginalText = "Luke" };
            Password = new TextEntryViewModel() { Label = "Password", OriginalText = "********" };
            Email = new TextEntryViewModel() { Label = "Email", OriginalText = "contact@gmail.com" };

        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Closes the setting menu
        /// </summary>
        private void Close()
        {
            IoC.Application.SettingsMenuVisible = false;
        }

        /// <summary>
        /// Opens the setting menu
        /// </summary>
        private void Open()
        {
            IoC.Application.SettingsMenuVisible = true;
        }

        #endregion
    }
}
