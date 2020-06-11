using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Fasetto.Word
{
    /// <summary>
    /// The view model for a text entry to edit a string value
    /// </summary>
    public class TextEntryViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The label to identify what this value is for
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// The current saved value
        /// </summary>
        public string OriginalText { get; set; }

        /// <summary>
        /// The current non-commit edited text
        /// </summary>
        public string EditedText { get; set; }

        /// <summary>
        /// Indicates if the current text is in edit mode
        /// </summary>
        public bool Editing { get; set; }

        /// <summary>
        /// Indicates if the current control is pending an update (in progress)
        /// </summary>
        public bool Working { get; set; }

        /// <summary>
        /// The action to run when saving the text.
        /// </summary>
        /// <remarks>Returns true if the commit was successful, or false otherwise</remarks>
        public Func<Task<bool>> CommitAction { get; set; }

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
        public TextEntryViewModel()
        {
            // Create commands
            EditCommand = new RelayCommand(Edit);
            CancelCommand = new RelayCommand(Cancel);
            SaveCommand = new RelayCommand(Save);
        }

        #endregion

        #region Command Methods

        /// <summary>
        /// Puts the control into edit mode
        /// </summary>
        private void Edit()
        {
            // Set the edited text to the current value
            EditedText = OriginalText;

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
            // Store the result of a commit call
            // Defaulting to true (if no CommitAction is declared)
            var result = default(bool);

            // Save currently saved value
            var currentSaveValue = OriginalText;

            RunCommandAsync(() => Working, async () =>
            {
                // While working, come out of edit mode
                Editing = false;

                // Commit the change text
                // So we can see it while it is working
                OriginalText = EditedText;

                // Try and do the work
                result = CommitAction == null ? true : await CommitAction();
            }).ContinueWith(t =>
            {
                // If we successded...
                // Nothing to do
                // If we fail...
                if (!result)
                {
                    // Restore original value
                    OriginalText = currentSaveValue;

                    // Go back into edit mode
                    Editing = true;
                }
            });
        }

        #endregion
    }
}
