using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Fasetto.Word
{
    /// <summary>
    /// The design time data for <see cref="SettingsViewModel"/>
    /// </summary>
    public class SettingsDesignModel : SettingsViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static SettingsDesignModel Instance => new SettingsDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public SettingsDesignModel()
        {
            FirstName = new TextEntryViewModel() { Label = "FirstName", OriginalText = "Luke" };
            LastName = new TextEntryViewModel() { Label = "LastName", OriginalText = "Malpass" };
            Username = new TextEntryViewModel() { Label = "Username", OriginalText = "Angelsix" };
            Password = new PasswordEntryViewModel() { Label = "Password", FakePassword = "********" };
            Email = new TextEntryViewModel() { Label = "Email", OriginalText = "contact@gmail.com" };
        }

        #endregion

    }
}
