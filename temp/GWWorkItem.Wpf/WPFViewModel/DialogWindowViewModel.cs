using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace GWWorkItem.Wpf
{
    /// <summary>
    /// The View Model for the custom flat window
    /// </summary>
    public class DialogWindowViewModel : BaseViewModel
    {
        #region 私有字段

        private readonly Window _window;

        #endregion

        #region Public Member

        /// <summary>
        /// The title of this dialog window
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The content to host inside the dialog
        /// </summary>
        public Control Content { get; set; }

        /// <summary>
        /// The smallest height the window can go to
        /// </summary>
        public double WindowMinimumWidth { get; set; } = 800;
        /// <summary>
        /// The smallest height the window can go to
        /// </summary>
        public double WindowMinimumHeight { get; set; } = 500;

        /// <summary>
        /// The height of the title bar / caption of the window
        /// </summary>
        public int TitleHeight { get; set; } = 42;

        #endregion

        #region 指令

        /// <summary>
        /// 关闭指令
        /// </summary>
        public ICommand CloseCommand { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="window"></param>
        public DialogWindowViewModel(Window window) 
        {
            // Make minimum size smaller
            WindowMinimumWidth = 250;
            WindowMinimumHeight = 100;

            // Make title bar smaller
            TitleHeight = 30;

            _window = window;

            CloseCommand = new RelayCommand(Close);
        }

        private void Close()
        {
            _window.Close();
        }

        #endregion
    }
}
