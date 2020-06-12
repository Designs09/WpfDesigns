
using Dna;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Fasetto.Word.Core
{
    public class TaskManager : ITaskManager
    {
        #region Task Methods

        public async void RunAndForget(Func<Task> function, [CallerMemberName] string origin = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
        {
            await Run(function, origin, filePath, lineNumber);
        }

        public async Task Run(Func<Task> function, [CallerMemberName] string origin = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
        {
            try
            {
                await Task.Run(function);
            }
            catch (Exception ex)
            {
                // Log error
                FrameworkDI.Logger.LogErrorSource(ex.ToString(), origin: origin, filePath: filePath, lineNumber: lineNumber);

                // Throw it as normal
                throw;
            }
        }

        public async Task<TResult> Run<TResult>(Func<Task<TResult>> function, CancellationToken cancellationToken, [CallerMemberName] string origin = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
        {
            try
            {
                return await Task.Run(function, cancellationToken);
            }
            catch (Exception ex)
            {
                // Log error
                FrameworkDI.Logger.LogErrorSource(ex.ToString(), origin: origin, filePath: filePath, lineNumber: lineNumber);

                // Throw it as normal
                throw;
            }
        }

        public async Task<TResult> Run<TResult>(Func<Task<TResult>> function, [CallerMemberName] string origin = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
        {
            try
            {
                return await Task.Run(function);
            }
            catch (Exception ex)
            {
                // Log error
                FrameworkDI.Logger.LogErrorSource(ex.ToString(), origin: origin, filePath: filePath, lineNumber: lineNumber);

                // Throw it as normal
                throw;
            }
        }

        public async Task<TResult> Run<TResult>(Func<TResult> function, CancellationToken cancellationToken, [CallerMemberName] string origin = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
        {
            try
            {
                return await Task.Run(function, cancellationToken);
            }
            catch (Exception ex)
            {
                // Log error
                FrameworkDI.Logger.LogErrorSource(ex.ToString(), origin: origin, filePath: filePath, lineNumber: lineNumber);

                // Throw it as normal
                throw;
            }
        }

        public async Task<TResult> Run<TResult>(Func<TResult> function, [CallerMemberName] string origin = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
        {
            try
            {
                return await Task.Run(function);
            }
            catch (Exception ex)
            {
                // Log error
                FrameworkDI.Logger.LogErrorSource(ex.ToString(), origin: origin, filePath: filePath, lineNumber: lineNumber);

                // Throw it as normal
                throw;
            }
        }

        public async Task Run(Func<Task> function, CancellationToken cancellationToken, [CallerMemberName] string origin = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
        {
            try
            {
                await Task.Run(function, cancellationToken);
            }
            catch (Exception ex)
            {
                // Log error
                FrameworkDI.Logger.LogErrorSource(ex.ToString(), origin: origin, filePath: filePath, lineNumber: lineNumber);

                // Throw it as normal
                throw;
            }
        }

        public async Task Run(Action action, CancellationToken cancellationToken, [CallerMemberName] string origin = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
        {
            try
            {
                await Task.Run(action, cancellationToken);
            }
            catch (Exception ex)
            {
                // Log error
                FrameworkDI.Logger.LogErrorSource(ex.ToString(), origin: origin, filePath: filePath, lineNumber: lineNumber);

                // Throw it as normal
                throw;
            }
        }

        public async Task Run(Action action, [CallerMemberName] string origin = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
        {
            try
            {
                await Task.Run(action);
            }
            catch (Exception ex)
            {
                // Log error
                FrameworkDI.Logger.LogErrorSource(ex.ToString(), origin: origin, filePath: filePath, lineNumber: lineNumber);

                // Throw it as normal
                throw;
            }
        }

        #endregion
    }
}
