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
