using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Fasetto.Word.Core
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
            Name = new TextEntryViewModel() { Label = "Name", OriginalText = "Luke Malpass" };
            Username = new TextEntryViewModel() { Label = "Username", OriginalText = "Luke" };
            Password = new PasswordEntryViewModel() { Label = "Password", FakePassword = "********" };
            Email = new TextEntryViewModel() { Label = "Email", OriginalText = "contact@gmail.com" };
        }

        #endregion

    }
}
