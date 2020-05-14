using Fasetto.Word.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Fasetto.Word
{
    /// <summary>
    /// Takes a <see cref="ApplicationPage"/> and a view model, if any, and creates the desired page
    /// </summary>
    public static class ApplicationPageHelpers
    {
        
        public static BasePage ToBasePage(this ApplicationPage page, object viewModel = null)
        {
            // Find the appropriate page
            switch (page)
            {
                case ApplicationPage.Login:
                    return new LoginPage(viewModel as LoginViewModel);
                case ApplicationPage.Chat:
                    return new ChatPage(viewModel as ChatMessageListViewModel);
                case ApplicationPage.Register:
                    return new RegisterPage(viewModel as RegisterViewModel);
                default:
                    Debugger.Break();
                    return null;
            }
        }

        /// <summary>
        /// Converts a <see cref="BasePage"/> to the specific <see cref="ApplicationPage"/> this is for that type of page
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public static ApplicationPage ToApplicationPage(this BasePage page)
        {
            // Find application page that matches
            switch (page)
            {
                case ChatPage _:
                    return ApplicationPage.Chat;
                case LoginPage _:
                    return ApplicationPage.Login;
                case RegisterPage _:
                    return ApplicationPage.Register;
            }

            // Alert developer of issue
            Debugger.Break();
            return default;
        }
    }
}
