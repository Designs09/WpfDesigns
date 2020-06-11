using Dna;
using Fasetto.Word.Core;
using Microsoft.Extensions.DependencyInjection;

namespace Fasetto.Word
{
    /// <summary>
    /// Extension methods for the <see cref="FrameworkConstruction"/>
    /// </summary>
    public static class FrameworkConstructionExtensions
    {
        /// <summary>
        /// Injects the view models needed for Fasetto Word application
        /// </summary>
        /// <param name="construction"></param>
        /// <returns></returns>
        public static FrameworkConstruction AddFasettoWordViewModels(this FrameworkConstruction construction)
        {
            //// Bind to a single instance of Application view model
            construction.Services.AddSingleton<ApplicationViewModel>();

            //// Bind to a single instance of Settings view model
            construction.Services.AddSingleton<SettingsViewModel>();

            return construction;
        }

        /// <summary>
        /// Injects the Fasetto Word client application services needed
        /// </summary>
        /// <param name="construction"></param>
        /// <returns></returns>
        public static FrameworkConstruction AddFasettoWordClientServices(this FrameworkConstruction construction)
        {
            // Add our task manager
            construction.Services.AddTransient<ITaskManager, TaskManager>();

            // Bind a file manager
            construction.Services.AddTransient<IFileManager, FileManager>();

            // Bind a UI Manager
            construction.Services.AddTransient<IUIManager, UIManager>();

            return construction;
        }
    }
}