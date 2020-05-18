using Fasetto.Word.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasetto.Word
{
    public class ViewModelLocator
    {
        /// <summary>
        /// Singleton instance of locator
        /// </summary>
        public static ViewModelLocator Instance { get; private set; } = new ViewModelLocator();

        /// <summary>
        /// The application view model
        /// </summary>
        public ApplicationViewModel ApplicationViewModel => IoC.Application;

        /// <summary>
        /// The settings view model
        /// </summary>
        public SettingsViewModel SettingsViewModel => IoC.Settings;
    }
}
