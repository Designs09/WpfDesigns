﻿using Fasetto.Word.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Fasetto.Word
{
    /// <summary>
    /// ChatPage.xaml 的交互逻辑
    /// </summary>
    public partial class ChatPage : BasePage<ChatMessageListViewModel>
    {
        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="specificViewModel"></param>
        public ChatPage() : base()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor with specific view model
        /// </summary>
        /// <param name="specificViewModel"></param>
        public ChatPage(ChatMessageListViewModel specificViewModel) : base(specificViewModel)
        {
            InitializeComponent();
        }

        #endregion

        #region Override Methods

        protected override void OnViewModelChanged()
        {
            // Make sure UI exists first
            if (ChatMessageList == null)
                return;

            // Fade in chat message list
            var storyboard = new Storyboard();
            storyboard.AddFadeIn(1);
            storyboard.Begin(ChatMessageList);

            // Make the message box focused
            MessageText.Focus();
        }

        #endregion

        /// <summary>
        /// Preview the input into the message box and respond as required
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MessageText_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            // Get the text box
            var textbox = sender as TextBox;

            // Check if we have pressed enter
            if (e.Key == Key.Enter)
            {
                if (Keyboard.Modifiers.HasFlag(ModifierKeys.Control))
                {
                    // Add a new line at the point where the cursor is
                    var index = textbox.CaretIndex;

                    // Insert the new line
                    textbox.Text = textbox.Text.Insert(index, Environment.NewLine);

                    // Shift the caret forward to the newline
                    textbox.CaretIndex = index + Environment.NewLine.Length;

                }
                else
                    // Send the message
                    ViewModel.Send();

                // Make this key as handled by us
                e.Handled = true;
            }
        }
    }
}
