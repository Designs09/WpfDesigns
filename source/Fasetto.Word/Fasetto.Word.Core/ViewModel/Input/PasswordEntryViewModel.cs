﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// The view model for a password entry to edit a string value
    /// </summary>
    public class PasswordEntryViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The label to identify what this value is for
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// The fake password display string
        /// </summary>
        public string FakePassword { get; set; }

        /// <summary>
        /// The current password hint text
        /// </summary>
        public string CurrentPasswordHintText { get; set; }

        /// <summary>
        /// The confirm password hint text
        /// </summary>
        public string ConfirmPasswordHintText { get; set; }

        /// <summary>
        /// The new password hint text
        /// </summary>
        public string NewPasswordHintText { get; set; }

        /// <summary>
        /// The current saved password
        /// </summary>
        public SecureString OriginalPassword { get; set; }

        /// <summary>
        /// The current non-commit edited password
        /// </summary>
        public SecureString EditedPassword { get; set; }

        /// <summary>
        /// The current non-commit edited confirmed password
        /// </summary>
        public SecureString ConfirmPassword { get; set; }

        /// <summary>
        /// Indicates if the current text is in edit mode
        /// </summary>
        public bool Editing { get; set; }

        #endregion

        #region Public Commands

        /// <summary>
        /// Puts the constrol into edit mode
        /// </summary>
        public ICommand EditCommand { get; set; }

        /// <summary>
        /// Cancels out of edit mode
        /// </summary>
        public ICommand CancelCommand { get; set; }

        /// <summary>
        /// Commits the edits and saves the value
        /// as well as goes back to non-edit mode
        /// </summary>
        public ICommand SaveCommand { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public PasswordEntryViewModel()
        {
            // Create commands
            EditCommand = new RelayCommand(Edit);
            CancelCommand = new RelayCommand(Cancel);
            SaveCommand = new RelayCommand(Save);

            // Set default hints
            // TODO: Replace with localization text
            CurrentPasswordHintText = "Current Password";
            NewPasswordHintText = "New Password";
            ConfirmPasswordHintText = "Confirm Password";
        }

        #endregion

        #region Command Methods

        /// <summary>
        /// Puts the control into edit mode
        /// </summary>
        private void Edit()
        {
            // Clear all password
            EditedPassword = new SecureString();
            ConfirmPassword = new SecureString();

            // Go to edit mode
            Editing ^= true;
        }

        /// <summary>
        /// Cancels out of edit mode
        /// </summary>
        private void Cancel()
        {
            Editing = false;
        }

        /// <summary>
        /// Commits the content and exits out of edit mode
        /// </summary>
        private void Save()
        {
            // Make sure current password is correct
            // TODO: This will come from the real back-end store of this users password
            //       or via asking the web server to confirm it
            var storedPassword = "Testing";

            // Confirm current password is a match
            // NOTE: Typically this isn't done here, it's done on the server
            if (storedPassword != OriginalPassword.Unsecure())
            {
                // Let user know
                IoC.UI.ShowMessage(new MessageBoxDialogViewModel()
                {
                    Title = "Password mismatch",
                    Message = "The current password is invalid",
                    OkText = "OK",
                });

                return;
            }

            // Set the edited password to the current value
            OriginalPassword = new SecureString();
            foreach (var c in EditedPassword.Unsecure().ToCharArray())
                OriginalPassword.AppendChar(c);

            Editing = false;
        }

        #endregion
    }
}
