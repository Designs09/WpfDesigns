﻿using System;
using System.Windows.Input;

namespace Fasetto.Word
{
    /// <summary>
    /// A basic command that runs a Action
    /// </summary>
    public class RelayParameterizedCommand : ICommand
    {
        #region Private Members
        /// <summary>
        /// The action to run
        /// </summary>
        private readonly Action<object> mAction;
        #endregion

        #region Public Events
        /// <summary>
        /// The event thats fired when the <see cref="CanExecute(object)"/> value is changed
        /// </summary>
        public event EventHandler CanExecuteChanged = (sender, e) => { };
        #endregion

        #region Constructor
        public RelayParameterizedCommand(Action<object> action)
        {
            this.mAction = action;
        }
        #endregion

        #region Command Methods
        /// <summary>
        /// A relay command can always execute
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// Executes the commands Action
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            this.mAction(parameter);
        }
        #endregion
    }
}
