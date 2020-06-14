using Dna;
using Fasetto.Word.Core;
using Fasetto.Word.Relational;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Fasetto.Word
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Custom startup sp we load out IoC immediately before anything else
        /// </summary>
        /// <param name="e"></param>
        protected override async void OnStartup(StartupEventArgs e)
        {
            // Let the base application do what it needs
            base.OnStartup(e);

            // Setup the main application
            await ApplicationSetupAsync();

            // Log it
            FrameworkDI.Logger.LogDebugSource("Application starting up...");

            // Setup the application view model based on if we are logged in
            DI.ViewModelApplication.GoToPage(
                await DI.ClientDataStore.HasCredentialsAsync() ?
                // If we are logged in...
                ApplicationPage.Chat : 
                // Otherwise, goto login page
                ApplicationPage.Login);

            // Show the main window
            Current.MainWindow = new MainWindow();
            Current.MainWindow.Show();
        }

        /// <summary>
        /// Configures our application ready for use
        /// </summary>
        private async Task ApplicationSetupAsync()
        {
            // Setup the Dna Framework
            Framework.Construct<DefaultFrameworkConstruction>()
                .AddFileLogger()
                .AddClientDataStore()
                .AddFasettoWordViewModels()
                .AddFasettoWordClientServices()
                .Build();

            // Ensure the client data store
            await DI.ClientDataStore.EnsureDataStoreAsync();

            // Monitor for server connection status
            MonitorServerStatus();

            // Load settings
            CoreDI.Task.RunAndForget(DI.ViewModelSettings.LoadAsync);
        }

        /// <summary>
        /// Monitors the fasetto website is up, running and reachable
        /// by periodically hitting it up
        /// </summary>
        private void MonitorServerStatus()
        {
            // Create a new endpoint watcher
            var httpWatcher = new HttpEndpointChecker(
                // Checking indicating endpoint
                RouteHelpers.Host,
                // Every 20 seconds
                interval: 20000,
                // Pass in the DI logger
                logger: Framework.Provider.GetService<Microsoft.Extensions.Logging.ILogger>(),
                // Update the view model property with the new result
                stateChangedCallback: result => DI.ViewModelApplication.ServerResponsive = result);
        }
    }
}
