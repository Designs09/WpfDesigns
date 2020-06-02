
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Fasetto.Word.Core
{
    public class TaskManager : ITaskManager
    {
        #region Task Methods

        public Task Run(Func<Task> function)
        {
            throw new NotImplementedException();
        }

        public Task<TResult> Run<TResult>(Func<Task<TResult>> function, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<TResult> Run<TResult>(Func<Task<TResult>> function)
        {
            throw new NotImplementedException();
        }

        public Task<TResult> Run<TResult>(Func<TResult> function, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<TResult> Run<TResult>(Func<TResult> function)
        {
            throw new NotImplementedException();
        }

        public Task Run(Func<Task> function, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Run(Action action, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Run(Action action)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Private Helper Methods

        private void LogError(Exception ex)
        {

        }

        #endregion
    }
}
